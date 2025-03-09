namespace CMSFormBuilderSample
{
    public class TextField : FormFields
    {
        public int MaxLen { get; set; }
        public TextField(string title, bool isRequired, int maxLen)
        {
            Title = title;
            IsRequired = isRequired;
            MaxLen = maxLen;
        }



        public override FormFields Clone()
        {
            return new TextField(this.Title, this.IsRequired, this.MaxLen);
        }

        public override void Display()
        {
            Console.WriteLine($"TextField - Title: {Title}, Required: {IsRequired}, MaxLength: {MaxLen}");
        }
    }
}
