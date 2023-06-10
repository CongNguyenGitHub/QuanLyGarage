﻿using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    tabControl1.SelectedIndex = 7;
                    break;
                case "Doanh thu":
                    tabControl1.SelectedIndex = 8;
                    break;
                case "Tồn kho":
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
                MessageBox.Show("Nhập thiếu thong tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
        }
    }
}
