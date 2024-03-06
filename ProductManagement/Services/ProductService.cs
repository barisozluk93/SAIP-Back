using Microsoft.EntityFrameworkCore;
using ProductManagement.DbContexts;
using ProductManagement.Entity;
using ProductManagement.Interfaces;
using ProductManagement.Model;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ProductManagement.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductManagementContext _dbContext;

        private readonly IConfiguration _configuration;

        public ProductService(ProductManagementContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        public async Task<Result<Product>> Delete(long id)
        {
            var result = new Result<Product>();

            using (var transaction = _dbContext.Database.BeginTransaction(IsolationLevel.ReadUncommitted))
            {
                try
                {
                    var oldProduct = await _dbContext.Products.Where(x => x.Id == id && !x.IsDeleted).FirstOrDefaultAsync();
                    if (oldProduct != null)
                    {
                        oldProduct.IsDeleted = true;

                        await _dbContext.SaveChangesAsync();
                        transaction.Commit();

                        result.SetData(oldProduct);
                        result.SetMessage("İşlem başarı ile gerçekleşti.");
                    }
                    else
                    {
                        result.SetIsSuccess(false);
                        result.SetMessage("Böyle bir kayıt bulunmamaktadır.");
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    result.SetIsSuccess(false);
                    result.SetMessage(ex.Message);
                }
            }

            return result;
        }

        public async Task<Result<Product>> GetById(long id, string token)
        {
            var result = new Result<Product>();

            using (var transaction = _dbContext.Database.BeginTransaction(IsolationLevel.ReadUncommitted))
            {
                try
                {
                    var product = await _dbContext.Products.Where(x => x.Id == id && !x.IsDeleted).FirstOrDefaultAsync();
                    if (product != null)
                    {
                        product.FileResult = GetFileResult(product.FileId, token);

                        result.SetData(product);
                        result.SetMessage("İşlem başarı ile gerçekleşti.");
                    }
                    else
                    {
                        result.SetIsSuccess(false);
                        result.SetMessage("Böyle bir kayıt bulunmamaktadır.");
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }

            return result;
        }

        public async Task<Result<List<Product>>> GetProducts()
        {
            var result = new Result<List<Product>>();

            using (var transaction = _dbContext.Database.BeginTransaction(IsolationLevel.ReadUncommitted))
            {
                try
                {
                    var data = await _dbContext.Products.Where(x => !x.IsDeleted).ToListAsync();

                    result.SetData(data);
                    result.SetMessage("İşlem başarı ile gerçekleşti.");
                }
                catch (Exception ex)
                {
                    result.SetIsSuccess(false);
                    result.SetMessage(ex.Message);
                }
            }

            return result;
        }

        public async Task<Result<PagingResult<PagedList<Product>>>> Paginate(PagingParameter pagingParameter, string token)
        {
            var result = new Result<PagingResult<PagedList<Product>>>();

            using (var transaction = _dbContext.Database.BeginTransaction(IsolationLevel.ReadUncommitted))
            {
                try
                {
                    var queryable = _dbContext.Products.Where(x => !x.IsDeleted).Select(s => new Product
                    {
                        Id = s.Id,
                        Name = s.Name,
                        Price = s.Price,
                        FileId = s.FileId,
                        IsDeleted = s.IsDeleted,
                    });

                    var pagination = PagedList<Product>.ToPagedList(queryable, pagingParameter.PageNumber, pagingParameter.PageSize);

                    pagination.ForEach(x => x.FileResult = GetFileResult(x.FileId, token));

                    result.SetData(new PagingResult<PagedList<Product>>()
                    {
                        Items = pagination,
                        TotalCount = pagination.TotalCount,
                    });

                    result.SetMessage("İşlem başarı ile gerçekleşti.");
                }
                catch (Exception ex)
                {
                    result.SetIsSuccess(false);
                    result.SetMessage(ex.Message);
                }
            }

            return result;
        }

        public async Task<Result<Product>> Save(Product product)
        {
            var result = new Result<Product>();

            using (var transaction = _dbContext.Database.BeginTransaction(IsolationLevel.ReadUncommitted))
            {
                try
                {
                    if (!_dbContext.Products.Where(x => (x.Name == product.Name) && !x.IsDeleted).Any())
                    {
                        _dbContext.Add(product);
                        await _dbContext.SaveChangesAsync();
                        transaction.Commit();

                        result.SetData(product);
                        result.SetMessage("İşlem başarı ile gerçekleşti.");
                    }
                    else
                    {
                        result.SetIsSuccess(false);
                        result.SetMessage("Aynı isim veya kodla tanımlı bir yetki bulunmaktadır.");
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    result.SetIsSuccess(false);
                    result.SetMessage(ex.Message);
                }
            }

            return result;
        }

        public async Task<Result<Product>> Update(Product product)
        {
            var result = new Result<Product>();

            using (var transaction = _dbContext.Database.BeginTransaction(IsolationLevel.ReadUncommitted))
            {
                try
                {
                    var oldProduct = await _dbContext.Products.Where(x => x.Id == product.Id && !x.IsDeleted).FirstOrDefaultAsync();

                    if (oldProduct != null)
                    {
                        if (!_dbContext.Products.Where(x => x.Id != oldProduct.Id && (x.Name == product.Name) && !x.IsDeleted).Any())
                        {
                            oldProduct.Name = product.Name;
                            oldProduct.FileId = product.FileId;
                            oldProduct.Price = product.Price;

                            await _dbContext.SaveChangesAsync();
                            transaction.Commit();

                            result.SetData(product);
                            result.SetMessage("İşlem başarı ile gerçekleşti.");
                        }
                        else
                        {
                            result.SetIsSuccess(false);
                            result.SetMessage("Aynı isim veya kodla tanımlı bir yetki bulunmaktadır.");
                        }
                    }
                    else
                    {
                        result.SetIsSuccess(false);
                        result.SetMessage("Böyle bir kayıt bulunmamaktadır.");
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    result.SetIsSuccess(false);
                    result.SetMessage(ex.Message);
                }
            }

            return result;
        }

        private FileContentResult GetFileResult(long id, string token)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = client.GetAsync(_configuration["AppSettings:ApiUrl"] + "/api/File/" + id).Result;

            if (response.IsSuccessStatusCode)
            {
                var responseStr = response.Content.ReadAsStringAsync().Result;

                if (!string.IsNullOrEmpty(responseStr))
                {
                    try
                    {
                        Result<Model.File> result = JsonConvert.DeserializeObject<Result<Model.File>>(responseStr);

                        if (result != null)
                        {
                            byte[] bytes = System.IO.File.ReadAllBytes(result.GetData().Path);
                            return new FileContentResult(bytes, result.GetData().ContentType);
                        }
                        else
                        {
                            return null;
                        }
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }

                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

            return null;
        }
    }
}
