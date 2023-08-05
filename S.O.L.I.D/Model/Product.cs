namespace S.O.L.I.D.Model
{
    internal enum Size
    {
        Small, Medium, Large, Yuge
    }
    internal enum Color
    {
        White,
        Green,
        Blue
    }
    internal class Product
    {
        public string Name;
        public Color Color;
        public Size Size;
        public Product(string name, Color color, Size size)
        {
           Name = name;
           Color = color;
           Size = size;
        }
    }
}
