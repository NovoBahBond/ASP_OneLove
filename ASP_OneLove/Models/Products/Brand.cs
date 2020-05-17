using System.Collections.Generic;

namespace ASP_OneLove.Models.Products
{
    public class Brand
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public List<int> ProductsIds { get; set; }
    }
}
