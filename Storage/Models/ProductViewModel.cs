using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        [Range(1000, 10000)]
        public int Price { get; set; }
        public int Count { get; set; }
        public int InventoryValue { get; set; }
        public string Category { get; internal set; }
    }
}
