using System.Collections.Generic;
using FunctionalFluent.Model;

namespace FunctionalFluent.Abstractions
{
    public interface IProductSearch
    {
        IEnumerable<Product> SearchProductsByName(string name);
    }
}