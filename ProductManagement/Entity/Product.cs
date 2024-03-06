using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagement.Entity
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long FileId { get; set; }
        public double Price { get; set; }
        public bool IsDeleted { get; set; }

        [NotMapped]

        public FileContentResult FileResult { get; set; }
      
    }
}
