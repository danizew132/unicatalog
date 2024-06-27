namespace unicatalog
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btndisp = new Button();
            btnnew = new Button();
            btnup = new Button();
            btnde = new Button();
            btnadd = new Button();
            btnsave = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(823, 54);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(358, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 30);
            label1.TabIndex = 0;
            label1.Text = "Student";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btndisp);
            groupBox1.Controls.Add(btnnew);
            groupBox1.Controls.Add(btnup);
            groupBox1.Controls.Add(btnde);
            groupBox1.Controls.Add(btnadd);
            groupBox1.Controls.Add(btnsave);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(0, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 378);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informatii Student";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = null;
            pictureBox1.Location = new Point(450, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // btndisp
            // 
            btndisp.Location = new Point(666, 323);
            btndisp.Name = "btndisp";
            btndisp.Size = new Size(100, 49);
            btndisp.TabIndex = 23;
            btndisp.Text = "Arata";
            btndisp.UseVisualStyleBackColor = true;
            btndisp.Click += btndisp_Click;
            // 
            // btnnew
            // 
            btnnew.Location = new Point(546, 323);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(100, 49);
            btnnew.TabIndex = 22;
            btnnew.Text = "Nou";
            btnnew.UseVisualStyleBackColor = true;
            btnnew.Click += btnnew_Click;
            // 
            // btnup
            // 
            btnup.Location = new Point(281, 323);
            btnup.Name = "btnup";
            btnup.Size = new Size(100, 49);
            btnup.TabIndex = 21;
            btnup.Text = "Update";
            btnup.UseVisualStyleBackColor = true;
            btnup.Click += btnup_Click;
            // 
            // btnde
            // 
            btnde.Location = new Point(413, 323);
            btnde.Name = "btnde";
            btnde.Size = new Size(100, 49);
            btnde.TabIndex = 20;
            btnde.Text = "Sterge";
            btnde.UseVisualStyleBackColor = true;
            btnde.Click += btnde_Click;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(149, 323);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(100, 49);
            btnadd.TabIndex = 19;
            btnadd.Text = "Adauga";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(33, 323);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(100, 49);
            btnsave.TabIndex = 18;
            btnsave.Text = "Salveaza";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(244, 220);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 17;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(244, 294);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(244, 260);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(244, 184);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(244, 143);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(244, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(244, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(244, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(66, 293);
            label9.Name = "label9";
            label9.Size = new Size(131, 20);
            label9.TabIndex = 8;
            label9.Text = "Media de inscriere";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(66, 259);
            label8.Name = "label8";
            label8.Size = new Size(144, 20);
            label8.TabIndex = 7;
            label8.Text = "Ciclul de învățământ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(66, 222);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 6;
            label7.Text = "Data inscrierii";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(66, 187);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 5;
            label6.Text = "CNP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(66, 146);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 3;
            label5.Text = "Initiala tatalui";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 104);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 2;
            label4.Text = "Prenume";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 70);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 1;
            label3.Text = "Nume";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 33);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 0;
            label2.Text = "Numar matricol";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 438);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(767, 150);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 593);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnup;
        private Button btnde;
        private Button btnadd;
        private Button btnsave;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox5;
        private Button btndisp;
        private Button btnnew;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
    }
}