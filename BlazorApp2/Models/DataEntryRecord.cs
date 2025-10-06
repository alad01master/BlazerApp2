using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2.Models
{
    public class DataEntryRecord
    {
        public int Id { get; set; } // Primary Key
        public required string Name { get; set; }
        public DateTime DateTime { get; set; }
        public required string ProductModel { get; set; }
        public required string PartNumber { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; internal set; }
    }
}
