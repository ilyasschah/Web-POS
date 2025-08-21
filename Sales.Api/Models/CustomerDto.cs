namespace Sales.Api.Models
{
    public class CustomerDto
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? TaxNumber { get; set; }
        public string? Address { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; }
        public string? CountryName { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public bool? IsEnabled { get; set; }
        public bool? IsCustomer { get; set; }
        public bool? IsSupplier { get; set; }
        public int? DueDatePeriod { get; set; }
        public string? StreetName { get; set; }
        public string? AdditionalStreetName { get; set; }
        public string? BuildingNumber { get; set; }
        public string? PlotIdentification { get; set; }
        public string? CitySubdivisionName { get; set; }
        public string? CountrySubentity { get; set; }
        public bool? IsTaxExempt { get; set; }

    }
    public class CreateCustomerRequest
    {
        public required string  Code { get; set; }
        public required string  Name { get; set; }
        public required string  TaxNumber { get; set; }
        public required string  Address { get; set; }
        public required string  PostalCode { get; set; }
        public required string  City { get; set; }
        public required int  CountryId { get; set; }
        public required DateTime  DateCreated { get; set; }
        public required DateTime  DateUpdated { get; set; }
        public required string  Email { get; set; }
        public required string  PhoneNumber { get; set; }
        public required bool  IsEnabled { get; set; }
        public required bool  IsCustomer { get; set; }
        public required bool  IsSupplier { get; set; }
        public required int  DueDatePeriod { get; set; }
        public required string  StreetName { get; set; }
        public required string  AdditionalStreetName { get; set; }
        public required string  BuildingNumber { get; set; }
        public required string  PlotIdentification { get; set; }
        public required string  CitySubdivisionName { get; set; }
        public required string  CountrySubentity { get; set; }
        public required bool IsTaxExempt { get; set; }

    }
    public class UpdateCustomerRequest
    {
        public required string Name { get; set; }
        public required DateTime DateUpdated { get; set; }
    }
}