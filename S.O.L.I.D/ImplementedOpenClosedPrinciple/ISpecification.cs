using S.O.L.I.D.Model;

namespace S.O.L.I.D.ImplementedOpenClosedPrinciple
{
    //to implement principle open closed here...

    public interface ISpecification<T>
    {
       bool IsSatisfied(T entity);
    }
    public interface IFilter<T>
    {
        public IEnumerable<T>Filter(IEnumerable<T> items, ISpecification<T> specification);
    }

    public class ColorSpecification : ISpecification<Product>
    {
        private readonly Color _color;
        public ColorSpecification(Color color)
        {
            _color = color;
        }
        bool ISpecification<Product>.IsSatisfied(Product entity)
        {
            return entity.Color == _color;
        }
    }
    public class SizeSpecification : ISpecification<Product>
    {
        private readonly Size _size;
        public SizeSpecification(Size size)
        {
            _size = size;
        }
        public bool IsSatisfied(Product entity)
        {
           return entity.Size == _size;
        }
    }

    public class ComposeSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _first;
        private readonly ISpecification<T> _second;
        public ComposeSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            _first = first;
            _second = second;
        }

        public bool IsSatisfied(T entity)
        {
            return _first.IsSatisfied(entity) && _second.IsSatisfied(entity);
        }

        
    }
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specification)
        {
            foreach(var item in items)
            {
                if(specification.IsSatisfied(item))
                    yield return item;
            }
        }
    }
}
