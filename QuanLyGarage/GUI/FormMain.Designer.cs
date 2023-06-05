using System.Windows.Forms;

namespace GUI
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            TreeNode treeNode1 = new TreeNode("Tiếp nhận xe");
            TreeNode treeNode2 = new TreeNode("Tra cứu xe");
            TreeNode treeNode3 = new TreeNode("Xem danh sách xe", 5, 5);
            TreeNode treeNode4 = new TreeNode("Quản lý xe", 0, 0, new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("Lập phiếu sửa chữa");
            TreeNode treeNode6 = new TreeNode("Lập phiếu thu tiền");
            TreeNode treeNode7 = new TreeNode("Quản lý dịch vụ", 1, 1, new TreeNode[] { treeNode5, treeNode6 });
            TreeNode treeNode8 = new TreeNode("Nhập vật tư phụ tùng");
            TreeNode treeNode9 = new TreeNode("Quản lý kho", 2, 2, new TreeNode[] { treeNode8 });
            TreeNode treeNode10 = new TreeNode("Thay đổi quy định");
            TreeNode treeNode11 = new TreeNode("Quản lý quy định", 3, 3, new TreeNode[] { treeNode10 });
            TreeNode treeNode12 = new TreeNode("Doanh thu");
            TreeNode treeNode13 = new TreeNode("Tồn kho");
            TreeNode treeNode14 = new TreeNode("Báo cáo thống kê", 4, 4, new TreeNode[] { treeNode12, treeNode13 });
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            treeView1 = new TreeView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            tabPage3 = new TabPage();
            button2 = new Button();
            label10 = new Label();
            label9 = new Label();
            textBox5 = new TextBox();
            comboBox2 = new ComboBox();
            label8 = new Label();
            tabPage4 = new TabPage();
            dataGridView1 = new DataGridView();
            label11 = new Label();
            tabPage5 = new TabPage();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewComboBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewComboBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            button5 = new Button();
            button4 = new Button();
            label14 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label13 = new Label();
            textBox6 = new TextBox();
            label12 = new Label();
            tabPage6 = new TabPage();
            button6 = new Button();
            textBox11 = new TextBox();
            dateTimePicker4 = new DateTimePicker();
            button3 = new Button();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            label15 = new Label();
            tabPage7 = new TabPage();
            button8 = new Button();
            comboBox4 = new ComboBox();
            button7 = new Button();
            label22 = new Label();
            label23 = new Label();
            textBox12 = new TextBox();
            label24 = new Label();
            tabPage8 = new TabPage();
            button9 = new Button();
            dataGridView3 = new DataGridView();
            label25 = new Label();
            tabPage9 = new TabPage();
            comboBox5 = new ComboBox();
            button10 = new Button();
            comboBox3 = new ComboBox();
            button11 = new Button();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            tabPage10 = new TabPage();
            comboBox6 = new ComboBox();
            button12 = new Button();
            comboBox7 = new ComboBox();
            button13 = new Button();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            tabPage11 = new TabPage();
            textBox25 = new TextBox();
            textBox24 = new TextBox();
            textBox23 = new TextBox();
            textBox22 = new TextBox();
            textBox21 = new TextBox();
            textBox20 = new TextBox();
            textBox19 = new TextBox();
            textBox18 = new TextBox();
            label42 = new Label();
            label41 = new Label();
            label40 = new Label();
            label39 = new Label();
            label38 = new Label();
            label37 = new Label();
            label36 = new Label();
            label35 = new Label();
            label34 = new Label();
            label33 = new Label();
            label32 = new Label();
            tabPage12 = new TabPage();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            button15 = new Button();
            label44 = new Label();
            label45 = new Label();
            label43 = new Label();
            tabPage13 = new TabPage();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            label48 = new Label();
            label49 = new Label();
            comboBox10 = new ComboBox();
            comboBox11 = new ComboBox();
            button14 = new Button();
            label50 = new Label();
            label51 = new Label();
            label52 = new Label();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage9.SuspendLayout();
            tabPage10.SuspendLayout();
            tabPage11.SuspendLayout();
            tabPage12.SuspendLayout();
            tabPage13.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(34, 34, 34);
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(923, 43);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.AutoSize = false;
            toolStripMenuItem1.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripMenuItem1.ForeColor = SystemColors.Control;
            toolStripMenuItem1.Image = Properties.Resources.image3;
            toolStripMenuItem1.ImageAlign = ContentAlignment.MiddleLeft;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(215, 46);
            toolStripMenuItem1.Text = "Trang chủ";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.AutoSize = false;
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6 });
            toolStripMenuItem2.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripMenuItem2.ForeColor = SystemColors.Control;
            toolStripMenuItem2.Image = Properties.Resources.image2;
            toolStripMenuItem2.ImageAlign = ContentAlignment.MiddleRight;
            toolStripMenuItem2.Margin = new Padding(850, 0, 0, 0);
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(212, 46);
            toolStripMenuItem2.Text = "username";
            toolStripMenuItem2.TextImageRelation = TextImageRelation.TextBeforeImage;
            toolStripMenuItem2.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.BackColor = SystemColors.ActiveCaptionText;
            toolStripMenuItem3.ForeColor = SystemColors.ButtonFace;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(236, 28);
            toolStripMenuItem3.Text = "Thông tin cá nhân";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click_1;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.BackColor = Color.Black;
            toolStripMenuItem4.ForeColor = SystemColors.ButtonFace;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(236, 28);
            toolStripMenuItem4.Text = "Thay đổi mật khẩu";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.BackColor = SystemColors.ActiveCaptionText;
            toolStripMenuItem5.ForeColor = SystemColors.ButtonFace;
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(236, 28);
            toolStripMenuItem5.Text = "Thêm tài khoản";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.BackColor = SystemColors.ActiveCaptionText;
            toolStripMenuItem6.ForeColor = SystemColors.ButtonFace;
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(236, 28);
            toolStripMenuItem6.Text = "Đăng xuất";
            toolStripMenuItem6.Click += toolStripMenuItem6_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Black;
            imageList1.Images.SetKeyName(0, "image5.png");
            imageList1.Images.SetKeyName(1, "image6.png");
            imageList1.Images.SetKeyName(2, "image7.png");
            imageList1.Images.SetKeyName(3, "image8.png");
            imageList1.Images.SetKeyName(4, "image9.png");
            imageList1.Images.SetKeyName(5, "image10.png");
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.FromArgb(34, 34, 34);
            treeView1.Font = new Font("Segoe UI", 8.142858F, FontStyle.Regular, GraphicsUnit.Point);
            treeView1.ImageIndex = 5;
            treeView1.ImageList = imageList1;
            treeView1.ItemHeight = 90;
            treeView1.LineColor = Color.FromArgb(34, 34, 34);
            treeView1.Location = new Point(11, 45);
            treeView1.Margin = new Padding(2, 2, 2, 2);
            treeView1.Name = "treeView1";
            treeNode1.BackColor = Color.FromArgb(34, 34, 34);
            treeNode1.ForeColor = Color.White;
            treeNode1.ImageKey = "image10.png";
            treeNode1.Name = "Node5";
            treeNode1.SelectedImageIndex = 5;
            treeNode1.Text = "Tiếp nhận xe";
            treeNode2.BackColor = Color.FromArgb(34, 34, 34);
            treeNode2.ForeColor = Color.White;
            treeNode2.ImageKey = "image10.png";
            treeNode2.Name = "Node6";
            treeNode2.SelectedImageIndex = 5;
            treeNode2.Text = "Tra cứu xe";
            treeNode3.BackColor = Color.FromArgb(34, 34, 34);
            treeNode3.ForeColor = Color.White;
            treeNode3.ImageIndex = 5;
            treeNode3.Name = "Node7";
            treeNode3.SelectedImageIndex = 5;
            treeNode3.Text = "Xem danh sách xe";
            treeNode4.BackColor = Color.FromArgb(34, 34, 34);
            treeNode4.ForeColor = Color.White;
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "Node0";
            treeNode4.SelectedImageIndex = 0;
            treeNode4.Text = "Quản lý xe";
            treeNode5.BackColor = Color.FromArgb(34, 34, 34);
            treeNode5.ForeColor = Color.White;
            treeNode5.Name = "Node12";
            treeNode5.Text = "Lập phiếu sửa chữa";
            treeNode6.BackColor = Color.FromArgb(34, 34, 34);
            treeNode6.ForeColor = Color.White;
            treeNode6.Name = "Node13";
            treeNode6.Text = "Lập phiếu thu tiền";
            treeNode7.BackColor = Color.FromArgb(34, 34, 34);
            treeNode7.ForeColor = Color.White;
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "Node1";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Text = "Quản lý dịch vụ";
            treeNode8.BackColor = Color.FromArgb(34, 34, 34);
            treeNode8.ForeColor = Color.White;
            treeNode8.Name = "Node11";
            treeNode8.Text = "Nhập vật tư phụ tùng";
            treeNode9.BackColor = Color.FromArgb(34, 34, 34);
            treeNode9.ForeColor = Color.White;
            treeNode9.ImageIndex = 2;
            treeNode9.Name = "Node2";
            treeNode9.SelectedImageIndex = 2;
            treeNode9.Text = "Quản lý kho";
            treeNode10.BackColor = Color.FromArgb(34, 34, 34);
            treeNode10.ForeColor = Color.White;
            treeNode10.Name = "Node10";
            treeNode10.Text = "Thay đổi quy định";
            treeNode11.BackColor = Color.FromArgb(34, 34, 34);
            treeNode11.ForeColor = Color.White;
            treeNode11.ImageIndex = 3;
            treeNode11.Name = "Node3";
            treeNode11.SelectedImageIndex = 3;
            treeNode11.Text = "Quản lý quy định";
            treeNode12.BackColor = Color.FromArgb(34, 34, 34);
            treeNode12.ForeColor = Color.White;
            treeNode12.Name = "Node8";
            treeNode12.Text = "Doanh thu";
            treeNode13.BackColor = Color.FromArgb(34, 34, 34);
            treeNode13.ForeColor = Color.White;
            treeNode13.Name = "Node9";
            treeNode13.Text = "Tồn kho";
            treeNode14.BackColor = Color.FromArgb(34, 34, 34);
            treeNode14.ForeColor = Color.White;
            treeNode14.ImageIndex = 4;
            treeNode14.Name = "Node4";
            treeNode14.SelectedImageIndex = 4;
            treeNode14.Text = "Báo cáo thống kê";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode4, treeNode7, treeNode9, treeNode11, treeNode14 });
            treeView1.SelectedImageIndex = 5;
            treeView1.ShowLines = false;
            treeView1.ShowPlusMinus = false;
            treeView1.ShowRootLines = false;
            treeView1.Size = new Size(192, 514);
            treeView1.TabIndex = 1;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Controls.Add(tabPage9);
            tabControl1.Controls.Add(tabPage10);
            tabControl1.Controls.Add(tabPage11);
            tabControl1.Controls.Add(tabPage12);
            tabControl1.Controls.Add(tabPage13);
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.Location = new Point(186, 45);
            tabControl1.Margin = new Padding(2, 2, 2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(736, 513);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 5);
            tabPage1.Margin = new Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 2, 2, 2);
            tabPage1.Size = new Size(728, 504);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image11;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(731, 509);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(34, 34, 34);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 5);
            tabPage2.Margin = new Padding(2, 2, 2, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 2, 2, 2);
            tabPage2.Size = new Size(728, 504);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(250, 136, 40);
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(52, 419);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(87, 27);
            button1.TabIndex = 13;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(403, 316);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(115, 20);
            label7.TabIndex = 12;
            label7.Text = "Ngày tiếp nhận";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(52, 316);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 11;
            label6.Text = "Số điện thoại";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(403, 95);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 10;
            label5.Text = "Biển số";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(403, 207);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 9;
            label4.Text = "Hiệu xe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(51, 209);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 8;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 95);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 7;
            label2.Text = "Họ tên chủ xe";
            label2.Click += label2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(403, 338);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(223, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(403, 229);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 28);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(403, 117);
            textBox4.Margin = new Padding(2, 2, 2, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 27);
            textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(51, 338);
            textBox3.Margin = new Padding(2, 2, 2, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 117);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 231);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 37);
            label1.TabIndex = 0;
            label1.Text = "Phiếu tiếp nhận xe ";
            label1.Click += label1_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(34, 34, 34);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(textBox5);
            tabPage3.Controls.Add(comboBox2);
            tabPage3.Controls.Add(label8);
            tabPage3.Location = new Point(4, 5);
            tabPage3.Margin = new Padding(2, 2, 2, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(728, 504);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(250, 136, 40);
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(50, 173);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(87, 27);
            button2.TabIndex = 14;
            button2.Text = "Xác nhận";
            button2.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(401, 95);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(61, 20);
            label10.TabIndex = 4;
            label10.Text = "Hiệu xe";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(50, 95);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 3;
            label9.Text = "Biển số";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(50, 117);
            textBox5.Margin = new Padding(2, 2, 2, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(180, 27);
            textBox5.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(401, 115);
            comboBox2.Margin = new Padding(2, 2, 2, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(180, 28);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(50, 29);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(230, 37);
            label8.TabIndex = 0;
            label8.Text = "Tra cứu xe";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(34, 34, 34);
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Controls.Add(label11);
            tabPage4.Location = new Point(4, 5);
            tabPage4.Margin = new Padding(2, 2, 2, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(728, 504);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 94);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(648, 335);
            dataGridView1.TabIndex = 2;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(50, 29);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(317, 37);
            label11.TabIndex = 1;
            label11.Text = "Danh sách xe đã tiếp nhận";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.FromArgb(34, 34, 34);
            tabPage5.Controls.Add(dataGridView2);
            tabPage5.Controls.Add(button5);
            tabPage5.Controls.Add(button4);
            tabPage5.Controls.Add(label14);
            tabPage5.Controls.Add(dateTimePicker2);
            tabPage5.Controls.Add(label13);
            tabPage5.Controls.Add(textBox6);
            tabPage5.Controls.Add(label12);
            tabPage5.ForeColor = SystemColors.ControlText;
            tabPage5.Location = new Point(4, 5);
            tabPage5.Margin = new Padding(2, 2, 2, 2);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(728, 504);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.Click += tabPage5_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowDrop = true;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.FromArgb(34, 34, 34);
            dataGridView2.ColumnHeadersHeight = 40;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView2.Location = new Point(50, 178);
            dataGridView2.Margin = new Padding(2, 2, 2, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 72;
            dataGridView2.RowTemplate.Height = 37;
            dataGridView2.Size = new Size(630, 140);
            dataGridView2.TabIndex = 20;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "STT";
            Column1.MinimumWidth = 9;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nội dung";
            Column2.MinimumWidth = 9;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Vật tư";
            Column3.MinimumWidth = 9;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Số lượng";
            Column4.MinimumWidth = 9;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Đơn giá";
            Column5.MinimumWidth = 9;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Tiền công";
            Column6.MinimumWidth = 9;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Thành tiền";
            Column7.MinimumWidth = 9;
            Column7.Name = "Column7";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(250, 136, 40);
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(228, 393);
            button5.Margin = new Padding(2, 2, 2, 2);
            button5.Name = "button5";
            button5.Size = new Size(90, 27);
            button5.TabIndex = 18;
            button5.Text = "Phiếu mới";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(250, 136, 40);
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(50, 393);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(87, 27);
            button4.TabIndex = 17;
            button4.Text = "Xác nhận";
            button4.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(401, 94);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(115, 20);
            label14.TabIndex = 14;
            label14.Text = "Ngày tiếp nhận";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(401, 115);
            dateTimePicker2.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker2.MinDate = new DateTime(2003, 12, 3, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(223, 27);
            dateTimePicker2.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(50, 94);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(58, 20);
            label13.TabIndex = 5;
            label13.Text = "Biển số";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(50, 116);
            textBox6.Margin = new Padding(2, 2, 2, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(180, 27);
            textBox6.TabIndex = 4;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(50, 28);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(317, 37);
            label12.TabIndex = 2;
            label12.Text = "Phiếu sửa chữa";
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.FromArgb(34, 34, 34);
            tabPage6.Controls.Add(button6);
            tabPage6.Controls.Add(textBox11);
            tabPage6.Controls.Add(dateTimePicker4);
            tabPage6.Controls.Add(button3);
            tabPage6.Controls.Add(label16);
            tabPage6.Controls.Add(label17);
            tabPage6.Controls.Add(label18);
            tabPage6.Controls.Add(label19);
            tabPage6.Controls.Add(label20);
            tabPage6.Controls.Add(label21);
            tabPage6.Controls.Add(textBox7);
            tabPage6.Controls.Add(textBox8);
            tabPage6.Controls.Add(textBox9);
            tabPage6.Controls.Add(textBox10);
            tabPage6.Controls.Add(label15);
            tabPage6.Location = new Point(4, 5);
            tabPage6.Margin = new Padding(2, 2, 2, 2);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(728, 504);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            tabPage6.Click += tabPage6_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(250, 136, 40);
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(256, 415);
            button6.Margin = new Padding(2, 2, 2, 2);
            button6.Name = "button6";
            button6.Size = new Size(87, 27);
            button6.TabIndex = 29;
            button6.Text = "Phiếu mới";
            button6.UseVisualStyleBackColor = false;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(405, 335);
            textBox11.Margin = new Padding(2, 2, 2, 2);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(179, 27);
            textBox11.TabIndex = 28;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(404, 227);
            dateTimePicker4.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(223, 27);
            dateTimePicker4.TabIndex = 27;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(250, 136, 40);
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(52, 415);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(87, 27);
            button3.TabIndex = 26;
            button3.Text = "Xác nhận";
            button3.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(404, 313);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(83, 20);
            label16.TabIndex = 25;
            label16.Text = "Số tiền thu";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(52, 313);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(46, 20);
            label17.TabIndex = 24;
            label17.Text = "Email";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(404, 95);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(58, 20);
            label18.TabIndex = 23;
            label18.Text = "Biển số";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(404, 206);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(103, 20);
            label19.TabIndex = 22;
            label19.Text = "Ngày thu tiền";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(52, 206);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(99, 20);
            label20.TabIndex = 21;
            label20.Text = "Số điện thoại";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.White;
            label21.Location = new Point(50, 95);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(104, 20);
            label21.TabIndex = 20;
            label21.Text = "Họ tên chủ xe";
            label21.Click += label21_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(404, 117);
            textBox7.Margin = new Padding(2, 2, 2, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(180, 27);
            textBox7.TabIndex = 17;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(52, 335);
            textBox8.Margin = new Padding(2, 2, 2, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(179, 27);
            textBox8.TabIndex = 16;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(50, 117);
            textBox9.Margin = new Padding(2, 2, 2, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(180, 27);
            textBox9.TabIndex = 15;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(52, 228);
            textBox10.Margin = new Padding(2, 2, 2, 2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(180, 27);
            textBox10.TabIndex = 14;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(50, 31);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(177, 37);
            label15.TabIndex = 3;
            label15.Text = "Phiếu thu tiền";
            // 
            // tabPage7
            // 
            tabPage7.BackColor = Color.FromArgb(34, 34, 34);
            tabPage7.Controls.Add(button8);
            tabPage7.Controls.Add(comboBox4);
            tabPage7.Controls.Add(button7);
            tabPage7.Controls.Add(label22);
            tabPage7.Controls.Add(label23);
            tabPage7.Controls.Add(textBox12);
            tabPage7.Controls.Add(label24);
            tabPage7.Location = new Point(4, 5);
            tabPage7.Margin = new Padding(2, 2, 2, 2);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(728, 504);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "tabPage7";
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(250, 136, 40);
            button8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(193, 173);
            button8.Margin = new Padding(2, 2, 2, 2);
            button8.Name = "button8";
            button8.Size = new Size(87, 27);
            button8.TabIndex = 22;
            button8.Text = "Phiếu mới";
            button8.UseVisualStyleBackColor = false;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(51, 115);
            comboBox4.Margin = new Padding(2, 2, 2, 2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(180, 28);
            comboBox4.TabIndex = 21;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(250, 136, 40);
            button7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(51, 173);
            button7.Margin = new Padding(2, 2, 2, 2);
            button7.Name = "button7";
            button7.Size = new Size(87, 27);
            button7.TabIndex = 20;
            button7.Text = "Xác nhận";
            button7.UseVisualStyleBackColor = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.White;
            label22.Location = new Point(403, 95);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(70, 20);
            label22.TabIndex = 19;
            label22.Text = "Số lượng";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.White;
            label23.Location = new Point(51, 95);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(117, 20);
            label23.TabIndex = 18;
            label23.Text = "Vật tư phụ tùng";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(403, 117);
            textBox12.Margin = new Padding(2, 2, 2, 2);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(180, 27);
            textBox12.TabIndex = 17;
            // 
            // label24
            // 
            label24.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.White;
            label24.Location = new Point(51, 29);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(327, 37);
            label24.TabIndex = 15;
            label24.Text = "Phiếu nhập vật tư phụ tùng";
            // 
            // tabPage8
            // 
            tabPage8.BackColor = Color.FromArgb(34, 34, 34);
            tabPage8.Controls.Add(button9);
            tabPage8.Controls.Add(dataGridView3);
            tabPage8.Controls.Add(label25);
            tabPage8.Location = new Point(4, 5);
            tabPage8.Margin = new Padding(2, 2, 2, 2);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(728, 504);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "tabPage8";
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(250, 136, 40);
            button9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(49, 280);
            button9.Margin = new Padding(2, 2, 2, 2);
            button9.Name = "button9";
            button9.Size = new Size(87, 27);
            button9.TabIndex = 21;
            button9.Text = "Thay đổi";
            button9.UseVisualStyleBackColor = false;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(49, 92);
            dataGridView3.Margin = new Padding(2, 2, 2, 2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 72;
            dataGridView3.RowTemplate.Height = 37;
            dataGridView3.Size = new Size(327, 141);
            dataGridView3.TabIndex = 17;
            // 
            // label25
            // 
            label25.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.White;
            label25.Location = new Point(49, 29);
            label25.Margin = new Padding(2, 0, 2, 0);
            label25.Name = "label25";
            label25.Size = new Size(327, 37);
            label25.TabIndex = 16;
            label25.Text = "Quy định hiện hành";
            // 
            // tabPage9
            // 
            tabPage9.BackColor = Color.FromArgb(34, 34, 34);
            tabPage9.Controls.Add(comboBox5);
            tabPage9.Controls.Add(button10);
            tabPage9.Controls.Add(comboBox3);
            tabPage9.Controls.Add(button11);
            tabPage9.Controls.Add(label26);
            tabPage9.Controls.Add(label27);
            tabPage9.Controls.Add(label28);
            tabPage9.Location = new Point(4, 5);
            tabPage9.Margin = new Padding(2, 2, 2, 2);
            tabPage9.Name = "tabPage9";
            tabPage9.Size = new Size(728, 504);
            tabPage9.TabIndex = 8;
            tabPage9.Text = "tabPage9";
            tabPage9.Click += tabPage9_Click;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(402, 120);
            comboBox5.Margin = new Padding(2, 2, 2, 2);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(180, 28);
            comboBox5.TabIndex = 30;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(250, 136, 40);
            button10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.White;
            button10.Location = new Point(193, 176);
            button10.Margin = new Padding(2, 2, 2, 2);
            button10.Name = "button10";
            button10.Size = new Size(87, 27);
            button10.TabIndex = 29;
            button10.Text = "Phiếu mới";
            button10.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(51, 118);
            comboBox3.Margin = new Padding(2, 2, 2, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(180, 28);
            comboBox3.TabIndex = 28;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(250, 136, 40);
            button11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = Color.White;
            button11.Location = new Point(51, 176);
            button11.Margin = new Padding(2, 2, 2, 2);
            button11.Name = "button11";
            button11.Size = new Size(87, 27);
            button11.TabIndex = 27;
            button11.Text = "Xác nhận";
            button11.UseVisualStyleBackColor = false;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label26.ForeColor = Color.White;
            label26.Location = new Point(402, 98);
            label26.Margin = new Padding(2, 0, 2, 0);
            label26.Name = "label26";
            label26.Size = new Size(42, 20);
            label26.TabIndex = 26;
            label26.Text = "Năm";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label27.ForeColor = Color.White;
            label27.Location = new Point(51, 96);
            label27.Margin = new Padding(2, 0, 2, 0);
            label27.Name = "label27";
            label27.Size = new Size(56, 20);
            label27.TabIndex = 25;
            label27.Text = "Tháng ";
            label27.Click += label27_Click;
            // 
            // label28
            // 
            label28.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label28.ForeColor = Color.White;
            label28.Location = new Point(51, 32);
            label28.Margin = new Padding(2, 0, 2, 0);
            label28.Name = "label28";
            label28.Size = new Size(327, 37);
            label28.TabIndex = 23;
            label28.Text = "Báo cáo doanh thu";
            // 
            // tabPage10
            // 
            tabPage10.BackColor = Color.FromArgb(34, 34, 34);
            tabPage10.Controls.Add(comboBox6);
            tabPage10.Controls.Add(button12);
            tabPage10.Controls.Add(comboBox7);
            tabPage10.Controls.Add(button13);
            tabPage10.Controls.Add(label29);
            tabPage10.Controls.Add(label30);
            tabPage10.Controls.Add(label31);
            tabPage10.Location = new Point(4, 5);
            tabPage10.Margin = new Padding(2, 2, 2, 2);
            tabPage10.Name = "tabPage10";
            tabPage10.Size = new Size(728, 504);
            tabPage10.TabIndex = 9;
            tabPage10.Text = "tabPage10";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(400, 119);
            comboBox6.Margin = new Padding(2, 2, 2, 2);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(180, 28);
            comboBox6.TabIndex = 37;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(250, 136, 40);
            button12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button12.ForeColor = Color.White;
            button12.Location = new Point(191, 175);
            button12.Margin = new Padding(2, 2, 2, 2);
            button12.Name = "button12";
            button12.Size = new Size(87, 27);
            button12.TabIndex = 36;
            button12.Text = "Phiếu mới";
            button12.UseVisualStyleBackColor = false;
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(49, 117);
            comboBox7.Margin = new Padding(2, 2, 2, 2);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(180, 28);
            comboBox7.TabIndex = 35;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(250, 136, 40);
            button13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button13.ForeColor = Color.White;
            button13.Location = new Point(49, 175);
            button13.Margin = new Padding(2, 2, 2, 2);
            button13.Name = "button13";
            button13.Size = new Size(87, 27);
            button13.TabIndex = 34;
            button13.Text = "Xác nhận";
            button13.UseVisualStyleBackColor = false;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label29.ForeColor = Color.White;
            label29.Location = new Point(400, 97);
            label29.Margin = new Padding(2, 0, 2, 0);
            label29.Name = "label29";
            label29.Size = new Size(42, 20);
            label29.TabIndex = 33;
            label29.Text = "Năm";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label30.ForeColor = Color.White;
            label30.Location = new Point(49, 95);
            label30.Margin = new Padding(2, 0, 2, 0);
            label30.Name = "label30";
            label30.Size = new Size(56, 20);
            label30.TabIndex = 32;
            label30.Text = "Tháng ";
            // 
            // label31
            // 
            label31.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label31.ForeColor = Color.White;
            label31.Location = new Point(49, 31);
            label31.Margin = new Padding(2, 0, 2, 0);
            label31.Name = "label31";
            label31.Size = new Size(205, 37);
            label31.TabIndex = 31;
            label31.Text = "Báo cáo tồn kho";
            // 
            // tabPage11
            // 
            tabPage11.BackColor = Color.FromArgb(34, 34, 34);
            tabPage11.Controls.Add(textBox25);
            tabPage11.Controls.Add(textBox24);
            tabPage11.Controls.Add(textBox23);
            tabPage11.Controls.Add(textBox22);
            tabPage11.Controls.Add(textBox21);
            tabPage11.Controls.Add(textBox20);
            tabPage11.Controls.Add(textBox19);
            tabPage11.Controls.Add(textBox18);
            tabPage11.Controls.Add(label42);
            tabPage11.Controls.Add(label41);
            tabPage11.Controls.Add(label40);
            tabPage11.Controls.Add(label39);
            tabPage11.Controls.Add(label38);
            tabPage11.Controls.Add(label37);
            tabPage11.Controls.Add(label36);
            tabPage11.Controls.Add(label35);
            tabPage11.Controls.Add(label34);
            tabPage11.Controls.Add(label33);
            tabPage11.Controls.Add(label32);
            tabPage11.Location = new Point(4, 5);
            tabPage11.Margin = new Padding(2, 2, 2, 2);
            tabPage11.Name = "tabPage11";
            tabPage11.Size = new Size(728, 504);
            tabPage11.TabIndex = 10;
            tabPage11.Text = "tabPage11";
            // 
            // textBox25
            // 
            textBox25.Location = new Point(133, 149);
            textBox25.Margin = new Padding(2, 2, 2, 2);
            textBox25.Name = "textBox25";
            textBox25.Size = new Size(180, 27);
            textBox25.TabIndex = 51;
            // 
            // textBox24
            // 
            textBox24.Location = new Point(157, 410);
            textBox24.Margin = new Padding(2, 2, 2, 2);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(180, 27);
            textBox24.TabIndex = 50;
            // 
            // textBox23
            // 
            textBox23.Location = new Point(455, 345);
            textBox23.Margin = new Padding(2, 2, 2, 2);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(180, 27);
            textBox23.TabIndex = 49;
            // 
            // textBox22
            // 
            textBox22.Location = new Point(133, 199);
            textBox22.Margin = new Padding(2, 2, 2, 2);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(180, 27);
            textBox22.TabIndex = 48;
            // 
            // textBox21
            // 
            textBox21.Location = new Point(455, 149);
            textBox21.Margin = new Padding(2, 2, 2, 2);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(180, 27);
            textBox21.TabIndex = 47;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(133, 252);
            textBox20.Margin = new Padding(2, 2, 2, 2);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(180, 27);
            textBox20.TabIndex = 46;
            // 
            // textBox19
            // 
            textBox19.Location = new Point(455, 201);
            textBox19.Margin = new Padding(2, 2, 2, 2);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(180, 27);
            textBox19.TabIndex = 45;
            // 
            // textBox18
            // 
            textBox18.Location = new Point(157, 345);
            textBox18.Margin = new Padding(2, 2, 2, 2);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(180, 27);
            textBox18.TabIndex = 44;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label42.ForeColor = Color.White;
            label42.Location = new Point(49, 349);
            label42.Margin = new Padding(2, 0, 2, 0);
            label42.Name = "label42";
            label42.Size = new Size(111, 20);
            label42.TabIndex = 42;
            label42.Text = "Tên đăng nhập ";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label41.ForeColor = Color.White;
            label41.Location = new Point(49, 413);
            label41.Margin = new Padding(2, 0, 2, 0);
            label41.Name = "label41";
            label41.Size = new Size(79, 20);
            label41.TabIndex = 41;
            label41.Text = "Quyền hạn";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label40.ForeColor = Color.White;
            label40.Location = new Point(361, 349);
            label40.Margin = new Padding(2, 0, 2, 0);
            label40.Name = "label40";
            label40.Size = new Size(74, 20);
            label40.TabIndex = 40;
            label40.Text = "Mật khẩu ";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label39.ForeColor = Color.White;
            label39.Location = new Point(49, 298);
            label39.Margin = new Padding(2, 0, 2, 0);
            label39.Name = "label39";
            label39.Size = new Size(179, 23);
            label39.TabIndex = 39;
            label39.Text = "2. Thông tin tài khoản";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label38.ForeColor = Color.White;
            label38.Location = new Point(49, 255);
            label38.Margin = new Padding(2, 0, 2, 0);
            label38.Name = "label38";
            label38.Size = new Size(55, 20);
            label38.TabIndex = 38;
            label38.Text = "Địa chỉ";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label37.ForeColor = Color.White;
            label37.Location = new Point(361, 201);
            label37.Margin = new Padding(2, 0, 2, 0);
            label37.Name = "label37";
            label37.Size = new Size(97, 20);
            label37.TabIndex = 37;
            label37.Text = "Số điện thoại";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label36.ForeColor = Color.White;
            label36.Location = new Point(49, 95);
            label36.Margin = new Padding(2, 0, 2, 0);
            label36.Name = "label36";
            label36.Size = new Size(195, 23);
            label36.TabIndex = 36;
            label36.Text = "1. Thông tin người dùng";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label35.ForeColor = Color.White;
            label35.Location = new Point(361, 149);
            label35.Margin = new Padding(2, 0, 2, 0);
            label35.Name = "label35";
            label35.Size = new Size(74, 20);
            label35.TabIndex = 35;
            label35.Text = "Ngày sinh";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label34.ForeColor = Color.White;
            label34.Location = new Point(49, 149);
            label34.Margin = new Padding(2, 0, 2, 0);
            label34.Name = "label34";
            label34.Size = new Size(73, 20);
            label34.TabIndex = 34;
            label34.Text = "Họ và tên";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label33.ForeColor = Color.White;
            label33.Location = new Point(49, 201);
            label33.Margin = new Padding(2, 0, 2, 0);
            label33.Name = "label33";
            label33.Size = new Size(65, 20);
            label33.TabIndex = 33;
            label33.Text = "Giới tính";
            // 
            // label32
            // 
            label32.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label32.ForeColor = Color.White;
            label32.Location = new Point(49, 31);
            label32.Margin = new Padding(2, 0, 2, 0);
            label32.Name = "label32";
            label32.Size = new Size(230, 37);
            label32.TabIndex = 32;
            label32.Text = "Thông tin cá nhân";
            // 
            // tabPage12
            // 
            tabPage12.BackColor = Color.FromArgb(34, 34, 34);
            tabPage12.Controls.Add(textBox13);
            tabPage12.Controls.Add(textBox14);
            tabPage12.Controls.Add(button15);
            tabPage12.Controls.Add(label44);
            tabPage12.Controls.Add(label45);
            tabPage12.Controls.Add(label43);
            tabPage12.Location = new Point(4, 5);
            tabPage12.Margin = new Padding(2, 2, 2, 2);
            tabPage12.Name = "tabPage12";
            tabPage12.Size = new Size(728, 504);
            tabPage12.TabIndex = 11;
            tabPage12.Text = "tabPage12";
            tabPage12.Click += tabPage12_Click;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(403, 119);
            textBox13.Margin = new Padding(2, 2, 2, 2);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(180, 27);
            textBox13.TabIndex = 43;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(49, 119);
            textBox14.Margin = new Padding(2, 2, 2, 2);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(180, 27);
            textBox14.TabIndex = 42;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(250, 136, 40);
            button15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button15.ForeColor = Color.White;
            button15.Location = new Point(49, 195);
            button15.Margin = new Padding(2, 2, 2, 2);
            button15.Name = "button15";
            button15.Size = new Size(87, 27);
            button15.TabIndex = 36;
            button15.Text = "Xác nhận";
            button15.UseVisualStyleBackColor = false;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label44.ForeColor = Color.White;
            label44.Location = new Point(403, 99);
            label44.Margin = new Padding(2, 0, 2, 0);
            label44.Name = "label44";
            label44.Size = new Size(104, 20);
            label44.TabIndex = 35;
            label44.Text = "Mật khẩu mới";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label45.ForeColor = Color.White;
            label45.Location = new Point(49, 99);
            label45.Margin = new Padding(2, 0, 2, 0);
            label45.Name = "label45";
            label45.Size = new Size(129, 20);
            label45.TabIndex = 34;
            label45.Text = "Mật khẩu hiện tại";
            // 
            // label43
            // 
            label43.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label43.ForeColor = Color.White;
            label43.Location = new Point(49, 31);
            label43.Margin = new Padding(2, 0, 2, 0);
            label43.Name = "label43";
            label43.Size = new Size(247, 37);
            label43.TabIndex = 33;
            label43.Text = "Thay đổi mật khẩu";
            // 
            // tabPage13
            // 
            tabPage13.BackColor = Color.FromArgb(34, 34, 34);
            tabPage13.Controls.Add(textBox15);
            tabPage13.Controls.Add(textBox16);
            tabPage13.Controls.Add(label48);
            tabPage13.Controls.Add(label49);
            tabPage13.Controls.Add(comboBox10);
            tabPage13.Controls.Add(comboBox11);
            tabPage13.Controls.Add(button14);
            tabPage13.Controls.Add(label50);
            tabPage13.Controls.Add(label51);
            tabPage13.Controls.Add(label52);
            tabPage13.Location = new Point(4, 5);
            tabPage13.Margin = new Padding(2, 2, 2, 2);
            tabPage13.Name = "tabPage13";
            tabPage13.Size = new Size(728, 504);
            tabPage13.TabIndex = 12;
            tabPage13.Text = "tabPage13";
            tabPage13.Click += tabPage13_Click;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(399, 120);
            textBox15.Margin = new Padding(2, 2, 2, 2);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(180, 27);
            textBox15.TabIndex = 53;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(49, 120);
            textBox16.Margin = new Padding(2, 2, 2, 2);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(180, 27);
            textBox16.TabIndex = 52;
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label48.ForeColor = Color.White;
            label48.Location = new Point(399, 187);
            label48.Margin = new Padding(2, 0, 2, 0);
            label48.Name = "label48";
            label48.Size = new Size(92, 20);
            label48.TabIndex = 51;
            label48.Text = "Người dùng";
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label49.ForeColor = Color.White;
            label49.Location = new Point(49, 187);
            label49.Margin = new Padding(2, 0, 2, 0);
            label49.Name = "label49";
            label49.Size = new Size(84, 20);
            label49.TabIndex = 50;
            label49.Text = "Quyền hạn";
            // 
            // comboBox10
            // 
            comboBox10.FormattingEnabled = true;
            comboBox10.Location = new Point(399, 209);
            comboBox10.Margin = new Padding(2, 2, 2, 2);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(180, 28);
            comboBox10.TabIndex = 49;
            // 
            // comboBox11
            // 
            comboBox11.FormattingEnabled = true;
            comboBox11.Location = new Point(49, 209);
            comboBox11.Margin = new Padding(2, 2, 2, 2);
            comboBox11.Name = "comboBox11";
            comboBox11.Size = new Size(180, 28);
            comboBox11.TabIndex = 48;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(250, 136, 40);
            button14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button14.ForeColor = Color.White;
            button14.Location = new Point(49, 288);
            button14.Margin = new Padding(2, 2, 2, 2);
            button14.Name = "button14";
            button14.Size = new Size(87, 27);
            button14.TabIndex = 47;
            button14.Text = "Xác nhận";
            button14.UseVisualStyleBackColor = false;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label50.ForeColor = Color.White;
            label50.Location = new Point(399, 98);
            label50.Margin = new Padding(2, 0, 2, 0);
            label50.Name = "label50";
            label50.Size = new Size(74, 20);
            label50.TabIndex = 46;
            label50.Text = "Mật khẩu";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label51.ForeColor = Color.White;
            label51.Location = new Point(49, 100);
            label51.Margin = new Padding(2, 0, 2, 0);
            label51.Name = "label51";
            label51.Size = new Size(111, 20);
            label51.TabIndex = 45;
            label51.Text = "Tên đăng nhập";
            // 
            // label52
            // 
            label52.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label52.ForeColor = Color.White;
            label52.Location = new Point(49, 31);
            label52.Margin = new Padding(2, 0, 2, 0);
            label52.Name = "label52";
            label52.Size = new Size(247, 37);
            label52.TabIndex = 44;
            label52.Text = "Thêm tài khoản mới";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(923, 559);
            Controls.Add(tabControl1);
            Controls.Add(treeView1);
            Controls.Add(menuStrip1);
            Icon = Properties.Resources.icon1;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage9.ResumeLayout(false);
            tabPage9.PerformLayout();
            tabPage10.ResumeLayout(false);
            tabPage10.PerformLayout();
            tabPage11.ResumeLayout(false);
            tabPage11.PerformLayout();
            tabPage12.ResumeLayout(false);
            tabPage12.PerformLayout();
            tabPage13.ResumeLayout(false);
            tabPage13.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ImageList imageList1;
        private TreeView treeView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private PictureBox pictureBox1;
        private Label label1;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private TabPage tabPage11;
        private TabPage tabPage12;
        private TabPage tabPage13;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private TextBox textBox5;
        private ComboBox comboBox2;
        private Label label8;
        private Label label10;
        private Label label9;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label11;
        private Label label12;
        private Label label14;
        private DateTimePicker dateTimePicker2;
        private Label label13;
        private TextBox textBox6;
        private Button button5;
        private Button button4;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewComboBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewComboBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button button3;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label15;
        private DateTimePicker dateTimePicker4;
        private TextBox textBox11;
        private Button button6;
        private Button button8;
        private ComboBox comboBox4;
        private Button button7;
        private Label label22;
        private Label label23;
        private TextBox textBox12;
        private Label label24;
        private Button button9;
        private DataGridView dataGridView3;
        private Label label25;
        private Button button10;
        private ComboBox comboBox3;
        private Button button11;
        private Label label26;
        private Label label27;
        private Label label28;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private Button button12;
        private ComboBox comboBox7;
        private Button button13;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label42;
        private Label label41;
        private Label label40;
        private Label label39;
        private Label label38;
        private Label label37;
        private TextBox textBox13;
        private TextBox textBox14;
        private Button button15;
        private Label label44;
        private Label label45;
        private Label label43;
        private TextBox textBox15;
        private TextBox textBox16;
        private Label label48;
        private Label label49;
        private ComboBox comboBox10;
        private ComboBox comboBox11;
        private Button button14;
        private Label label50;
        private Label label51;
        private Label label52;
        private TextBox textBox24;
        private TextBox textBox23;
        private TextBox textBox22;
        private TextBox textBox21;
        private TextBox textBox20;
        private TextBox textBox19;
        private TextBox textBox18;
        private TextBox textBox25;
    }
}