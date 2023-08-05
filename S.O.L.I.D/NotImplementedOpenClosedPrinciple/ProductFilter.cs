using S.O.L.I.D.Model;

namespace S.O.L.I.D.NotImplementedOpenClosedPrinciple
{
    internal class ProductFilter
    {
        internal IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
                if (p.Color == color)
                    yield return p;
        }
        internal IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
                if (p.Size == size)
                    yield return p;
        }
    }
}
