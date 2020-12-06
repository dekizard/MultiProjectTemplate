using System.Collections.Generic;

namespace MultiProjectTemplate.Service
{
    public class ProductService
    {
        public List<string> GetProducts()
        {
            return new List<string>()
            {
                "TV",
                "Mobile Phone",
                "Headphone"
            };
        }
    }
}

