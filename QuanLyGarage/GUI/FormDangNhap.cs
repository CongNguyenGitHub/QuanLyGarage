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
                MessageBox.Show("Required information was missing","Warning",0,MessageBoxIcon.Warning);
                return;
            }
            string TaiKhoan = this.textBox1.Text;
            string MatKhau = this.textBox2.Text;
            if (BUS.DangNhapBUS.Instance.checkDangNhapBUS(TaiKhoan , MatKhau)==false)
            {
                MessageBox.Show("The username or password you entered was incorrect", "Error", 0, MessageBoxIcon.Error);
            }
            else
            {
                FormMain frmain = new FormMain();
                this.Hide();
                frmain.ShowDialog();
                this.Show();
            }
            this.textBox1.Clear();
            this.textBox2.Clear();
        }
    }
}