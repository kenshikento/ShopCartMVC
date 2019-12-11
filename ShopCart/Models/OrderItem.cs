using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopCart.Models
{
    public class OrderItem
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public DateTime Date { get; set; }

        //public virtual ICollection<Transaction> Transactions { get; set; }
    }
}