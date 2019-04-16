using System.Collections.Generic;
using FunctionalFluent.Model;

namespace FunctionalFluent.Abstractions
{
    public interface IOnlineShop

    {
        IEnumerable<Product> BrowseProducts(string name);
        Product SelectProduct(IEnumerable<Product> productCatalog);
        Money Checkout(Product selectedProduct);




    }
}