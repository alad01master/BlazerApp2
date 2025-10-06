namespace BlazorApp2.Server.DTOs
{
    public class DataEntryReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ProductModel { get; set; } = string.Empty;
        public string PartNumber { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DateTime { get; internal set; }
    }
}
