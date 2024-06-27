namespace unicatalog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            user = new Label();
            parola = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            loginbuton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 66);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(156, 9);
            label2.Name = "label2";
            label2.Size = new Size(64, 30);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 98);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // user
            // 
            user.AutoSize = true;
            user.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user.Location = new Point(156, 83);
            user.Name = "user";
            user.Size = new Size(67, 17);
            user.TabIndex = 2;
            user.Text = "Username";
            user.Click += label1_Click;
            // 
            // parola
            // 
            parola.AutoSize = true;
            parola.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parola.Location = new Point(175, 118);
            parola.Name = "parola";
            parola.Size = new Size(45, 17);
            parola.TabIndex = 3;
            parola.Text = "Parola";
            parola.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(229, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(229, 112);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // loginbuton
            // 
            loginbuton.Location = new Point(314, 147);
            loginbuton.Name = "loginbuton";
            loginbuton.Size = new Size(75, 23);
            loginbuton.TabIndex = 6;
            loginbuton.Text = "Login";
            loginbuton.UseVisualStyleBackColor = true;
            loginbuton.Click += loginbuton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 182);
            Controls.Add(loginbuton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(parola);
            Controls.Add(user);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label user;
        private Label parola;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button loginbuton;
    }
}
