using System.Windows.Forms;

namespace GUI
{
    partial class FormDangNhap
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image1;
            pictureBox1.Location = new Point(-1, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1385, 844);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(861, 312);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 44);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(861, 436);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(293, 44);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Location = new Point(931, 529);
            button1.Name = "button1";
            button1.Size = new Size(154, 50);
            button1.TabIndex = 3;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 838);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = Properties.Resources.icon1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDangNhap";
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}