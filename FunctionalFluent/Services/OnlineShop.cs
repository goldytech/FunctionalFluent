using System;
using System.Collections.Generic;
using System.Linq;
using FunctionalFluent.Abstractions;
using FunctionalFluent.Model;

namespace FunctionalFluent.Services
{
    class OnlineShop : IOnlineShop
    {
        public Func<bool> IsHappyHour { get; internal set; }

        public OnlineShop()
        {
            IsHappyHour = GetRandomCondition;
          
        
        }

        private static bool GetRandomCondition () => true ;  //new Random().Next(100)  <= 20
        public IEnumerable<Product> BrowseProducts(string name)
        {
            return new List<Product>
            {
                new Product("Mobile", "1",new Money(100,"INR")),
                new Product("Laptop", "2", new Money(200,"INR"))
            };
        }

        public Product SelectProduct(IEnumerable<Product> productCatalog)
        {
            return productCatalog.FirstOrDefault();
        }

        public Money Checkout(Product selectedProduct)
        {
          return  selectedProduct.Price;
        }
    }
}