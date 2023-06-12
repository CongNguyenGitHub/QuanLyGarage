using BUS;
using DAO;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage13_Click(object sender, EventArgs e)
        {

        }

        private void tabPage12_Click(object sender, EventArgs e)
        {

        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;
            switch (e.Node.Text)
            {
                case "Trang chủ":
                    tabControl1.SelectedIndex = 0;
                    break;
                case "Tiếp nhận xe":
                    tabControl1.SelectedIndex = 1;
                    break;
                case "Tra cứu xe":
                    tabControl1.SelectedIndex = 2;
                    break;
                case "Xem danh sách xe":
                    tabControl1.SelectedIndex = 3;
                    dataGridView1.DataSource = XeBUS.Instance.CacXeDaTiepNhan();
                    break;
                case "Lập phiếu sửa chữa":
                    tabControl1.SelectedIndex = 4;
                    break;
                case "Lập phiếu thu tiền":
                    tabControl1.SelectedIndex = 5;
                    break;
                case "Nhập vật tư phụ tùng":
                    tabControl1.SelectedIndex = 6;
                    break;
                case "Thay đổi quy định":
                    if (TaiKhoanBUS.Instance.LayQuyenHan(taiKhoan, matKhau) == "False")
                    {
                        MessageBox.Show("Chỉ có quản lý mới được xem quy định", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    dataGridView3.DataSource = QuyDinhBUS.Instance.LayTatCaQuyDinh();
                    tabControl1.SelectedIndex = 7;
                    break;
                case "Doanh thu":
                    if (TaiKhoanBUS.Instance.LayQuyenHan(taiKhoan, matKhau) == "False")
                    {
                        MessageBox.Show("Chỉ có quản lý mới được lập báo cáo doanh thu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    comboBox3.SelectedIndex= comboBox3.Items.IndexOf(DateTime.Now.Month.ToString());
                    comboBox5.SelectedIndex=comboBox5.Items.IndexOf(DateTime.Now.Year.ToString());
                    tabControl1.SelectedIndex = 8;
                    break;
                case "Tồn kho":
                    if (TaiKhoanBUS.Instance.LayQuyenHan(taiKhoan, matKhau) == "False")
                    {
                        MessageBox.Show("Chỉ có quản lý mới được lập báo cáo tồn kho", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    comboBox7.SelectedIndex = comboBox7.Items.IndexOf(DateTime.Now.Month.ToString());
                    comboBox6.SelectedIndex=comboBox6.Items.IndexOf(DateTime.Now.Year.ToString());
                    tabControl1.SelectedIndex = 9;
                    break;
                case "Thông tin cá nhân":
                    tabControl1.SelectedIndex = 10;
                    break;
                case "Thay đổi mật khẩu":
                    tabControl1.SelectedIndex = 11;
                    break;
                case "Thêm tài khoản":
                    tabControl1.SelectedIndex = 12;
                    break;
                case "Đăng xuất":
                    DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không", "Đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2
                    , MessageBoxOptions.ServiceNotification);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Nhập thiếu thong tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (XeBUS.Instance.TiepNhanXe(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.SelectedItem.ToString(), textBox4.Text, dateTimePicker1.Value))
            {
                MessageBox.Show("Tiếp nhận xe thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vượt quá số xe trong ngày", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (textBox5.Text == "" && comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Nhập thiếu thong tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox5.Text == "")
            {
                dt = XeBUS.Instance.TimKiemMotDoiSo(comboBox2.SelectedItem.ToString());
            }
            else if (comboBox2.SelectedIndex == -1)
            {
                dt = XeBUS.Instance.TimKiemMotDoiSo(textBox5.Text);
            }
            else
            {
                dt = XeBUS.Instance.TimKiemHaiDoiSo(textBox5.Text, comboBox2.SelectedItem.ToString());
            }
            button2.Enabled = false;
            textBox5.ReadOnly = true;
            comboBox2.Enabled = false;
            dataGridView4.DataSource = dt;


        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox5.ReadOnly = false;
            comboBox2.Enabled = true;
            textBox5.Clear();
            comboBox2.SelectedIndex = -1;
            dataGridView4.DataSource = null;
            button2.Enabled = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridView3.SelectedRows;
            string? MaThamSo = rows[0].Cells["STT"].Value.ToString();
            string? NoiDung = rows[0].Cells["Nội dung"].Value.ToString();
            if (NoiDung == null || MaThamSo == null) return;
            using (FromDiaglog frmDialog = new FromDiaglog())
            {
                frmDialog.Label1.Text = "Nhập " + NoiDung.ToLower() + " mới";
                if (frmDialog.ShowDialog() == DialogResult.OK)
                {
                    int GiaTriMoi;
                    if (Int32.TryParse(frmDialog.TextBox1.Text, out GiaTriMoi))
                    {
                        QuyDinhBUS.Instance.CapNhatQuyDinh(MaThamSo, GiaTriMoi);
                        MessageBox.Show("Thay đổi quy định thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView3.DataSource = QuyDinhBUS.Instance.LayTatCaQuyDinh();
                    }
                    else
                    {
                        MessageBox.Show("Thông tin nhập không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Nhập thiếu thông tin tháng hoặc năm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string? Thang = comboBox3.SelectedItem.ToString();
            string? Nam = comboBox5.SelectedItem.ToString();
            dataGridView5.DataSource = BaoCaoDoanhThuBUS.Instance.BaoCaoDoanhThu(Thang, Nam);
            string TongDoanhThu = BaoCaoDoanhThuBUS.Instance.TongTienDoanhThu(Thang, Nam);
            label46.Text = "Tổng doanh thu: " + TongDoanhThu;
            comboBox3.Enabled = false;
            comboBox5.Enabled = false;
            button11.Enabled = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            button11.Enabled = true;
            comboBox3.Enabled = true;
            comboBox5.Enabled = true;
            label46.Text = "";
            dataGridView5.DataSource = null;
            comboBox3.SelectedIndex = comboBox3.Items.IndexOf(DateTime.Now.Month.ToString());
            comboBox5.SelectedIndex = comboBox5.Items.IndexOf(DateTime.Now.Year.ToString());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex == -1 || comboBox7.SelectedIndex == -1)
            {
                MessageBox.Show("Nhập thiếu thông tin tháng hoặc năm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string? Thang = comboBox7.SelectedItem.ToString();
            string? Nam = comboBox6.SelectedItem.ToString();
            dataGridView6.DataSource = BaoCaoTonBUS.Instance.BaoCaoTon(Thang, Nam);
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            button13.Enabled = false;
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView6.DataSource = null;
            comboBox6.Enabled = true;
            comboBox7.Enabled= true;
            button13.Enabled= true;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox7.SelectedIndex = comboBox7.Items.IndexOf(DateTime.Now.Month.ToString());
            comboBox6.SelectedIndex = comboBox6.Items.IndexOf(DateTime.Now.Year.ToString());

        }
    }
}
