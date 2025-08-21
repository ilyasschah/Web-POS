﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.Api.Domain
{
    [Table("Barcode")]
    public class Barcode
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }
        private Barcode(string value, int productid)
        {
            Value = value;
            ProductId = productid;
        }

        public Barcode() { }

        public static Barcode Create( string value, int productid)
        {
            if (productid < 0)
            {
                throw new ArgumentException("ProductId must be greater than zero.", nameof(productid));
            }
            return new Barcode(value, productid);
        }
        public void UpdateValue(string newValue)
        {
            if (string.IsNullOrWhiteSpace(newValue))
            {
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(newValue));
            }
            Value = newValue;
        }
    }
}