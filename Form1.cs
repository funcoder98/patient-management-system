
string filePath = @"C:\Users\Taffi\source\repos\patient-management-system\Patients registration form\Patients registration form";


namespace homepage
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            object register = form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

