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
    public partial class prog : Form
    {
        public prog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO [prog] ([cod], [Nume]) " +
                                   "VALUES (@cod, @nume)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@cod", textBox1.Text);
                        cmd.Parameters.AddWithValue("@nume", textBox2.Text);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Informații salvate cu succes", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvarea datelor: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from prog", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cod = textBox1.Text;

            if (string.IsNullOrEmpty(cod))
            {
                MessageBox.Show("Introduceți un cod valid", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM prog WHERE cod= @cod";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@cod",cod);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Informații șterse cu succes", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Număr matricol inexistent", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
