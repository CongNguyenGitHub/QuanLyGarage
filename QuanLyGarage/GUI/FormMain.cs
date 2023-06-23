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
            dataGridView2.Rows.Add();
            List<string> bienSo = new List<string>();
            DataTable dt = PhieuSuaChuaBUS.Instance.LayBienSoDaTiepNhan();
            foreach (DataRow row in dt.Rows)
            {
#pragma warning disable CS8604 // Possible null reference argument.
                bienSo.Add(row[0].ToString());
#pragma warning restore CS8604 // Possible null reference argument.
            }
            comboBox8.DataSource = bienSo;
            comboBox8.SelectedIndex = 0;
            comboBox9.DataSource = bienSo;
            comboBox9.SelectedIndex = 0;
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
                    if (TaiKhoanBUS.Instance.LayQuyenHan(taiKhoan, matKhau) == "False")
                    {
                        MessageBox.Show("Chỉ có quản lý mới được nhập vật tư phụ tùng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    tabControl1.SelectedIndex = 6;
                    break;
                case "Thay đổi quy định":
                    tabControl1.SelectedIndex = 7;
                    dataGridView3.DataSource = QuyDinhBUS.Instance.LayTatCaQuyDinh();
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
                case "Xem danh sách vật tư":
                    tabControl1.SelectedIndex = 13;
                    dataGridView7.DataSource = PhieuNhapVatTuBUS.Instance.LaySoLuongVatTuHienTai();
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
            if (XeBUS.Instance.KiemTraBienSoDaTonTai(textBox2.Text) == true)
            {
                MessageBox.Show("Biển số xe đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Nhập thiếu thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!TaiKhoanBUS.Instance.KiemTraTenDNTonTai(tenDN))
            {
                MessageBox.Show("Tên đăng nhập tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (NguoiDungBUS.Instance.KiemTraNguoiDungDaTonTai(hoTen, ngaySinh, (gioiTinh == "1") ? 1 : 0, SDT, diaChi) == true)
            {
                MessageBox.Show("Người dùng đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (this.DialogResult != DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int soTienThu;
            string? bienSo;
            DateTime ngayThuTien;
            if (comboBox9.SelectedIndex == -1 || textBox11.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bienSo = comboBox9.SelectedValue.ToString();
            ngayThuTien = dateTimePicker4.Value;
            DataTable dt = PhieuThuTienBUS.Instance.LayThongTinKhachHang(bienSo);
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
            MessageBox.Show("Lập phiếu thu tiền thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PhieuThuTienBUS.Instance.ThemPhieuThuTien(bienSo, soTienThu.ToString(), ngayThuTien);
            button3.Enabled = false;
            comboBox9.Enabled = false;
            textBox11.ReadOnly = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            comboBox9.Enabled = true;
            textBox11.ReadOnly = false;
            comboBox9.SelectedIndex = 0;
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
            string prompt = "Tổng tiền: " + tongTien.ToString();
            using (FormDialog2 frmDialog = new FormDialog2())
            {
                frmDialog.Label1.Text = prompt;
                if (frmDialog.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Lập phiếu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PhieuNhapVatTuBUS.Instance.ThemPhieuNhapVatTu(VTPT, soLuong.ToString(), ngayNhap);
                    comboBox4.Enabled = false;
                    textBox12.ReadOnly = true;
                    button7.Enabled = false;

                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox4.Enabled = true;
            textBox12.ReadOnly = false;
            button7.Enabled = true;
            comboBox4.SelectedIndex = 0;
            textBox12.Clear();
            dateTimePicker5.Value = DateTime.Now;
        }

        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int newRowInd = dataGridView2.Rows.Count - 1;
            dataGridView2[0, newRowInd].Value = newRowInd + 1;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.Rows.Count - 1);
            }

        }


        private void dataGridView2_EndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int cRow, cCol, soLuongNhap, soLuongTon;
            cRow = e.RowIndex;
            cCol = e.ColumnIndex;
            if (cCol == 2 && dataGridView2[2, cRow].Value != null)
            {
                string? ten = dataGridView2[2, cRow].Value.ToString();
                DataTable dt = PhieuSuaChuaBUS.Instance.LayDonGiaAndSoLuongVatTu(ten);
                dataGridView2[4, cRow].Value = dt.Rows[0][0];
            }
            if (cCol == 3 && dataGridView2[3, cRow].Value != null)
            {
                if (dataGridView2[2, cRow].Value == null)
                {
                    MessageBox.Show("Chưa nhập tên VTPT", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView2[3, cRow].Value = "";
                    return;
                }
                if (!Int32.TryParse(dataGridView2[3, cRow].Value.ToString(), out soLuongNhap) || soLuongNhap < 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView2[3, cRow].Value = "";
                    return;
                }
                string? ten = dataGridView2[2, cRow].Value.ToString();
                DataTable dt = PhieuSuaChuaBUS.Instance.LayDonGiaAndSoLuongVatTu(ten);
                Int32.TryParse(dt.Rows[0][1].ToString(), out soLuongTon);
                if (soLuongTon < soLuongNhap)
                {
                    MessageBox.Show("Số lượng tồn của vật tư phụ tùng không đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView2[3, cRow].Value = "";
                    return;
                }

            }

            if (dataGridView2[2, cRow].Value != null && dataGridView2[3, cRow].Value != null &&
                dataGridView2[5, cRow].Value != null)
            {
                int soLuong, donGia, tienCong;
                string? tenTienCong = dataGridView2[5, cRow].Value.ToString();
                Int32.TryParse(dataGridView2[3, cRow].Value.ToString(), out soLuong);
                Int32.TryParse(dataGridView2[4, cRow].Value.ToString(), out donGia);
                tienCong = PhieuSuaChuaBUS.Instance.LayTienCong(tenTienCong);
                dataGridView2[6, cRow].Value = tienCong + soLuong * donGia;
            }
            else
            {
                dataGridView2[6, cRow].Value = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int tongTien = 0;
            DateTime ngaySua;
            string? bienSo, tenVT, tenTienCong;
            int thanhTien, soLuong;
            if (comboBox8.SelectedIndex == -1)
            {
                MessageBox.Show("Nhập thiếu thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells[6].Value != null)
                {
                    Int32.TryParse(row.Cells[6].Value.ToString(), out thanhTien);
                    tongTien += thanhTien;
                }
                else
                {
                    MessageBox.Show("Nhập thiếu thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            bienSo = comboBox8.SelectedValue.ToString();
            ngaySua = dateTimePicker2.Value;
            string prompt = "Tổng tiền: " + tongTien.ToString();
            using (FormDialog2 frmDialog = new FormDialog2())
            {
                frmDialog.Label1.Text = prompt;
                if (frmDialog.ShowDialog() == DialogResult.OK)
                {
                    PhieuSuaChuaBUS.Instance.ThemPhieuSuaChua(bienSo, ngaySua, tongTien);
                    MessageBox.Show("Thêm phiếu sửa chữa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        tenVT = row.Cells[2].Value.ToString();
                        tenTienCong = row.Cells[5].Value.ToString();
                        Int32.TryParse(row.Cells[3].Value.ToString(), out soLuong);
                        PhieuSuaChuaBUS.Instance.ThemCT_ThemPhieuSuaChua(tenVT, tenTienCong, soLuong);

                    }
                    button19.Enabled = false;
                    button20.Enabled = false;
                    button4.Enabled = false;
                    dataGridView2.Enabled = false;
                    comboBox8.Enabled = false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button19.Enabled = true;
            button20.Enabled = true;
            button4.Enabled = true;
            dataGridView2.Enabled = true;
            comboBox8.Enabled = true;
            comboBox8.SelectedIndex = 0;
            dateTimePicker2.Value = DateTime.Now;
            for (int i = dataGridView2.Rows.Count - 1; i >= 0; i--)
            {
                dataGridView2.Rows.RemoveAt(i);
            }
            dataGridView2.Rows.Add();

        }
    }
}

