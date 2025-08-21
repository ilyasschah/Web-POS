using MediatR;
using Products.Api.Helpers;
using Products.Api.Models;
using Products.Api.Repository;
namespace Products.Api.Queries.BarCodesQuery.Get
{
    public class GetBarcodeByIdQuery : IRequest<BarcodeDto?>
    {
        public int Id { get; set; }

        public GetBarcodeByIdQuery(int id)
        {
            Id = id;
        }
    }
    public class GetBarcodeByIdQueryHandler : IRequestHandler<GetBarcodeByIdQuery, BarcodeDto?>
    {
         private readonly BarcodeRepository _barcodeRepository;

         public GetBarcodeByIdQueryHandler(BarcodeRepository barcodeRepository)
         {
             _barcodeRepository = barcodeRepository;
         }
         public async Task<BarcodeDto?> Handle(GetBarcodeByIdQuery request, CancellationToken cancellationToken)
         {
            var barcode = await _barcodeRepository.GetBarCodeByIdQuery(request.Id);
            if (barcode is null)
            {
                return null;
            }
            return new BarcodeDto
            {
                Value = barcode.Value,
                ProductName = barcode.Product.Name // This requires the Product to be loaded
            };
            //var barcode = await _barcodeRepository.GetBarCodeByIdQuery();                       ask rkia
            //return barcode.Select(MapperBarcode.MapBarCodes).Tolist();

         }
    }
}