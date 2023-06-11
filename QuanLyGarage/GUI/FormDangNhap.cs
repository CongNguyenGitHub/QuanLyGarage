using System.Data;
using System.Runtime.CompilerServices;
using DAO;
namespace GUI
{
    public partial class FormDangNhap : Form
    {


        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text=="" || this.textBox2.Text=="")
            {
                MessageBox.Show("Thiếu thông tin","Cảnh báo",0,MessageBoxIcon.Warning);
                return;
            }
            string TaiKhoan = this.textBox1.Text;
            string MatKhau = this.textBox2.Text;
            if (BUS.DangNhapBUS.Instance.checkDangNhapBUS(TaiKhoan , MatKhau)==false)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai", "Lỗi", 0, MessageBoxIcon.Error);
            }
            else
            {
                FormMain frmain = new FormMain();
                frmain.taiKhoan = textBox1.Text;
                frmain.matKhau = textBox2.Text;
                this.Hide();
                frmain.ShowDialog();
                this.Show();

            }
            this.textBox1.Clear();
            this.textBox2.Clear();
        }
    }
}