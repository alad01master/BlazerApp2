using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Server.DTOs
{
    public class DataEntryCreateDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string ProductModel { get; set; } = string.Empty;

        [Required]
        public string PartNumber { get; set; } = string.Empty;

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        [Range(0.0, double.MaxValue)]
        public decimal Price { get; set; }
    }
}
