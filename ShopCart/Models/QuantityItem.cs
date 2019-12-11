using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopCart.Models
{
    public class QuantityItem
    {
        public int ID           { get; set; }
        public int Quantity     { get; set; }
        public int ProductID    { get; set; }

        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}