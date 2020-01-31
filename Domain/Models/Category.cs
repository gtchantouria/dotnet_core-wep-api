using System.Collections.Generic;

namespace dotnet.Domain.Models
{
    public class Category {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Product> Products => new List<Product>();
    }
}