
using Microsoft.Data.SqlClient;
namespace HMSLogin

{
    public partial class Form1 : Form
    {
       SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ogutu\OneDrive\Documents\newHMSdb.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "INSERT INTO doctable values('" + PatName.Text + "','" + Patpass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);

                int rowsAffected = cmd.ExecuteNonQuery(); 

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Login successful");
                    MessageBox.Show("Rows affected: " + rowsAffected); 
                }
                else
                {
                    MessageBox.Show("Login failed. No rows updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
    }
}
