using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace unicatalog
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = "";
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO [studenttab] ([Nrmat], [Nume], [Prenume], [IT], [CNP], [DI], [CI], [MA]) " +
                               "VALUES (@Nrmat, @Nume, @Prenume, @IT, @CNP, @DI, @CI, @MA)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nrmat", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Nume", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Prenume", textBox3.Text);
                    cmd.Parameters.AddWithValue("@IT", textBox4.Text);
                    cmd.Parameters.AddWithValue("@CNP", textBox5.Text);
                    cmd.Parameters.AddWithValue("@DI", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@CI", textBox7.Text);
                    cmd.Parameters.AddWithValue("@MA", textBox8.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Informații salvate cu succces", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from studenttab", con);
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

                string query = "UPDATE studenttab " +
                               "SET Nume=@nume, Prenume=@prenume, IT=@initialaTatalui, CNP=@cnp, DI=@dataInscrierii, CI=@cicluInvatamant, MA=@mediaAdmitere " +
                               "WHERE Nrmat=@numarMatricol";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@numarMatricol", textBox1.Text);
                    cmd.Parameters.AddWithValue("@nume", textBox2.Text);
                    cmd.Parameters.AddWithValue("@prenume", textBox3.Text);
                    cmd.Parameters.AddWithValue("@initialaTatalui", textBox4.Text);
                    cmd.Parameters.AddWithValue("@cnp", textBox5.Text);
                    cmd.Parameters.AddWithValue("@dataInscrierii", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@cicluInvatamant", textBox7.Text);
                    cmd.Parameters.AddWithValue("@mediaAdmitere", textBox8.Text);

                    cmd.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Informații schimbate cu succes", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnde_Click(object sender, EventArgs e)
        {
            string nrMatricol = textBox1.Text;

            if (string.IsNullOrEmpty(nrMatricol))
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
                    string query = "DELETE FROM studenttab WHERE Nrmat = @Nrmat";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nrmat", nrMatricol);
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
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void btndisp_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from studenttab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void Student_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from studenttab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
