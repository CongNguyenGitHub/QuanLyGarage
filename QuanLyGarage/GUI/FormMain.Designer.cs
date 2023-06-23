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
            TreeNode treeNode1 = new TreeNode("Trang chủ", 6, 6);
            TreeNode treeNode2 = new TreeNode("Tiếp nhận xe");
            TreeNode treeNode3 = new TreeNode("Tra cứu xe");
            TreeNode treeNode4 = new TreeNode("Xem danh sách xe");
            TreeNode treeNode5 = new TreeNode("Quản lý xe", 0, 0, new TreeNode[] { treeNode2, treeNode3, treeNode4 });
            TreeNode treeNode6 = new TreeNode("Lập phiếu sửa chữa");
            TreeNode treeNode7 = new TreeNode("Lập phiếu thu tiền");
            TreeNode treeNode8 = new TreeNode("Quản lý dịch vụ", 1, 1, new TreeNode[] { treeNode6, treeNode7 });
            TreeNode treeNode9 = new TreeNode("Nhập vật tư phụ tùng");
            TreeNode treeNode10 = new TreeNode("Xem danh sách vật tư");
            TreeNode treeNode11 = new TreeNode("Quản lý kho", 2, 2, new TreeNode[] { treeNode9, treeNode10 });
            TreeNode treeNode12 = new TreeNode("Thay đổi quy định");
            TreeNode treeNode13 = new TreeNode("Quản lý quy định", 3, 3, new TreeNode[] { treeNode12 });
            TreeNode treeNode14 = new TreeNode("Doanh thu");
            TreeNode treeNode15 = new TreeNode("Tồn kho");
            TreeNode treeNode16 = new TreeNode("Báo cáo thống kê", 4, 4, new TreeNode[] { treeNode14, treeNode15 });
            TreeNode treeNode17 = new TreeNode("Thông tin cá nhân");
            TreeNode treeNode18 = new TreeNode("Thay đổi mật khẩu");
            TreeNode treeNode19 = new TreeNode("Thêm tài khoản");
            TreeNode treeNode20 = new TreeNode("Đăng xuất");
            TreeNode treeNode21 = new TreeNode("Tài khoản", 7, 7, new TreeNode[] { treeNode17, treeNode18, treeNode19, treeNode20 });
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            imageList1 = new ImageList(components);
            treeView1 = new TreeView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            button16 = new Button();
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
            button17 = new Button();
            dataGridView4 = new DataGridView();
            button2 = new Button();
            label10 = new Label();
            label9 = new Label();
            textBox5 = new TextBox();
            comboBox2 = new ComboBox();
            label8 = new Label();
            tabPage4 = new TabPage();
            label11 = new Label();
            dataGridView1 = new DataGridView();
            tabPage5 = new TabPage();
            comboBox8 = new ComboBox();
            button20 = new Button();
            button19 = new Button();
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
            label12 = new Label();
            tabPage6 = new TabPage();
            comboBox9 = new ComboBox();
            label18 = new Label();
            label65 = new Label();
            button6 = new Button();
            textBox11 = new TextBox();
            dateTimePicker4 = new DateTimePicker();
            button3 = new Button();
            label16 = new Label();
            label17 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label15 = new Label();
            tabPage7 = new TabPage();
            label66 = new Label();
            dateTimePicker5 = new DateTimePicker();
            button8 = new Button();
            comboBox4 = new ComboBox();
            button7 = new Button();
            label22 = new Label();
            label23 = new Label();
            textBox12 = new TextBox();
            label24 = new Label();
            tabPage8 = new TabPage();
            dataGridView3 = new DataGridView();
            button9 = new Button();
            label25 = new Label();
            tabPage9 = new TabPage();
            label46 = new Label();
            dataGridView5 = new DataGridView();
            comboBox5 = new ComboBox();
            button10 = new Button();
            comboBox3 = new ComboBox();
            button11 = new Button();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            tabPage10 = new TabPage();
            dataGridView6 = new DataGridView();
            comboBox6 = new ComboBox();
            button12 = new Button();
            comboBox7 = new ComboBox();
            button13 = new Button();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            tabPage11 = new TabPage();
            label59 = new Label();
            label58 = new Label();
            label57 = new Label();
            label56 = new Label();
            label55 = new Label();
            label54 = new Label();
            label53 = new Label();
            label47 = new Label();
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
            button18 = new Button();
            dateTimePicker3 = new DateTimePicker();
            textBox20 = new TextBox();
            textBox19 = new TextBox();
            textBox17 = new TextBox();
            label64 = new Label();
            label63 = new Label();
            label62 = new Label();
            label61 = new Label();
            label60 = new Label();
            label48 = new Label();
            comboBox10 = new ComboBox();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            label49 = new Label();
            comboBox11 = new ComboBox();
            button14 = new Button();
            label50 = new Label();
            label51 = new Label();
            label52 = new Label();
            tabPage14 = new TabPage();
            label67 = new Label();
            dataGridView7 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            tabPage11.SuspendLayout();
            tabPage12.SuspendLayout();
            tabPage13.SuspendLayout();
            tabPage14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            SuspendLayout();
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
            imageList1.Images.SetKeyName(6, "image3.png");
            imageList1.Images.SetKeyName(7, "image2.png");
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.FromArgb(34, 34, 34);
            treeView1.Font = new Font("Segoe UI", 8.142858F, FontStyle.Regular, GraphicsUnit.Point);
            treeView1.ForeColor = Color.White;
            treeView1.ImageIndex = 5;
            treeView1.ImageList = imageList1;
            treeView1.ItemHeight = 90;
            treeView1.LineColor = Color.FromArgb(34, 34, 34);
            treeView1.Location = new Point(4, 2);
            treeView1.Margin = new Padding(0);
            treeView1.Name = "treeView1";
            treeNode1.BackColor = Color.FromArgb(34, 34, 34);
            treeNode1.ForeColor = Color.White;
            treeNode1.ImageIndex = 6;
            treeNode1.Name = "Node0";
            treeNode1.SelectedImageIndex = 6;
            treeNode1.Text = "Trang chủ";
            treeNode2.BackColor = Color.FromArgb(34, 34, 34);
            treeNode2.ForeColor = Color.White;
            treeNode2.Name = "Node2";
            treeNode2.Text = "Tiếp nhận xe";
            treeNode3.BackColor = Color.FromArgb(34, 34, 34);
            treeNode3.ForeColor = Color.White;
            treeNode3.Name = "Node3";
            treeNode3.Text = "Tra cứu xe";
            treeNode4.BackColor = Color.FromArgb(34, 34, 34);
            treeNode4.ForeColor = Color.White;
            treeNode4.Name = "Node4";
            treeNode4.Text = "Xem danh sách xe";
            treeNode5.BackColor = Color.FromArgb(34, 34, 34);
            treeNode5.ForeColor = Color.White;
            treeNode5.ImageIndex = 0;
            treeNode5.Name = "Node1";
            treeNode5.SelectedImageIndex = 0;
            treeNode5.Text = "Quản lý xe";
            treeNode6.BackColor = Color.FromArgb(34, 34, 34);
            treeNode6.ForeColor = Color.White;
            treeNode6.Name = "Node6";
            treeNode6.Text = "Lập phiếu sửa chữa";
            treeNode7.BackColor = Color.FromArgb(34, 34, 34);
            treeNode7.ForeColor = Color.White;
            treeNode7.Name = "Node7";
            treeNode7.Text = "Lập phiếu thu tiền";
            treeNode8.BackColor = Color.FromArgb(34, 34, 34);
            treeNode8.ForeColor = Color.White;
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "Node5";
            treeNode8.SelectedImageIndex = 1;
            treeNode8.Text = "Quản lý dịch vụ";
            treeNode9.BackColor = Color.FromArgb(34, 34, 34);
            treeNode9.ForeColor = Color.White;
            treeNode9.Name = "Node9";
            treeNode9.Text = "Nhập vật tư phụ tùng";
            treeNode10.BackColor = Color.FromArgb(34, 34, 34);
            treeNode10.ForeColor = Color.White;
            treeNode10.Name = "Node19";
            treeNode10.Text = "Xem danh sách vật tư";
            treeNode11.BackColor = Color.FromArgb(34, 34, 34);
            treeNode11.ForeColor = Color.White;
            treeNode11.ImageIndex = 2;
            treeNode11.Name = "Node8";
            treeNode11.SelectedImageIndex = 2;
            treeNode11.Text = "Quản lý kho";
            treeNode12.BackColor = Color.FromArgb(34, 34, 34);
            treeNode12.ForeColor = Color.White;
            treeNode12.Name = "Node11";
            treeNode12.Text = "Thay đổi quy định";
            treeNode13.BackColor = Color.FromArgb(34, 34, 34);
            treeNode13.ForeColor = Color.White;
            treeNode13.ImageIndex = 3;
            treeNode13.Name = "Node10";
            treeNode13.SelectedImageIndex = 3;
            treeNode13.Text = "Quản lý quy định";
            treeNode14.BackColor = Color.FromArgb(34, 34, 34);
            treeNode14.ForeColor = Color.White;
            treeNode14.Name = "Node13";
            treeNode14.Text = "Doanh thu";
            treeNode15.BackColor = Color.FromArgb(34, 34, 34);
            treeNode15.ForeColor = Color.White;
            treeNode15.Name = "Node14";
            treeNode15.Text = "Tồn kho";
            treeNode16.BackColor = Color.FromArgb(34, 34, 34);
            treeNode16.ForeColor = Color.White;
            treeNode16.ImageIndex = 4;
            treeNode16.Name = "Node12";
            treeNode16.SelectedImageIndex = 4;
            treeNode16.Text = "Báo cáo thống kê";
            treeNode17.BackColor = Color.FromArgb(34, 34, 34);
            treeNode17.ForeColor = Color.White;
            treeNode17.Name = "Node16";
            treeNode17.Text = "Thông tin cá nhân";
            treeNode18.BackColor = Color.FromArgb(34, 34, 34);
            treeNode18.ForeColor = Color.White;
            treeNode18.Name = "Node17";
            treeNode18.Text = "Thay đổi mật khẩu";
            treeNode19.BackColor = Color.FromArgb(34, 34, 34);
            treeNode19.ForeColor = Color.White;
            treeNode19.Name = "Node18";
            treeNode19.Text = "Thêm tài khoản";
            treeNode20.BackColor = Color.FromArgb(34, 34, 34);
            treeNode20.ForeColor = Color.White;
            treeNode20.Name = "Node20";
            treeNode20.Text = "Đăng xuất";
            treeNode21.BackColor = Color.FromArgb(34, 34, 34);
            treeNode21.ForeColor = Color.White;
            treeNode21.ImageIndex = 7;
            treeNode21.Name = "Node15";
            treeNode21.SelectedImageIndex = 7;
            treeNode21.Text = "Tài khoản";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode5, treeNode8, treeNode11, treeNode13, treeNode16, treeNode21 });
            treeView1.SelectedImageIndex = 5;
            treeView1.ShowLines = false;
            treeView1.ShowPlusMinus = false;
            treeView1.ShowRootLines = false;
            treeView1.Size = new Size(289, 841);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
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
            tabControl1.Controls.Add(tabPage14);
            tabControl1.Location = new Point(292, 0);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1095, 878);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1087, 835);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image11;
            pictureBox1.Location = new Point(-4, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1099, 836);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(34, 34, 34);
            tabPage2.Controls.Add(button16);
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
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1087, 835);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(250, 136, 40);
            button16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button16.ForeColor = Color.White;
            button16.Location = new Point(341, 629);
            button16.Name = "button16";
            button16.Size = new Size(131, 40);
            button16.TabIndex = 8;
            button16.Text = "Làm mới";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(250, 136, 40);
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(78, 629);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 7;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(605, 474);
            label7.Name = "label7";
            label7.Size = new Size(160, 30);
            label7.TabIndex = 12;
            label7.Text = "Ngày tiếp nhận";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(78, 474);
            label6.Name = "label6";
            label6.Size = new Size(139, 30);
            label6.TabIndex = 11;
            label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(605, 142);
            label5.Name = "label5";
            label5.Size = new Size(82, 30);
            label5.TabIndex = 10;
            label5.Text = "Biển số";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(605, 311);
            label4.Name = "label4";
            label4.Size = new Size(84, 30);
            label4.TabIndex = 9;
            label4.Text = "Hiệu xe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(77, 314);
            label3.Name = "label3";
            label3.Size = new Size(77, 30);
            label3.TabIndex = 8;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(78, 142);
            label2.Name = "label2";
            label2.Size = new Size(146, 30);
            label2.TabIndex = 7;
            label2.Text = "Họ tên chủ xe";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(605, 507);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(268, 35);
            dateTimePicker1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "HONDA", "TOYOTA", "LEXUS", "SUZUKI", "ASTON MARTIN", "BENTLEY", "RANDROVER", "ROLLS-ROYCE" });
            comboBox1.Location = new Point(605, 344);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 38);
            comboBox1.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(75, 507);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(268, 35);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(78, 347);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(266, 35);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(605, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 35);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 35);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(75, 43);
            label1.Name = "label1";
            label1.Size = new Size(348, 56);
            label1.TabIndex = 0;
            label1.Text = "Phiếu tiếp nhận xe ";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(34, 34, 34);
            tabPage3.Controls.Add(button17);
            tabPage3.Controls.Add(dataGridView4);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(textBox5);
            tabPage3.Controls.Add(comboBox2);
            tabPage3.Controls.Add(label8);
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1087, 835);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(250, 136, 40);
            button17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button17.ForeColor = Color.White;
            button17.Location = new Point(311, 259);
            button17.Name = "button17";
            button17.Size = new Size(131, 40);
            button17.TabIndex = 4;
            button17.Text = "Làm mới";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AllowUserToResizeColumns = false;
            dataGridView4.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView4.BackgroundColor = Color.FromArgb(34, 34, 34);
            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridView4.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridView4.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView4.ColumnHeadersHeight = 54;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView4.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView4.EnableHeadersVisualStyles = false;
            dataGridView4.GridColor = Color.White;
            dataGridView4.Location = new Point(0, 335);
            dataGridView4.Margin = new Padding(0);
            dataGridView4.MultiSelect = false;
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridView4.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.RowHeadersWidth = 50;
            dataGridView4.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView4.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
            dataGridView4.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridView4.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView4.RowTemplate.Height = 37;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.Size = new Size(1080, 455);
            dataGridView4.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(250, 136, 40);
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(75, 259);
            button2.Name = "button2";
            button2.Size = new Size(131, 40);
            button2.TabIndex = 3;
            button2.Text = "Xác nhận";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(602, 142);
            label10.Name = "label10";
            label10.Size = new Size(84, 30);
            label10.TabIndex = 4;
            label10.Text = "Hiệu xe";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(75, 142);
            label9.Name = "label9";
            label9.Size = new Size(82, 30);
            label9.TabIndex = 3;
            label9.Text = "Biển số";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(75, 175);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(268, 35);
            textBox5.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "HONDA", "TOYOTA", "LEXUS", "SUZUKI", "ASTON MARTIN", "BENTLEY", "RANDROVER", "ROLLS-ROYCE" });
            comboBox2.Location = new Point(602, 172);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(268, 38);
            comboBox2.TabIndex = 2;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(75, 43);
            label8.Name = "label8";
            label8.Size = new Size(345, 56);
            label8.TabIndex = 0;
            label8.Text = "Tra cứu xe";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(34, 34, 34);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Location = new Point(4, 39);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1087, 835);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(53, 33);
            label11.Name = "label11";
            label11.Size = new Size(345, 56);
            label11.TabIndex = 2;
            label11.Text = "Danh sách xe";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(34, 34, 34);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.ColumnHeadersHeight = 54;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(0, 112);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1087, 678);
            dataGridView1.TabIndex = 1;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.FromArgb(34, 34, 34);
            tabPage5.Controls.Add(comboBox8);
            tabPage5.Controls.Add(button20);
            tabPage5.Controls.Add(button19);
            tabPage5.Controls.Add(dataGridView2);
            tabPage5.Controls.Add(button5);
            tabPage5.Controls.Add(button4);
            tabPage5.Controls.Add(label14);
            tabPage5.Controls.Add(dateTimePicker2);
            tabPage5.Controls.Add(label13);
            tabPage5.Controls.Add(label12);
            tabPage5.ForeColor = SystemColors.ControlText;
            tabPage5.Location = new Point(4, 39);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1087, 835);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Items.AddRange(new object[] { "HONDA", "TOYOTA", "LEXUS", "SUZUKI", "ASTON MARTIN", "BENTLEY", "RANDROVER", "ROLLS-ROYCE" });
            comboBox8.Location = new Point(39, 175);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(268, 38);
            comboBox8.TabIndex = 1;
            // 
            // button20
            // 
            button20.BackColor = Color.FromArgb(250, 136, 40);
            button20.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button20.ForeColor = Color.White;
            button20.Image = Properties.Resources.image13;
            button20.Location = new Point(134, 604);
            button20.Name = "button20";
            button20.Size = new Size(35, 35);
            button20.TabIndex = 5;
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.White;
            button19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button19.ForeColor = Color.Transparent;
            button19.Image = Properties.Resources.image12;
            button19.Location = new Point(39, 604);
            button19.Name = "button19";
            button19.Size = new Size(35, 35);
            button19.TabIndex = 4;
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowDrop = true;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.FromArgb(34, 34, 34);
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView2.ColumnHeadersHeight = 40;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridView2.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView2.Location = new Point(39, 267);
            dataGridView2.Margin = new Padding(0);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 72;
            dataGridView2.RowTemplate.Height = 37;
            dataGridView2.Size = new Size(1007, 299);
            dataGridView2.TabIndex = 3;
            dataGridView2.CellEndEdit += dataGridView2_EndEdit;
            dataGridView2.RowsAdded += dataGridView2_RowsAdded;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.FillWeight = 50F;
            Column1.HeaderText = "STT";
            Column1.MinimumWidth = 50;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.FillWeight = 99.36082F;
            Column2.HeaderText = "Nội dung";
            Column2.MinimumWidth = 9;
            Column2.Name = "Column2";
            Column2.Width = 155;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column3.FillWeight = 150F;
            Column3.HeaderText = "Vật tư";
            Column3.Items.AddRange(new object[] { "Bánh xe", "Lọc dầu", "Lọc gió", "Ống xả", "Lọc nhiên liệu", "Bình dầu", "Giảm sóc", "Công tắc đèn", "Dây curoa", "Vành đúc", "Máy nổ", "Ly hợp", "Bộ phanh", "Đèn pha", "Cụm điều khiển", "Ốp lưng ghế", "Cảm biến áp suất lốp", "Dây điện", "Máy phát điện", "Ống nước", "Đèn hậu", "Gương chiếu hậu", "Cần gạt nước", "Đèn xi-nhan", "Đèn trần", "Vòi rửa xe", "Bơm xịt nước", "Phanh tay" });
            Column3.MinimumWidth = 150;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column4.FillWeight = 120F;
            Column4.HeaderText = "Số lượng";
            Column4.MinimumWidth = 120;
            Column4.Name = "Column4";
            Column4.Width = 120;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column5.HeaderText = "Đơn giá";
            Column5.MinimumWidth = 100;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 175;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column6.FillWeight = 200F;
            Column6.HeaderText = "Tiền công";
            Column6.Items.AddRange(new object[] { "Thay bánh xe", "Thay lọc dầu", "Thay lọc gió", "Thay ống xả", "Sửa động cơ", "Sửa hệ thống phanh", "Sửa hệ thống lái", "Sửa hệ thống điện", "Thay lọc nhiên liệu", "Sửa hệ thống làm mát", "Thay bình dầu", "Sửa hệ thống treo", "Thay giảm sóc", "Sửa hệ thống điều khiển", "Thay công tắc đèn", "Sửa hệ thống phun nhiên liệu", "Thay dây curoa", "Sửa hệ thống điện tử", "Sửa vết trầy trên vành đúc", "Kiểm tra lực căng của vành đúc", "Thay van ở vành đúc", "Thay vỏ xe", "Sửa hệ thống truyền động", "Thay máy nổ", "Thay ly hợp", "Thay bộ phanh", "Thay đèn pha", "Thay cụm điều khiển", "Thay ốp lưng ghế", "Thay cảm biến áp suất lốp", "Thay dây điện", "Thay máy phát điện", "Thay ống nước", "Sửa ống nước", "Thay đèn hậu", "Sửa đèn hậu", "Thay gương chiếu hậu", "Sửa gương chiếu hậu", "Thay cần gạt nước", "Sửa cần gạt nước", "Thay đèn xi-nhan", "Sửa đèn xi-nhan", "Thay đèn trần", "Sửa đèn trần", "Thay vòi rửa xe", "Sửa vòi rửa xe", "Thay bơm xịt nước", "Sửa bơm xịt nước", "Thay phanh tay", "Sửa phanh tay", "Rửa xe", "Vệ sinh nội thất", "Kiểm tra định kỳ", "Trợ giúp cứu hộ", "Điều chỉnh cân bằng", "Lắp đặt phụ kiện", "Kiểm tra hệ thống", "Chuẩn đoán lỗi", "Nạp ga điều hòa", "Phục hồi động cơ", "Kiểm tra động cơ", "Lắp đặt màn hình", "Thay pin", "Vệ sinh hệ thống làm mát", "Tháo lắp đèn chiếu hậu", "Lắp đặt camera hành trình", "Kiểm tra hệ thống phanh", "Điều chỉnh hệ thống lái", "Thay dầu hộp số", "Vệ sinh hệ thống điều hòa" });
            Column6.MinimumWidth = 200;
            Column6.Name = "Column6";
            Column6.Width = 200;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column7.FillWeight = 99.36082F;
            Column7.HeaderText = "Thành tiền";
            Column7.MinimumWidth = 9;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 154;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(250, 136, 40);
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(248, 681);
            button5.Name = "button5";
            button5.Size = new Size(135, 40);
            button5.TabIndex = 7;
            button5.Text = "Phiếu mới";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(250, 136, 40);
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(39, 681);
            button4.Name = "button4";
            button4.Size = new Size(130, 40);
            button4.TabIndex = 6;
            button4.Text = "Xác nhận";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(583, 142);
            label14.Name = "label14";
            label14.Size = new Size(158, 30);
            label14.TabIndex = 14;
            label14.Text = "Ngày lập phiếu";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(583, 174);
            dateTimePicker2.MinDate = new DateTime(2003, 12, 3, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(268, 35);
            dateTimePicker2.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(39, 142);
            label13.Name = "label13";
            label13.Size = new Size(82, 30);
            label13.TabIndex = 5;
            label13.Text = "Biển số";
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(39, 33);
            label12.Name = "label12";
            label12.Size = new Size(475, 56);
            label12.TabIndex = 2;
            label12.Text = "Phiếu sửa chữa";
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.FromArgb(34, 34, 34);
            tabPage6.Controls.Add(comboBox9);
            tabPage6.Controls.Add(label18);
            tabPage6.Controls.Add(label65);
            tabPage6.Controls.Add(button6);
            tabPage6.Controls.Add(textBox11);
            tabPage6.Controls.Add(dateTimePicker4);
            tabPage6.Controls.Add(button3);
            tabPage6.Controls.Add(label16);
            tabPage6.Controls.Add(label17);
            tabPage6.Controls.Add(label19);
            tabPage6.Controls.Add(label20);
            tabPage6.Controls.Add(label21);
            tabPage6.Controls.Add(label15);
            tabPage6.Location = new Point(4, 39);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1087, 835);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            // 
            // comboBox9
            // 
            comboBox9.FormattingEnabled = true;
            comboBox9.Items.AddRange(new object[] { "HONDA", "TOYOTA", "LEXUS", "SUZUKI", "ASTON MARTIN", "BENTLEY", "RANDROVER", "ROLLS-ROYCE" });
            comboBox9.Location = new Point(75, 169);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(268, 38);
            comboBox9.TabIndex = 1;
            // 
            // label18
            // 
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(606, 56);
            label18.Name = "label18";
            label18.Size = new Size(307, 56);
            label18.TabIndex = 34;
            label18.Text = "Thông tin khách hàng";
            // 
            // label65
            // 
            label65.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label65.ForeColor = Color.White;
            label65.Location = new Point(606, 172);
            label65.Name = "label65";
            label65.Size = new Size(462, 81);
            label65.TabIndex = 33;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(250, 136, 40);
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(315, 622);
            button6.Name = "button6";
            button6.Size = new Size(131, 40);
            button6.TabIndex = 5;
            button6.Text = "Phiếu mới";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(75, 463);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(266, 35);
            textBox11.TabIndex = 3;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Enabled = false;
            dateTimePicker4.Format = DateTimePickerFormat.Short;
            dateTimePicker4.Location = new Point(75, 307);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(268, 35);
            dateTimePicker4.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(250, 136, 40);
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(78, 622);
            button3.Name = "button3";
            button3.Size = new Size(131, 40);
            button3.TabIndex = 4;
            button3.Text = "Xác nhận";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(75, 430);
            label16.Name = "label16";
            label16.Size = new Size(117, 30);
            label16.TabIndex = 25;
            label16.Text = "Số tiền thu";
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(617, 466);
            label17.Name = "label17";
            label17.Size = new Size(451, 81);
            label17.TabIndex = 24;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(75, 274);
            label19.Name = "label19";
            label19.Size = new Size(144, 30);
            label19.TabIndex = 22;
            label19.Text = "Ngày thu tiền";
            // 
            // label20
            // 
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(606, 307);
            label20.Name = "label20";
            label20.Size = new Size(443, 77);
            label20.TabIndex = 21;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.White;
            label21.Location = new Point(78, 139);
            label21.Name = "label21";
            label21.Size = new Size(82, 30);
            label21.TabIndex = 20;
            label21.Text = "Biển số";
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(75, 47);
            label15.Name = "label15";
            label15.Size = new Size(265, 56);
            label15.TabIndex = 3;
            label15.Text = "Phiếu thu tiền";
            // 
            // tabPage7
            // 
            tabPage7.BackColor = Color.FromArgb(34, 34, 34);
            tabPage7.Controls.Add(label66);
            tabPage7.Controls.Add(dateTimePicker5);
            tabPage7.Controls.Add(button8);
            tabPage7.Controls.Add(comboBox4);
            tabPage7.Controls.Add(button7);
            tabPage7.Controls.Add(label22);
            tabPage7.Controls.Add(label23);
            tabPage7.Controls.Add(textBox12);
            tabPage7.Controls.Add(label24);
            tabPage7.Location = new Point(4, 39);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(1087, 835);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "tabPage7";
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label66.ForeColor = Color.White;
            label66.Location = new Point(77, 290);
            label66.Name = "label66";
            label66.Size = new Size(124, 30);
            label66.TabIndex = 29;
            label66.Text = "Ngày nhập ";
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Enabled = false;
            dateTimePicker5.Format = DateTimePickerFormat.Short;
            dateTimePicker5.Location = new Point(77, 323);
            dateTimePicker5.MaxDate = new DateTime(2040, 12, 31, 0, 0, 0, 0);
            dateTimePicker5.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(268, 35);
            dateTimePicker5.TabIndex = 2;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(250, 136, 40);
            button8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(292, 513);
            button8.Name = "button8";
            button8.Size = new Size(131, 40);
            button8.TabIndex = 5;
            button8.Text = "Phiếu mới";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Bánh xe", "Lọc dầu", "Lọc gió", "Ống xả", "Lọc nhiên liệu", "Bình dầu", "Giảm sóc", "Công tắc đèn", "Dây curoa", "Vành đúc", "Máy nổ", "Ly hợp", "Bộ phanh", "Đèn pha", "Cụm điều khiển", "Ốp lưng ghế", "Cảm biến áp suất lốp", "Dây điện", "Máy phát điện" });
            comboBox4.Location = new Point(77, 173);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(268, 38);
            comboBox4.TabIndex = 1;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(250, 136, 40);
            button7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(70, 513);
            button7.Name = "button7";
            button7.Size = new Size(131, 40);
            button7.TabIndex = 4;
            button7.Text = "Xác nhận";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.White;
            label22.Location = new Point(604, 143);
            label22.Name = "label22";
            label22.Size = new Size(99, 30);
            label22.TabIndex = 19;
            label22.Text = "Số lượng";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.White;
            label23.Location = new Point(77, 143);
            label23.Name = "label23";
            label23.Size = new Size(166, 30);
            label23.TabIndex = 18;
            label23.Text = "Vật tư phụ tùng";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(604, 176);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(268, 35);
            textBox12.TabIndex = 3;
            // 
            // label24
            // 
            label24.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.White;
            label24.Location = new Point(77, 44);
            label24.Name = "label24";
            label24.Size = new Size(490, 56);
            label24.TabIndex = 15;
            label24.Text = "Phiếu nhập vật tư phụ tùng";
            // 
            // tabPage8
            // 
            tabPage8.BackColor = Color.FromArgb(34, 34, 34);
            tabPage8.Controls.Add(dataGridView3);
            tabPage8.Controls.Add(button9);
            tabPage8.Controls.Add(label25);
            tabPage8.Location = new Point(4, 39);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(1087, 835);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "tabPage8";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToResizeColumns = false;
            dataGridView3.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView3.BackgroundColor = Color.FromArgb(34, 34, 34);
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView3.ColumnHeadersHeight = 54;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.GridColor = Color.White;
            dataGridView3.Location = new Point(43, 132);
            dataGridView3.Margin = new Padding(0);
            dataGridView3.MultiSelect = false;
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 50;
            dataGridView3.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView3.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
            dataGridView3.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridView3.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView3.RowTemplate.Height = 37;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(1006, 417);
            dataGridView3.TabIndex = 22;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(250, 136, 40);
            button9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(74, 580);
            button9.Name = "button9";
            button9.Size = new Size(131, 40);
            button9.TabIndex = 1;
            button9.Text = "Thay đổi";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // label25
            // 
            label25.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.White;
            label25.Location = new Point(74, 44);
            label25.Name = "label25";
            label25.Size = new Size(490, 56);
            label25.TabIndex = 16;
            label25.Text = "Quy định hiện hành";
            // 
            // tabPage9
            // 
            tabPage9.BackColor = Color.FromArgb(34, 34, 34);
            tabPage9.Controls.Add(label46);
            tabPage9.Controls.Add(dataGridView5);
            tabPage9.Controls.Add(comboBox5);
            tabPage9.Controls.Add(button10);
            tabPage9.Controls.Add(comboBox3);
            tabPage9.Controls.Add(button11);
            tabPage9.Controls.Add(label26);
            tabPage9.Controls.Add(label27);
            tabPage9.Controls.Add(label28);
            tabPage9.Location = new Point(4, 39);
            tabPage9.Name = "tabPage9";
            tabPage9.Size = new Size(1087, 835);
            tabPage9.TabIndex = 8;
            tabPage9.Text = "tabPage9";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            label46.ForeColor = Color.White;
            label46.Location = new Point(50, 338);
            label46.Name = "label46";
            label46.Size = new Size(0, 32);
            label46.TabIndex = 32;
            // 
            // dataGridView5
            // 
            dataGridView5.AllowUserToAddRows = false;
            dataGridView5.AllowUserToDeleteRows = false;
            dataGridView5.AllowUserToResizeColumns = false;
            dataGridView5.AllowUserToResizeRows = false;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridView5.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView5.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView5.BackgroundColor = Color.FromArgb(34, 34, 34);
            dataGridView5.BorderStyle = BorderStyle.None;
            dataGridView5.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridView5.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.White;
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle16.SelectionForeColor = Color.White;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dataGridView5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dataGridView5.ColumnHeadersHeight = 54;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = Color.White;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dataGridView5.DefaultCellStyle = dataGridViewCellStyle17;
            dataGridView5.EnableHeadersVisualStyles = false;
            dataGridView5.GridColor = Color.White;
            dataGridView5.Location = new Point(0, 407);
            dataGridView5.Margin = new Padding(0);
            dataGridView5.MultiSelect = false;
            dataGridView5.Name = "dataGridView5";
            dataGridView5.ReadOnly = true;
            dataGridView5.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = Color.White;
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle18.SelectionForeColor = Color.White;
            dataGridView5.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            dataGridView5.RowHeadersVisible = false;
            dataGridView5.RowHeadersWidth = 50;
            dataGridView5.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView5.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView5.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
            dataGridView5.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridView5.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView5.RowTemplate.Height = 37;
            dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView5.Size = new Size(1087, 381);
            dataGridView5.TabIndex = 31;
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023" });
            comboBox5.Location = new Point(603, 180);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(268, 38);
            comboBox5.TabIndex = 2;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(250, 136, 40);
            button10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.White;
            button10.Location = new Point(289, 264);
            button10.Name = "button10";
            button10.Size = new Size(131, 40);
            button10.TabIndex = 4;
            button10.Text = "Phiếu mới";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox3.Location = new Point(76, 177);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(268, 38);
            comboBox3.TabIndex = 1;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(250, 136, 40);
            button11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = Color.White;
            button11.Location = new Point(76, 264);
            button11.Name = "button11";
            button11.Size = new Size(131, 40);
            button11.TabIndex = 3;
            button11.Text = "Xác nhận";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label26.ForeColor = Color.White;
            label26.Location = new Point(603, 147);
            label26.Name = "label26";
            label26.Size = new Size(59, 30);
            label26.TabIndex = 26;
            label26.Text = "Năm";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label27.ForeColor = Color.White;
            label27.Location = new Point(76, 144);
            label27.Name = "label27";
            label27.Size = new Size(79, 30);
            label27.TabIndex = 25;
            label27.Text = "Tháng ";
            // 
            // label28
            // 
            label28.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label28.ForeColor = Color.White;
            label28.Location = new Point(76, 48);
            label28.Name = "label28";
            label28.Size = new Size(490, 56);
            label28.TabIndex = 23;
            label28.Text = "Báo cáo doanh thu";
            // 
            // tabPage10
            // 
            tabPage10.BackColor = Color.FromArgb(34, 34, 34);
            tabPage10.Controls.Add(dataGridView6);
            tabPage10.Controls.Add(comboBox6);
            tabPage10.Controls.Add(button12);
            tabPage10.Controls.Add(comboBox7);
            tabPage10.Controls.Add(button13);
            tabPage10.Controls.Add(label29);
            tabPage10.Controls.Add(label30);
            tabPage10.Controls.Add(label31);
            tabPage10.Location = new Point(4, 39);
            tabPage10.Name = "tabPage10";
            tabPage10.Size = new Size(1087, 835);
            tabPage10.TabIndex = 9;
            tabPage10.Text = "tabPage10";
            // 
            // dataGridView6
            // 
            dataGridView6.AllowUserToAddRows = false;
            dataGridView6.AllowUserToDeleteRows = false;
            dataGridView6.AllowUserToResizeColumns = false;
            dataGridView6.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle19.ForeColor = Color.White;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dataGridView6.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView6.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView6.BackgroundColor = Color.FromArgb(34, 34, 34);
            dataGridView6.BorderStyle = BorderStyle.None;
            dataGridView6.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridView6.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = Color.White;
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle20.SelectionForeColor = Color.White;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            dataGridView6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            dataGridView6.ColumnHeadersHeight = 54;
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle21.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle21.ForeColor = Color.White;
            dataGridViewCellStyle21.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            dataGridView6.DefaultCellStyle = dataGridViewCellStyle21;
            dataGridView6.EnableHeadersVisualStyles = false;
            dataGridView6.GridColor = Color.White;
            dataGridView6.Location = new Point(-4, 340);
            dataGridView6.Margin = new Padding(0);
            dataGridView6.MultiSelect = false;
            dataGridView6.Name = "dataGridView6";
            dataGridView6.ReadOnly = true;
            dataGridView6.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = Color.White;
            dataGridViewCellStyle22.SelectionBackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle22.SelectionForeColor = Color.White;
            dataGridView6.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            dataGridView6.RowHeadersVisible = false;
            dataGridView6.RowHeadersWidth = 50;
            dataGridView6.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView6.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView6.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
            dataGridView6.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridView6.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView6.RowTemplate.Height = 37;
            dataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView6.Size = new Size(1087, 464);
            dataGridView6.TabIndex = 38;
            // 
            // comboBox6
            // 
            comboBox6.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023" });
            comboBox6.Location = new Point(600, 179);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(268, 38);
            comboBox6.TabIndex = 2;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(250, 136, 40);
            button12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button12.ForeColor = Color.White;
            button12.Location = new Point(286, 263);
            button12.Name = "button12";
            button12.Size = new Size(131, 40);
            button12.TabIndex = 4;
            button12.Text = "Phiếu mới";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // comboBox7
            // 
            comboBox7.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "9", "10", "11", "12" });
            comboBox7.Location = new Point(73, 176);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(268, 38);
            comboBox7.TabIndex = 1;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(250, 136, 40);
            button13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button13.ForeColor = Color.White;
            button13.Location = new Point(73, 263);
            button13.Name = "button13";
            button13.Size = new Size(131, 40);
            button13.TabIndex = 3;
            button13.Text = "Xác nhận";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label29.ForeColor = Color.White;
            label29.Location = new Point(600, 146);
            label29.Name = "label29";
            label29.Size = new Size(59, 30);
            label29.TabIndex = 33;
            label29.Text = "Năm";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label30.ForeColor = Color.White;
            label30.Location = new Point(73, 143);
            label30.Name = "label30";
            label30.Size = new Size(79, 30);
            label30.TabIndex = 32;
            label30.Text = "Tháng ";
            // 
            // label31
            // 
            label31.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label31.ForeColor = Color.White;
            label31.Location = new Point(73, 47);
            label31.Name = "label31";
            label31.Size = new Size(307, 56);
            label31.TabIndex = 31;
            label31.Text = "Báo cáo tồn kho";
            // 
            // tabPage11
            // 
            tabPage11.BackColor = Color.FromArgb(34, 34, 34);
            tabPage11.Controls.Add(label59);
            tabPage11.Controls.Add(label58);
            tabPage11.Controls.Add(label57);
            tabPage11.Controls.Add(label56);
            tabPage11.Controls.Add(label55);
            tabPage11.Controls.Add(label54);
            tabPage11.Controls.Add(label53);
            tabPage11.Controls.Add(label47);
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
            tabPage11.Location = new Point(4, 39);
            tabPage11.Name = "tabPage11";
            tabPage11.Size = new Size(1087, 835);
            tabPage11.TabIndex = 10;
            tabPage11.Text = "tabPage11";
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label59.ForeColor = Color.White;
            label59.Location = new Point(683, 521);
            label59.Name = "label59";
            label59.Size = new Size(0, 30);
            label59.TabIndex = 58;
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label58.ForeColor = Color.White;
            label58.Location = new Point(236, 620);
            label58.Name = "label58";
            label58.Size = new Size(0, 30);
            label58.TabIndex = 57;
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label57.ForeColor = Color.White;
            label57.Location = new Point(236, 521);
            label57.Name = "label57";
            label57.Size = new Size(0, 30);
            label57.TabIndex = 56;
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label56.ForeColor = Color.White;
            label56.Location = new Point(683, 302);
            label56.Name = "label56";
            label56.Size = new Size(0, 30);
            label56.TabIndex = 55;
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label55.ForeColor = Color.White;
            label55.Location = new Point(683, 223);
            label55.Name = "label55";
            label55.Size = new Size(0, 30);
            label55.TabIndex = 54;
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label54.ForeColor = Color.White;
            label54.Location = new Point(182, 383);
            label54.Name = "label54";
            label54.Size = new Size(0, 30);
            label54.TabIndex = 53;
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label53.ForeColor = Color.White;
            label53.Location = new Point(182, 302);
            label53.Name = "label53";
            label53.Size = new Size(0, 30);
            label53.TabIndex = 52;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label47.ForeColor = Color.White;
            label47.Location = new Point(182, 223);
            label47.Name = "label47";
            label47.Size = new Size(0, 30);
            label47.TabIndex = 51;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label42.ForeColor = Color.White;
            label42.Location = new Point(73, 523);
            label42.Name = "label42";
            label42.Size = new Size(157, 30);
            label42.TabIndex = 42;
            label42.Text = "Tên đăng nhập ";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label41.ForeColor = Color.White;
            label41.Location = new Point(73, 620);
            label41.Name = "label41";
            label41.Size = new Size(115, 30);
            label41.TabIndex = 41;
            label41.Text = "Quyền hạn";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label40.ForeColor = Color.White;
            label40.Location = new Point(542, 523);
            label40.Name = "label40";
            label40.Size = new Size(107, 30);
            label40.TabIndex = 40;
            label40.Text = "Mật khẩu ";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label39.ForeColor = Color.White;
            label39.Location = new Point(73, 447);
            label39.Name = "label39";
            label39.Size = new Size(255, 32);
            label39.TabIndex = 39;
            label39.Text = "2. Thông tin tài khoản";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label38.ForeColor = Color.White;
            label38.Location = new Point(73, 383);
            label38.Name = "label38";
            label38.Size = new Size(77, 30);
            label38.TabIndex = 38;
            label38.Text = "Địa chỉ";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label37.ForeColor = Color.White;
            label37.Location = new Point(542, 302);
            label37.Name = "label37";
            label37.Size = new Size(135, 30);
            label37.TabIndex = 37;
            label37.Text = "Số điện thoại";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label36.ForeColor = Color.White;
            label36.Location = new Point(73, 142);
            label36.Name = "label36";
            label36.Size = new Size(276, 32);
            label36.TabIndex = 36;
            label36.Text = "1. Thông tin người dùng";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label35.ForeColor = Color.White;
            label35.Location = new Point(542, 223);
            label35.Name = "label35";
            label35.Size = new Size(106, 30);
            label35.TabIndex = 35;
            label35.Text = "Ngày sinh";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label34.ForeColor = Color.White;
            label34.Location = new Point(73, 223);
            label34.Name = "label34";
            label34.Size = new Size(103, 30);
            label34.TabIndex = 34;
            label34.Text = "Họ và tên";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label33.ForeColor = Color.White;
            label33.Location = new Point(73, 302);
            label33.Name = "label33";
            label33.Size = new Size(92, 30);
            label33.TabIndex = 33;
            label33.Text = "Giới tính";
            // 
            // label32
            // 
            label32.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label32.ForeColor = Color.White;
            label32.Location = new Point(73, 47);
            label32.Name = "label32";
            label32.Size = new Size(345, 56);
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
            tabPage12.Location = new Point(4, 39);
            tabPage12.Name = "tabPage12";
            tabPage12.Size = new Size(1087, 835);
            tabPage12.TabIndex = 11;
            tabPage12.Text = "tabPage12";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(604, 178);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(268, 35);
            textBox13.TabIndex = 2;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(73, 178);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(268, 35);
            textBox14.TabIndex = 1;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(250, 136, 40);
            button15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button15.ForeColor = Color.White;
            button15.Location = new Point(73, 293);
            button15.Name = "button15";
            button15.Size = new Size(131, 40);
            button15.TabIndex = 3;
            button15.Text = "Xác nhận";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label44.ForeColor = Color.White;
            label44.Location = new Point(604, 148);
            label44.Name = "label44";
            label44.Size = new Size(146, 30);
            label44.TabIndex = 35;
            label44.Text = "Mật khẩu mới";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label45.ForeColor = Color.White;
            label45.Location = new Point(73, 148);
            label45.Name = "label45";
            label45.Size = new Size(179, 30);
            label45.TabIndex = 34;
            label45.Text = "Mật khẩu hiện tại";
            // 
            // label43
            // 
            label43.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label43.ForeColor = Color.White;
            label43.Location = new Point(73, 47);
            label43.Name = "label43";
            label43.Size = new Size(371, 56);
            label43.TabIndex = 33;
            label43.Text = "Thay đổi mật khẩu";
            // 
            // tabPage13
            // 
            tabPage13.BackColor = Color.FromArgb(34, 34, 34);
            tabPage13.Controls.Add(button18);
            tabPage13.Controls.Add(dateTimePicker3);
            tabPage13.Controls.Add(textBox20);
            tabPage13.Controls.Add(textBox19);
            tabPage13.Controls.Add(textBox17);
            tabPage13.Controls.Add(label64);
            tabPage13.Controls.Add(label63);
            tabPage13.Controls.Add(label62);
            tabPage13.Controls.Add(label61);
            tabPage13.Controls.Add(label60);
            tabPage13.Controls.Add(label48);
            tabPage13.Controls.Add(comboBox10);
            tabPage13.Controls.Add(textBox15);
            tabPage13.Controls.Add(textBox16);
            tabPage13.Controls.Add(label49);
            tabPage13.Controls.Add(comboBox11);
            tabPage13.Controls.Add(button14);
            tabPage13.Controls.Add(label50);
            tabPage13.Controls.Add(label51);
            tabPage13.Controls.Add(label52);
            tabPage13.Location = new Point(4, 39);
            tabPage13.Name = "tabPage13";
            tabPage13.Size = new Size(1087, 835);
            tabPage13.TabIndex = 12;
            tabPage13.Text = "tabPage13";
            // 
            // button18
            // 
            button18.BackColor = Color.FromArgb(250, 136, 40);
            button18.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button18.ForeColor = Color.White;
            button18.Location = new Point(313, 668);
            button18.Name = "button18";
            button18.Size = new Size(131, 40);
            button18.TabIndex = 10;
            button18.Text = "Làm mới";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(73, 419);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(268, 35);
            dateTimePicker3.TabIndex = 3;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(598, 543);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(268, 35);
            textBox20.TabIndex = 8;
            // 
            // textBox19
            // 
            textBox19.Location = new Point(73, 543);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(268, 35);
            textBox19.TabIndex = 4;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(600, 300);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(268, 35);
            textBox17.TabIndex = 6;
            // 
            // label64
            // 
            label64.AutoSize = true;
            label64.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label64.ForeColor = Color.White;
            label64.Location = new Point(595, 387);
            label64.Name = "label64";
            label64.Size = new Size(94, 30);
            label64.TabIndex = 64;
            label64.Text = "Giới tính";
            // 
            // label63
            // 
            label63.AutoSize = true;
            label63.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label63.ForeColor = Color.White;
            label63.Location = new Point(600, 507);
            label63.Name = "label63";
            label63.Size = new Size(77, 30);
            label63.TabIndex = 63;
            label63.Text = "Địa chỉ";
            // 
            // label62
            // 
            label62.AutoSize = true;
            label62.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label62.ForeColor = Color.White;
            label62.Location = new Point(73, 507);
            label62.Name = "label62";
            label62.Size = new Size(139, 30);
            label62.TabIndex = 60;
            label62.Text = "Số điện thoại";
            // 
            // label61
            // 
            label61.AutoSize = true;
            label61.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label61.ForeColor = Color.White;
            label61.Location = new Point(598, 387);
            label61.Name = "label61";
            label61.Size = new Size(0, 30);
            label61.TabIndex = 59;
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label60.ForeColor = Color.White;
            label60.Location = new Point(73, 387);
            label60.Name = "label60";
            label60.Size = new Size(108, 30);
            label60.TabIndex = 58;
            label60.Text = "Ngày sinh";
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label48.ForeColor = Color.White;
            label48.Location = new Point(600, 267);
            label48.Name = "label48";
            label48.Size = new Size(106, 30);
            label48.TabIndex = 57;
            label48.Text = "Họ và tên";
            // 
            // comboBox10
            // 
            comboBox10.FormattingEnabled = true;
            comboBox10.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox10.Location = new Point(598, 420);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(268, 38);
            comboBox10.TabIndex = 7;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(600, 180);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(268, 35);
            textBox15.TabIndex = 5;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(70, 180);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(268, 35);
            textBox16.TabIndex = 1;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label49.ForeColor = Color.White;
            label49.Location = new Point(73, 267);
            label49.Name = "label49";
            label49.Size = new Size(116, 30);
            label49.TabIndex = 50;
            label49.Text = "Quyền hạn";
            // 
            // comboBox11
            // 
            comboBox11.FormattingEnabled = true;
            comboBox11.Items.AddRange(new object[] { "Nhân viên", "Quản lý" });
            comboBox11.Location = new Point(73, 300);
            comboBox11.Name = "comboBox11";
            comboBox11.Size = new Size(268, 38);
            comboBox11.TabIndex = 2;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(250, 136, 40);
            button14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button14.ForeColor = Color.White;
            button14.Location = new Point(73, 668);
            button14.Name = "button14";
            button14.Size = new Size(131, 40);
            button14.TabIndex = 9;
            button14.Text = "Xác nhận";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label50.ForeColor = Color.White;
            label50.Location = new Point(600, 147);
            label50.Name = "label50";
            label50.Size = new Size(103, 30);
            label50.TabIndex = 46;
            label50.Text = "Mật khẩu";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label51.ForeColor = Color.White;
            label51.Location = new Point(70, 147);
            label51.Name = "label51";
            label51.Size = new Size(155, 30);
            label51.TabIndex = 45;
            label51.Text = "Tên đăng nhập";
            // 
            // label52
            // 
            label52.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label52.ForeColor = Color.White;
            label52.Location = new Point(73, 47);
            label52.Name = "label52";
            label52.Size = new Size(371, 56);
            label52.TabIndex = 44;
            label52.Text = "Thêm tài khoản mới";
            // 
            // tabPage14
            // 
            tabPage14.BackColor = Color.FromArgb(34, 34, 34);
            tabPage14.Controls.Add(label67);
            tabPage14.Controls.Add(dataGridView7);
            tabPage14.Location = new Point(4, 39);
            tabPage14.Name = "tabPage14";
            tabPage14.Size = new Size(1087, 835);
            tabPage14.TabIndex = 13;
            tabPage14.Text = "tabPage14";
            // 
            // label67
            // 
            label67.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label67.ForeColor = Color.White;
            label67.Location = new Point(53, 39);
            label67.Name = "label67";
            label67.Size = new Size(345, 56);
            label67.TabIndex = 2;
            label67.Text = "Danh sách vật tư";
            // 
            // dataGridView7
            // 
            dataGridView7.AllowUserToAddRows = false;
            dataGridView7.AllowUserToDeleteRows = false;
            dataGridView7.AllowUserToResizeColumns = false;
            dataGridView7.AllowUserToResizeRows = false;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle23.ForeColor = Color.White;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
            dataGridView7.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            dataGridView7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView7.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView7.BackgroundColor = Color.FromArgb(34, 34, 34);
            dataGridView7.BorderStyle = BorderStyle.None;
            dataGridView7.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridView7.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle24.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle24.ForeColor = Color.White;
            dataGridViewCellStyle24.SelectionBackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle24.SelectionForeColor = Color.White;
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            dataGridView7.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            dataGridView7.ColumnHeadersHeight = 54;
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle25.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle25.ForeColor = Color.White;
            dataGridViewCellStyle25.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = DataGridViewTriState.True;
            dataGridView7.DefaultCellStyle = dataGridViewCellStyle25;
            dataGridView7.EnableHeadersVisualStyles = false;
            dataGridView7.GridColor = Color.White;
            dataGridView7.Location = new Point(0, 118);
            dataGridView7.Margin = new Padding(0);
            dataGridView7.MultiSelect = false;
            dataGridView7.Name = "dataGridView7";
            dataGridView7.ReadOnly = true;
            dataGridView7.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle26.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle26.ForeColor = Color.White;
            dataGridViewCellStyle26.SelectionBackColor = Color.FromArgb(34, 34, 34);
            dataGridViewCellStyle26.SelectionForeColor = Color.White;
            dataGridView7.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            dataGridView7.RowHeadersVisible = false;
            dataGridView7.RowHeadersWidth = 50;
            dataGridView7.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView7.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView7.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
            dataGridView7.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridView7.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView7.RowTemplate.Height = 37;
            dataGridView7.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView7.Size = new Size(1087, 678);
            dataGridView7.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1376, 836);
            Controls.Add(tabControl1);
            Controls.Add(treeView1);
            Icon = Properties.Resources.icon1;
            MaximizeBox = false;
            MaximumSize = new Size(1400, 900);
            MinimizeBox = false;
            MinimumSize = new Size(1400, 900);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            tabPage10.ResumeLayout(false);
            tabPage10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            tabPage11.ResumeLayout(false);
            tabPage11.PerformLayout();
            tabPage12.ResumeLayout(false);
            tabPage12.PerformLayout();
            tabPage13.ResumeLayout(false);
            tabPage13.PerformLayout();
            tabPage14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public string taiKhoan, matKhau;
        private ImageList imageList1;
        private TreeView treeView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private PictureBox pictureBox1;
        private Label label1;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private TabPage tabPage11;
        private TabPage tabPage12;
        private TabPage tabPage13;
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
        private Label label12;
        private Label label14;
        private DateTimePicker dateTimePicker2;
        private Label label13;
        private Button button5;
        private Button button4;
        private DataGridView dataGridView2;
        private Button button3;
        private Label label16;
        private Label label17;
        private Label label19;
        private Label label20;
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
        private Label label49;
        private ComboBox comboBox11;
        private Button button14;
        private Label label50;
        private Label label51;
        private Label label52;
        private TabPage tabPage4;
        private DataGridView dataGridView1;
        private Button button16;
        private DataGridView dataGridView4;
        private ComboBox comboBox1;
        private Button button17;
        private DataGridView dataGridView3;
        private Label label11;
        private Label label46;
        private DataGridView dataGridView5;
        private DataGridView dataGridView6;
        private Label label56;
        private Label label55;
        private Label label54;
        private Label label53;
        private Label label47;
        private Label label59;
        private Label label58;
        private Label label57;
        private Button button18;
        private DateTimePicker dateTimePicker3;
        private TextBox textBox20;
        private TextBox textBox19;
        private TextBox textBox17;
        private Label label64;
        private Label label63;
        private Label label62;
        private Label label61;
        private Label label60;
        private Label label48;
        private ComboBox comboBox10;
        private Label label21;
        private Label label65;
        private Label label18;
        private Label label66;
        private DateTimePicker dateTimePicker5;
        private Button button20;
        private Button button19;
        private ComboBox comboBox8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewComboBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewComboBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private ComboBox comboBox9;
        private TabPage tabPage14;
        private Label label67;
        private DataGridView dataGridView7;
    }
}