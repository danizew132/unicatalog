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
    public partial class discipline : Form
    {
        public discipline()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO [disciptab] ([id], [Nume], [acronim], [credite], [nrore]) " +
                                   "VALUES (@id, @nume, @acronim, @credite, @nrore)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", textBox1.Text);
                        cmd.Parameters.AddWithValue("@nume", textBox2.Text);
                        cmd.Parameters.AddWithValue("@acronim", textBox3.Text);
                        cmd.Parameters.AddWithValue("@credite", textBox4.Text);
                        cmd.Parameters.AddWithValue("@nrore", textBox5.Text);

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

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from disciptab", con);
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

                string query = "UPDATE disciptab " +
                               "SET nume=@nume, acronim=@acronim, credite=@credite, nrore=@nrore " +  // Am adăugat un spațiu înainte de WHERE
                               "WHERE id=@id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@nume", textBox2.Text);
                    cmd.Parameters.AddWithValue("@acronim", textBox3.Text);
                    cmd.Parameters.AddWithValue("@credite", textBox4.Text);
                    cmd.Parameters.AddWithValue("@nrore", textBox5.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Informații schimbate cu succes", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnde_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;

            if (string.IsNullOrEmpty(id))
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
                    string query = "DELETE FROM disciptab WHERE id= @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
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
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void btndisp_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from disciptab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
