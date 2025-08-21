using Microsoft.EntityFrameworkCore;
using Products.Api.DataBase;
using Products.Api.Domain;
using Products.Api.Models;

namespace Products.Api.Repository
{
    public class BarcodeRepository
    {
        public AppDbContext _db;

        public BarcodeRepository(AppDbContext db)
        {
            _db = db;
        }
        public async Task<List<Barcode>> GetProductsNamesBarcodesAsync()
        {
            return await _db.Barcodes
                .AsNoTracking()
                .Include(BarCode => BarCode.Product)
                .ToListAsync();
        }
        public async Task<Barcode?> GetBarCodeByIdQuery(int id)
        {
            return await _db.Barcodes
            .AsNoTracking()
            .Include(b => b.Product)
            .FirstOrDefaultAsync(b => b.Id == id);
        }
        public async Task<Barcode?> GetByValueAsync(string value)
        {
            return await _db.Barcodes
                .FirstOrDefaultAsync(b => b.Value == value);
        }
        public bool Exists(string valeu)
        {
            return _db.Barcodes.Any(c => c.Value == valeu);
        }
        public async Task Add(Barcode newBarcode)
        {
            _db.Barcodes.Add(newBarcode);
            await _db.SaveChangesAsync();
        }        
        public async Task UpdateAsync(Barcode barcode)
        {
            _db.Barcodes.Update(barcode);
            await _db.SaveChangesAsync();
        }
        public async Task DeleteAsync(Barcode barcode)
        {
            _db.Barcodes.Remove(barcode);
            await _db.SaveChangesAsync();
        }
    }
}
