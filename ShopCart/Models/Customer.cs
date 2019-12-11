using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopCart.Models
{
    public enum Membership
    {
        Bronze,Silver,Gold
    }

    public class Customer
    {
        public int CustomerID   { get; set; }
        public string Title     { get; set; }
        public string Name      { get; set; }
        public int PhoneNum     { get; set; }
        [EmailAddress]
        public String Email     { get; set; }
        public Membership? Membership { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}