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
            comboBox4.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox3.SelectedIndex = comboBox3.Items.IndexOf(DateTime.Now.Month.ToString());
            comboBox5.SelectedIndex = comboBox5.Items.IndexOf(DateTime.Now.Year.ToString());
            comboBox7.SelectedIndex = comboBox7.Items.IndexOf(DateTime.Now.Month.ToString());
            comboBox6.SelectedIndex = comboBox6.Items.IndexOf(DateTime.Now.Year.ToString());
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
                    dataGridView3.DataSource = QuyDinhBUS.Instance.LayTatCaQuyDinh();
                    tabControl1.SelectedIndex = 7;
                    break;
                case "Doanh thu":
                    if (TaiKhoanBUS.Instance.LayQuyenHan(taiKhoan, matKhau) == "False")
                    {
                        MessageBox.Show("Chỉ có quản lý mới được lập báo cáo doanh thu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    tabControl1.SelectedIndex = 8;
                    break;
                case "Tồn kho":
                    if (TaiKhoanBUS.Instance.LayQuyenHan(taiKhoan, matKhau) == "False")
                    {
                        MessageBox.Show("Chỉ có quản lý mới được lập báo cáo tồn kho", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    tabControl1.SelectedIndex = 9;
                    break;
                case "Thông tin cá nhân":
                    tabControl1.SelectedIndex = 10;
                    DataTable dt = TaiKhoanBUS.Instance.LayToanBoThongTinTaiKhoan(taiKhoan, matKhau);
                    label47.Text = dt.Rows[0][0].ToString();
                    label55.Text = dt.Rows[0][1].ToString();
                    label53.Text = dt.Rows[0][2].ToString();
                    label56.Text = dt.Rows[0][3].ToString();
                    label54.Text = dt.Rows[0][4].ToString();
                    label57.Text = dt.Rows[0][5].ToString();
                    label59.Text = dt.Rows[0][6].ToString();
                    label58.Text = dt.Rows[0][7].ToString();
                    break;
                case "Thay đổi mật khẩu":
                    tabControl1.SelectedIndex = 11;
                    break;
                case "Thêm tài khoản":
                    if (TaiKhoanBUS.Instance.LayQuyenHan(taiKhoan, matKhau) == "False")
                    {
                        MessageBox.Show("Chỉ có quản lý mới được thêm tài khoản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    tabControl1.SelectedIndex = 12;
                    break;
                case "Đăng xuất":
                    using (FormDialog3 frmDialog = new FormDialog3())
                    { 
                        if (frmDialog.ShowDialog() == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
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
            button1.Enabled = false;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            comboBox1.Enabled = false;
            dateTimePicker1.Enabled = false;

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

        private void button16_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            comboBox1.Enabled = true;
            dateTimePicker1.Enabled = true;
            comboBox1.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            textBox5.ReadOnly = false;
            comboBox2.Enabled = true;
            textBox5.Clear();
            comboBox2.SelectedIndex = 0;
            dataGridView4.DataSource = null;
            button2.Enabled = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (TaiKhoanBUS.Instance.LayQuyenHan(taiKhoan, matKhau) == "False")
            {
                MessageBox.Show("Chỉ có quản lý mới được thay đổi quy định", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewSelectedRowCollection rows = dataGridView3.SelectedRows;
            string? MaThamSo = rows[0].Cells["STT"].Value.ToString();
            string? NoiDung = rows[0].Cells["Nội dung"].Value.ToString();
            if (NoiDung == null || MaThamSo == null) return;
            using (FormDialog1 frmDialog = new FormDialog1())
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
            comboBox7.Enabled = true;
            button13.Enabled = true;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox7.SelectedIndex = comboBox7.Items.IndexOf(DateTime.Now.Month.ToString());
            comboBox6.SelectedIndex = comboBox6.Items.IndexOf(DateTime.Now.Year.ToString());

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string currentPass = textBox14.Text;
            string newPass = textBox13.Text;
            if (currentPass == "" || newPass == "")
            {
                MessageBox.Show("Nhập thiếu thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (currentPass != matKhau)
            {
                MessageBox.Show("Mật khẩu không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TaiKhoanBUS.Instance.CapNhatMatKhau(taiKhoan, currentPass, newPass);
            MessageBox.Show("Đổi mật khẩu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            matKhau = newPass;
            textBox14.Clear();
            textBox13.Clear();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string tenDN, MK, quyenHan, hoTen, ngaySinh, gioiTinh, SDT, diaChi;
            tenDN = textBox16.Text;
            MK = textBox15.Text;
            quyenHan = comboBox11.SelectedIndex.ToString();
            hoTen = textBox17.Text;
            ngaySinh = dateTimePicker3.Value.ToString();
            gioiTinh = comboBox10.SelectedIndex.ToString();
            SDT = textBox19.Text;
            diaChi = textBox20.Text;
            if (tenDN == "" || MK == "" || quyenHan == "-1" || hoTen == "" || ngaySinh == "" || gioiTinh == "-1" || SDT == "" || diaChi == "")
            {
                MessageBox.Show("Nhập thiếu thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!TaiKhoanBUS.Instance.KiemTraTenDNTonTai(tenDN))
            {
                MessageBox.Show("Tên đăng nhập tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Thêm người dùng thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NguoiDungBUS.Instance.ThemNguoiDung(hoTen, ngaySinh, gioiTinh, SDT, diaChi);
            TaiKhoanBUS.Instance.ThemTaiKhoan(tenDN, MK, quyenHan);
            textBox16.ReadOnly = true;
            textBox15.ReadOnly = true;
            comboBox11.Enabled = false;
            textBox17.ReadOnly = true;
            dateTimePicker3.Enabled = false;
            comboBox10.Enabled = false;
            textBox19.ReadOnly = true;
            textBox20.ReadOnly = true;
            button14.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button14.Enabled = true;
            textBox16.ReadOnly = false;
            textBox15.ReadOnly = false;
            comboBox11.Enabled = true;
            textBox17.ReadOnly = false;
            dateTimePicker3.Enabled = true;
            comboBox10.Enabled = true;
            textBox19.ReadOnly = false;
            textBox20.ReadOnly = false;
            textBox16.Clear();
            textBox15.Clear();
            comboBox11.SelectedIndex = -1;
            textBox17.Clear();
            dateTimePicker3.Value = DateTime.Now;
            comboBox10.SelectedIndex = -1;
            textBox19.Clear();
            textBox20.Clear();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.DialogResult!=DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int soTienThu;
            string bienSo;
            DateTime ngayThuTien;
            if (textBox7.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bienSo = textBox7.Text;
            ngayThuTien = dateTimePicker4.Value;
            DataTable dt = PhieuThuTienBUS.Instance.LayThongTinKhachHang(bienSo);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Xe chưa được tiếp nhận", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Int32.TryParse(textBox11.Text, out soTienThu) || soTienThu <= 0 || soTienThu > PhieuThuTienBUS.Instance.LayTienNoKH(bienSo))
            {
                MessageBox.Show("Số tiền thu không hợp lê", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string? Hoten = dt.Rows[0][0].ToString();
            string? SDT = dt.Rows[0][1].ToString();
            string? DiaChi = dt.Rows[0][2].ToString();
            label65.Text = "Họ tên: " + Hoten;
            label20.Text = "Số điện thoại: " + SDT;
            label17.Text = "Địa chỉ: " + DiaChi;
            PhieuThuTienBUS.Instance.ThemPhieuThuTien(bienSo, soTienThu.ToString(), ngayThuTien);
            button3.Enabled = false;
            textBox7.ReadOnly = true;
            textBox11.ReadOnly = true;
            dateTimePicker4.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            dateTimePicker4.Enabled = true;
            textBox7.ReadOnly = false;
            textBox11.ReadOnly = false;
            textBox7.Clear();
            textBox11.Clear();
            dateTimePicker4.Value = DateTime.Now;
            label65.Text = label20.Text = label17.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == -1 || textBox12.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string? VTPT = comboBox4.SelectedItem.ToString();
            int soLuong = 0;
            DateTime ngayNhap = dateTimePicker5.Value;
            if (!Int32.TryParse(textBox12.Text, out soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int tongTien = PhieuNhapVatTuBUS.Instance.TinhTienVatTu(VTPT, soLuong.ToString());
            string prompt = "Tổng tiền cần thanh toán là: " + tongTien.ToString();
            using (FormDialog2 frmDialog = new FormDialog2())
            {
                frmDialog.Label1.Text = prompt;
                if (frmDialog.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Lập phiếu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PhieuNhapVatTuBUS.Instance.ThemPhieuNhapVatTu(VTPT, soLuong.ToString(), ngayNhap);
                    label67.Text = "Tổng tiền: " + tongTien.ToString();
                    comboBox4.Enabled = false;
                    textBox12.ReadOnly = true;
                    dateTimePicker5.Enabled = false;
                    button7.Enabled = false;

                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label67.Text = "";
            comboBox4.Enabled = true;
            textBox12.ReadOnly = false;
            dateTimePicker5.Enabled = true;
            button7.Enabled = true;
            comboBox4.SelectedIndex = 0;
            textBox12.Clear();
            dateTimePicker5.Value = DateTime.Now;
        }
    }
}
