namespace WinFormUI
{
    public partial class DashBoard : Form
    {
        public DashBoard() => InitializeComponent();

        private void generateEmployeeIdButton_Click(object sender, EventArgs e)
        {

            string employeeId = $@"{firstNameText.Text.Substring(0, 4)}{lastNameText.Text.Substring(0, 4)}{DateTime.Now.Microsecond}";
            employeeIdText.Text = employeeId;
        }
    }
}