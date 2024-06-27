using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace unicatalog
{
    public partial class grupe : Form
    {
        public grupe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO [grupa] ([idgrupa], [Nume], [grupa]) " +
                               "VALUES (@idgrupa, @Nume, @grupa)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idgrupa", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Nume", textBox2.Text);
                    cmd.Parameters.AddWithValue("@grupa", textBox3.Text);


                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Informații salvate cu succces", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from studenttab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM [grupa] WHERE [idgrupa] = @idgrupa";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idgrupa", int.Parse(textBox1.Text));

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Informații șterse cu succes", "Ștergere", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE [grupa] SET [Nume] = @Nume, [grupa] = @grupa WHERE [idgrupa] = @idgrupa";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idgrupa", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Nume", textBox2.Text);
                    cmd.Parameters.AddWithValue("@grupa", textBox3.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Informații actualizate cu succes", "Actualizare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
