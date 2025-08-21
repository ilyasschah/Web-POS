namespace Products.Api.Models
{
    public class BarcodeDto
    {
        public string? Value { get; set; }
        public string? ProductName { get; set; }
    }
    public class CreateBarcodeRequest
    {
        public required string Value { get; set; }
        public required int ProductId { get; set; }
    }
    public class UpdateBarcodeByValueDto
    {
        public required string BarcodeValue { get; set; }
        public required string NewBarcodeValue { get; set; }
    }
}