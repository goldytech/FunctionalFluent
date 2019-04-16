using System;
using FunctionalFluent.Model;
using FunctionalFluent.Services;
using FunctionalFluent.Utils;

namespace FunctionalFluent
{
    class Program
    {
        static void Main(string[] args)
        {

            var onlineShop = new OnlineShop();


            Money ApplyDiscount(Money money)
            {
                var thisMoney = new Money(money.Amount,money.Currency);
                Console.WriteLine("Discount Applied");

                var totalDiscount = thisMoney.Scale(.1M);

                return thisMoney - totalDiscount;
            }

            onlineShop.BrowseProducts("mobile")
                .Map(products => onlineShop.SelectProduct(products))
                .Map(product => onlineShop.Checkout(product))
                .When(onlineShop.IsHappyHour, ApplyDiscount)
               .Tee(money => Console.WriteLine($"Thanks for shopping. You have successfully paid {money.ToString()}"));

            Console.ReadLine();
        }
    }
}
