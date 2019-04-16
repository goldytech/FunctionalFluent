namespace FunctionalFluent.Model
{
    public class Product
    {
        public Product(string name, string id, Money price)
        {
            Name = name;
            Id = id;
            Price = price;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public Money Price { get; private set; }
    }
}