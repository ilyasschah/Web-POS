using MediatR;
using Products.Api.Repository;

namespace Products.Api.Commands.BarcodesCommands.Update
{
    public class UpdateBarcodeByValuecommand : IRequest<bool>
    {
        public required string BarcodeValue { get; set; }
        public required string NewBarcodeValue { get; set; }
        public class UpdateBarcodeByProductNamecommandHandler : IRequestHandler<UpdateBarcodeByValuecommand, bool>
        {
            private readonly BarcodeRepository _barcodeRepository;
            public UpdateBarcodeByProductNamecommandHandler(
                BarcodeRepository barcodeRepository)
            {
                _barcodeRepository = barcodeRepository;
            }
            public async Task<bool> Handle(UpdateBarcodeByValuecommand request, CancellationToken cancellationToken)
            {
                var barcode = await _barcodeRepository.GetByValueAsync(request.BarcodeValue);
                if (barcode == null) return false;

                //Update the value
                barcode.UpdateValue(request.NewBarcodeValue);
                await _barcodeRepository.UpdateAsync(barcode);
                return true;
            }
        }
    }
}
