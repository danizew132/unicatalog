using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unicatalog
{
    public partial class cic : Form
    {
        public cic()
        {
            InitializeComponent();
        }

        private void cic_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S8P7H6K\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from cic", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
    
}
