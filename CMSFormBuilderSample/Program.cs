using CMSFormBuilderSample;

var nameField = new TextField("Name", true, 100);
var emailField = new TextField("Email", true, 100);
var birthDateField = new DateField("Birth Date", true, new DateTime(1900, 1, 1));
var subscribeCheckBox = new CheckBoxField("Subscribe", false, true);

var clonedNameField = (TextField)nameField.Clone();
clonedNameField.Title = "Full Name";  

var clonedEmailField = (TextField)emailField.Clone();
clonedEmailField.IsRequired = false;  

var clonedBirthDateField = (DateField)birthDateField.Clone();
clonedBirthDateField.MinDate = new DateTime(2000, 1, 1);  

var clonedCheckBox = (CheckBoxField)subscribeCheckBox.Clone();
clonedCheckBox.IsChecked = false;  

nameField.Display();
emailField.Display();
birthDateField.Display();
subscribeCheckBox.Display();

clonedNameField.Display();
clonedEmailField.Display();
clonedBirthDateField.Display();
clonedCheckBox.Display();