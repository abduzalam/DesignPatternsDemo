using DRYDemoLibrary;
namespace WinFormUI
{
    public partial class DashBoard : Form
    {
        private EmployeeProcessor _EmployeeProcessor;
        public DashBoard()
        {
            InitializeComponent();
            _EmployeeProcessor = new EmployeeProcessor();
        }

        private void generateEmployeeIdButton_Click(object sender, EventArgs e)
        {
            employeeIdText.Text = _EmployeeProcessor.GenerateEmployeeID(firstNameText.Text, lastNameText.Text);

        }
        // We are re-using the GenerateEmployeeID method from DemoLibrary to share this in two different projects, thus not re-using the code in two different projects

        //private string GenerateEmployeeID(string firstName, string lastName)
        //{
        //    string employeeId = $@"{firstName.Substring(0, 4)}{lastName.Substring(0, 4)}{DateTime.Now.Microsecond}";
        //    return employeeId;
        //}
    }
}