using S.O.L.I.D.ImplementedOpenClosedPrinciple;
using S.O.L.I.D.Model;

namespace S.O.L.I.D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>();
            products.Add(new Product("iPhone", Color.Blue, Size.Large));
            products.Add(new Product("iPhone", Color.White, Size.Large));
            products.Add(new Product("iPhone", Color.White, Size.Large));
            products.Add(new Product("iPhone 13", Color.Green, Size.Small));

            var colorSpecification = new ColorSpecification(Color.Green);
            var sizeSpecification = new SizeSpecification(Size.Small);

            var compositeSpecification = new ComposeSpecification<Product>(colorSpecification, sizeSpecification);

            var filter = new BetterFilter();
            var result = filter.Filter(products, compositeSpecification);
            foreach(var item in result)
            {
                Console.WriteLine($"{item.Name}");
            }
        }
    }
}