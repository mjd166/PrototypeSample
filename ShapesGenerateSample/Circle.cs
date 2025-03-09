namespace ShapesGenerateSample
{
    public class Circle : Shape
    {
        public Circle(string color, int radius)
        {
            Color = color;
            Radius = radius;
        }

        public int Radius { get; set; }

        public override Shape Clone()
        {
            return new Circle(this.Color, this.Radius);
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing Circle with color {this.Color} , radius {this.Radius}");
        }

    }



}
