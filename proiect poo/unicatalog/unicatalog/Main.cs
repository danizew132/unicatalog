using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unicatalog
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cic cic = new cic();
            cic.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prog prog = new prog();
            prog.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            discipline discipline = new discipline();
            discipline.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            prof prof = new prof();
            prof.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            note note = new note();
            note.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            grupe grupe = new grupe();
            grupe.Show();
        }
    }
}
