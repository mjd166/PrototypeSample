namespace CMSFormBuilderSample
{
    public class DateField : FormFields
    {
        public DateField(string title, bool isRequired, DateTime minDate)
        {
            Title = title;
            IsRequired = isRequired;
            MinDate = minDate;
        }

        public DateTime MinDate { get; set; }

        public override FormFields Clone()
        {
             return new  DateField(this.Title,this.IsRequired,this.MinDate);
        }
        public override void Display()
        {
            Console.WriteLine($"DateField - Title: {Title}, Required: {IsRequired}, MinDate: {MinDate.ToShortDateString()}");
        }
    }
}
