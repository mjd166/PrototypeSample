namespace ShapesGenerateSample
{

    /// <summary>
    /// protottype base class
    /// </summary>
    public abstract class Shape
    {
        public string Color { get; set; }

        //for clone (copy)
        public abstract Shape Clone();
        public abstract void Draw();
    }
}
