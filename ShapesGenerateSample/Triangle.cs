namespace ShapesGenerateSample
{
    public class Triangle : Shape
    {
        public int BaseLength { get; set; }
        public int Height { get; set; }

        public Triangle(string color, int baseLength, int height)
        {
            Color = color;
            BaseLength = baseLength;
            Height = height;
        }
        public override Shape Clone()
        {
            return new Triangle(this.Color, this.BaseLength, this.Height);
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Triangle with color: {Color}, base: {BaseLength}, height: {Height}");
        }
    }
}
