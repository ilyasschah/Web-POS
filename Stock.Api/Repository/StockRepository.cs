using Microsoft.EntityFrameworkCore;
using Stocks.Api.DataBase;
using Stocks.Api.Domain;

namespace Stocks.Api.Repository
{
    public class StockRepository(AppDbContext db)
    {
        private readonly AppDbContext _db = db;

        public async Task<List<Stock>> GetAllProducts_warehouse_StocksAsync()
        {
            return await _db.Stocks
                .AsNoTracking()
                .Include(wn => wn.Warehouse)
                .Include(pn => pn.Product)
                .ToListAsync();
        }
        public async Task Add(Stock newstock)
        {
            _db.Stocks.Add(newstock);
            await _db.SaveChangesAsync();
        }
        //public async Task<Inventory> UpdateProductCommentAsync(Inventory productComment)
        //{
        //    _db.Inventories.Update(productComment);
        //    await _db.SaveChangesAsync();
        //    await _db.Entry(productComment)
        //        .Reference(pc => pc.Product)
        //        .LoadAsync();

        //    return productComment;
        //}

        public async Task DeleteQantityAsync(Stock stock)
        {
            _db.Stocks.Remove(stock);
            await _db.SaveChangesAsync();
        }
        public bool Exist(int productid)
        {
            return _db.Stocks.Any(s => s.Product.Id == productid);
        }
    }
}