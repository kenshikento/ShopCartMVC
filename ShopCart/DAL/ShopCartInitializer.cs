using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopCart.Models;

namespace ShopCart.DAL
{
    public class ShopCartInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ShopCartContext>
    {   
        protected override void Seed(ShopCartContext context)     
        {
            var customers = new List<Customer>
            {
                new Customer{Title="Mr",Name="Alexander",PhoneNum=01787464392,Email="example@hotmail.co.uk"},
                new Customer{Title="Mr",Name="Alonso",PhoneNum=01787464392,Email="example@hotmail.co.uk"},
                new Customer{Title="Mr",Name="Anand",PhoneNum=01787464392,Email="example@hotmail.co.uk"},
                new Customer{Title="Mr",Name="Barzdukas",PhoneNum=01787464392,Email="example@hotmail.co.uk"},
                new Customer{Title="Mr",Name="Li",PhoneNum=01787464392,Email="example@hotmail.co.uk"},
                new Customer{Title="Mr",Name="Justice",PhoneNum=01787464392,Email="example@hotmail.co.uk"},
                new Customer{Title="Mr",Name="Norman",PhoneNum=01787464392,Email="example@hotmail.co.uk"},
                new Customer{Title="Mr",Name="Olivetto",PhoneNum=01787464392,Email="example@hotmail.co.uk"}
            };

            customers.ForEach(s => context.Customer.Add(s));
            context.SaveChanges();

            var orderItem = new List<OrderItem>
            {
                new OrderItem{CustomerID=1,Date=DateTime.Parse("2001-09-01")},
                new OrderItem{CustomerID=2,Date=DateTime.Parse("2001-09-01")},
                new OrderItem{CustomerID=2,Date=DateTime.Parse("2001-09-01")},
                new OrderItem{CustomerID=3,Date=DateTime.Parse("2001-09-01")},
                new OrderItem{CustomerID=4,Date=DateTime.Parse("2001-09-01")},
                new OrderItem{CustomerID=5,Date=DateTime.Parse("2001-09-01")},
                new OrderItem{CustomerID=6,Date=DateTime.Parse("2001-09-01")},
                new OrderItem{CustomerID=7,Date=DateTime.Parse("2001-09-01")},
                new OrderItem{CustomerID=8,Date=DateTime.Parse("2001-09-01")},
            };

            orderItem.ForEach(s => context.OrderItem.Add(s));
            context.SaveChanges();
            
            var products = new List<Product>
            {
                new Product{Title="Apple",Description="fdsf",Price=2.99m},
                new Product{Title="Orange",Description="fdsf",Price=4.99m},
                new Product{Title="Pie",Description="fdsf",Price=5.99m},
            };

            products.ForEach(s => context.Product.Add(s));
            context.SaveChanges();

            var quantityItems = new List<QuantityItem>
            {
                new QuantityItem{ProductID=1,Quantity=10},
                new QuantityItem{ProductID=1,Quantity=2},
                new QuantityItem{ProductID=1,Quantity=3},
                new QuantityItem{ProductID=2,Quantity=4},
                new QuantityItem{ProductID=2,Quantity=5},
                new QuantityItem{ProductID=3,Quantity=10},
                new QuantityItem{ProductID=3,Quantity=10}
            };
            quantityItems.ForEach(s => context.QuantityItem.Add(s));
            context.SaveChanges();

            var transactions = new List<Transaction>
            {
                new Transaction{OrderItemID=1,QuantityItemID=1},
                new Transaction{OrderItemID=2,QuantityItemID=2},
                new Transaction{OrderItemID=3,QuantityItemID=3},
                new Transaction{OrderItemID=4,QuantityItemID=4},
                new Transaction{OrderItemID=5,QuantityItemID=5},
                new Transaction{OrderItemID=6,QuantityItemID=6},
            };
            transactions.ForEach(s => context.Transaction.Add(s));
            context.SaveChanges();
        }
    }

}
