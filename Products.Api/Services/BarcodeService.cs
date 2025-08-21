using Products.Api.Domain;
using Products.Api.Repository;

namespace Products.Api.Services
{
    public class BarcodeService
    {
        public BarcodeRepository _barcodeRepository;
        public BarcodeService(BarcodeRepository carcodeRepository)
        {
            _barcodeRepository = carcodeRepository;
        }
        public async Task<bool> Create(string valeu, int productsid)
        {
            var cexists = _barcodeRepository.Exists(valeu);
            if (cexists == true)
                throw new InvalidOperationException($"A Barcode with the Value '{valeu}' already exists.");
            var newcurreency = Barcode.Create(valeu, productsid);
            await _barcodeRepository.Add(newcurreency);
            return true;
        }
    }
}
