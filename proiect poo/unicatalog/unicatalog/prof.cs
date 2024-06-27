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
    public partial class prof : Form
    {
        public prof()
        {
            InitializeComponent();

            // Adăugarea opțiunilor în ComboBox în constructorul formularului
            comboBox1.Items.AddRange(new string[] {
                "Asistent universitar",
                "Șef lucrări/Lector",
                "Conferențiar universitar",
                "Profesor universitar",
                "CDA"
            });

            // Setarea primului element ca selecție implicită
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO [proftab] ([marca], [Nume], [Prenume], [titlu], [post]) " +
                               "VALUES (@marca, @Nume, @Prenume, @titlu, @post)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@marca", textBox1.Text);
                    cmd.Parameters.AddWithValue("@nume", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Prenume", textBox3.Text);
                    cmd.Parameters.AddWithValue("@titlu", textBox4.Text);
                    cmd.Parameters.AddWithValue("@post", comboBox1.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Informații salvate cu succces", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from proftab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

            private void btnup_Click(object sender, EventArgs e)
            {
            string connectionString = @"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "UPDATE proftab " +
                               "SET nume=@nume, prenume=@prenume, titlu=@titlu, post=@post " +
                               "WHERE marca=@marca";  // Actualizare în funcție de coloana 'marca'

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nume", textBox2.Text);
                    cmd.Parameters.AddWithValue("@prenume", textBox3.Text);
                    cmd.Parameters.AddWithValue("@titlu", textBox4.Text);
                    cmd.Parameters.AddWithValue("@post", comboBox1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@marca", textBox1.Text); // Parametrul pentru 'marca'

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Informații schimbate cu succes", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnde_Click(object sender, EventArgs e)
        {
            string marca = textBox1.Text;

            if (string.IsNullOrEmpty(marca))
            {
                MessageBox.Show("Introduceți un număr matricol valid", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM proftab WHERE marca= @marca";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@marca", marca);
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

        private void btnnew_Click(object sender, EventArgs e)
        {

        }

        private void btndisp_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from proftab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}

