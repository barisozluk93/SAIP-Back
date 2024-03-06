using ProductManagement.Entity;
using ProductManagement.Model;
using Microsoft.AspNetCore.Mvc;

namespace ProductManagement.Interfaces
{
    public interface IProductService
    {
        Task<Result<PagingResult<PagedList<Product>>>> Paginate(PagingParameter pagingParameter, string token);
        Task<Result<List<Product>>> GetProducts();
        Task<Result<Product>> Save(Product product);
        Task<Result<Product>> Update(Product product);
        Task<Result<Product>> Delete(long id);
        Task<Result<Product>> GetById(long id, string token);
    }
}
