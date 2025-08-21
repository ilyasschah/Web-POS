﻿using Stocks.Api.Domain;
using Stocks.Api.Models;

namespace Stocks.Api.Helpers
{
    public class MapperStock
    {
        //public static List<StockDto> MapToStock(List<Stock> stock)
        //{
        //    return stock.Select(s => new StockDto
        //    {
        //        Quantity = s.Quantity,                                                        ask rkia again
        //        ProductName = s.Product.Name,
        //        WarehouseName = s.Warehouse.Name
        //    }).ToList();
        //}
        public static StockDto MapToStock(Stock stock)
        {
            return new StockDto
            {
                Quantity = stock.Quantity,
                ProductName = stock.Product?.Name,
                WarehouseName = stock.Warehouse?.Name
            };
        }
    }
}
