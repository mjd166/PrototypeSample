namespace ShapesGenerateSample
{
    public class Rectangle : Shape
    {
        public Rectangle(string color, int height, int width)
        {
            Color = color;
            Height = height;
            Width = width;
        }

        public int Height { get; set; }
        public int Width { get; set; }

        public override Shape Clone()
        {
           return new Rectangle(this.Color, this.Height, this.Width);
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing rectangle with color: {this.Color}, width:{this.Width}, height:{Height}");
        }
    }

}
