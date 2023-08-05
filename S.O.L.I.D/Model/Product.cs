namespace S.O.L.I.D.Model
{
    public enum Size
    {
        Small, Medium, Large, Yuge
    }
    public enum Color
    {
        White,
        Green,
        Blue
    }
    public class Product
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
