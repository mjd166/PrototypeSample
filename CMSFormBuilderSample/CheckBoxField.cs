namespace CMSFormBuilderSample
{
    public class CheckBoxField : FormFields
    {
        public CheckBoxField(string title, bool isRequired, bool isChecked)
        {
            Title = title;
            IsRequired = isRequired;
            IsChecked = isChecked;
        }

        public bool IsChecked { get; set; }

        public override FormFields Clone()
        {
            return new CheckBoxField(this.Title,this.IsRequired,this.IsChecked);
        }
        public override void Display()
        {
            Console.WriteLine($"CheckBoxField - Title: {Title}, Required: {IsRequired}, Checked: {IsChecked}");
        }
    }
}
