using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Data;



namespace unicatalog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void loginbuton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string username = textBox1.Text;
                string password = textBox2.Text;

                // Folosirea parametrilor pentru a preveni SQL Injection
                string query = "SELECT Id, Username, Password FROM logintab WHERE Username = @Username AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            // Obține ID-ul utilizatorului
                            int userId = Convert.ToInt32(dt.Rows[0]["Id"]);
                            if (userId != 1)
                            {
                                MessageBox.Show("nu aveti permisiunea");
                            }
                            else
                            {
                                { }

                                // Deschide fereastra principală
                                Main mn = new Main();
                                mn.Show();


                            }
                        }
                        else
                        {
                            MessageBox.Show("Parola sau Username gresit");
                        }
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
