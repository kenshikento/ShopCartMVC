using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopCart.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Transaction
    {
        public int ID { get; set; }
        public int OrderItemID { get; set; }
        public int QuantityItemID { get; set; }

        public virtual OrderItem OrderItem { get; set; }
        public virtual QuantityItem QuantityItem { get; set; }
    }
}