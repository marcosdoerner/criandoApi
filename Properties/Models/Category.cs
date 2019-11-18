using System.Collections.Generic;

namespace criandoApi.Properties.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<Product> Products { get; set; }  
        

    }
}