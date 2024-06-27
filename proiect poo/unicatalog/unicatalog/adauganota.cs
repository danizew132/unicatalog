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

namespace unicatalog
{
    public partial class adauganota : Form
    {
        public adauganota()
        {
            InitializeComponent();
        }

        private void adauganota_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string connectionString = @"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                // Informațiile studentului
                string studentNume = "";
                string studentPrenume = "";
                int studentId = 0;

                // Extrage informațiile studentului după Nrmat
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string selectQuery = "SELECT  nume, prenume FROM student WHERE Nrmat = @Nrmat";
                    using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Nrmat", textBox1.Text);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                studentNume = reader.GetString(1);
                                studentPrenume = reader.GetString(2);
                            }
                            else
                            {
                                MessageBox.Show("Studentul nu a fost găsit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
            }
        }
    }

}