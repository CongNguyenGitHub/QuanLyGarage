namespace GUI
{
    partial class FromDiaglog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromDiaglog));
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(250, 136, 40);
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(77, 188);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 15;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(250, 136, 40);
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(259, 188);
            button2.Name = "button2";
            button2.Size = new Size(131, 40);
            button2.TabIndex = 16;
            button2.Text = "Bỏ qua";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 35);
            textBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(77, 31);
            label1.Name = "label1";
            label1.Size = new Size(299, 66);
            label1.TabIndex = 18;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // FromDiaglog
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = button2;
            ClientSize = new Size(476, 286);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(500, 350);
            MinimizeBox = false;
            MinimumSize = new Size(500, 350);
            Name = "FromDiaglog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quy định";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        public TextBox TextBox1
        {
            get { return textBox1; }
            set { textBox1 = value; }
        }
        private Label label1;
        public Label Label1
        {
            get { return label1; }
            set { label1 = value; }
        }

    }
}