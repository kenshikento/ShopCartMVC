using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopCart.Models
{
    public class Product
    {
        public int ProductID        { get; set; }
        public string Title         { get; set; }
        public string Name          { get; set; }
        public string Description   { get; set; }
        public decimal Price        { get; set; }


        public virtual ICollection<QuantityItem> OrderItems { get; set; }
    }
}