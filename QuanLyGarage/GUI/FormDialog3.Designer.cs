namespace GUI
{
    partial class FormDialog3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDialog3));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(250, 136, 40);
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(64, 195);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 17;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(250, 136, 40);
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(262, 195);
            button2.Name = "button2";
            button2.Size = new Size(131, 40);
            button2.TabIndex = 18;
            button2.Text = "Bỏ qua";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 95);
            label1.Name = "label1";
            label1.Size = new Size(363, 32);
            label1.TabIndex = 19;
            label1.Text = "Bạn có chắc muốn đăng xuất ?";
            // 
            // FormDialog3
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button2;
            ClientSize = new Size(476, 286);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(500, 350);
            MinimizeBox = false;
            MinimumSize = new Size(500, 350);
            Name = "FormDialog3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đăng xuất";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
    }
}