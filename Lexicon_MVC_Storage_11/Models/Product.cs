using System.ComponentModel.DataAnnotations;

namespace Lexicon_MVC_Storage_11.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }
        public string? Category { get; set; }
        public string? Shelf { get; set; }
        [Range(1,20)]
        public int Count { get; set; }
        public string? Description { get; set; }
    }
}
