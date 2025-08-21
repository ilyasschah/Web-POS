using MediatR;
using Products.Api.Domain;
using Products.Api.Models;
using Products.Api.Repository;
using Products.Api.Services;


namespace Products.Api.Commands.BarcodesCommands.Add
{
    public class AddBarcodecommand: IRequest<bool>
    {
        public CreateBarcodeRequest Request { get; set; }
        public AddBarcodecommand(CreateBarcodeRequest createBarcodeRequest)
        {
            Request = createBarcodeRequest;
        }
        public class AddBarcodecommandHandler : IRequestHandler<AddBarcodecommand, bool>
        {
            private readonly BarcodeService _barcodeService;
            public AddBarcodecommandHandler(BarcodeService barcodeService)
            {
                _barcodeService = barcodeService;
            }
            public Task<bool> Handle(AddBarcodecommand request, CancellationToken cancellationToken)
            {
                return _barcodeService.Create(request.Request.Value, request.Request.ProductId);
            }
        }
    }

}
