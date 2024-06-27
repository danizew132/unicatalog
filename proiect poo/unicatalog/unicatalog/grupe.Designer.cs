namespace unicatalog
{
    partial class grupe
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
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 137);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 53;
            label3.Text = "Nume";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 100);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 52;
            label2.Text = "Grupa";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 51;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 50;
            // 
            // button3
            // 
            button3.Location = new Point(59, 277);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 49;
            button3.Text = "Arata";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(179, 230);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 48;
            button2.Text = "Sterge";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(59, 230);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 47;
            button1.Text = "Adauga";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(0, 338);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 112);
            dataGridView1.TabIndex = 46;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 56);
            panel1.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(334, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 29);
            label1.TabIndex = 0;
            label1.Text = "Grupe";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 180);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 54;
            label4.Text = "Semigrupa";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 55;
            // 
            // button4
            // 
            button4.Location = new Point(179, 277);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 56;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // grupe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "grupe";
            Text = "grupe";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Label label4;
        private TextBox textBox3;
        private Button button4;
    }
}