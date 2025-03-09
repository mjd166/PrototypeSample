namespace CMSFormBuilderSample
{
    public abstract class FormFields
    {
        public string Title { get; set; }
        public string FieldType { get; set; }
        public bool IsRequired { get; set; }

        public abstract FormFields Clone();
        public abstract void Display();
    }
}
