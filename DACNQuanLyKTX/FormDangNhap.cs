using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DACNQuanLyKTX.Models;
using System.Net;
using System.Net.Mail;


namespace DACNQuanLyKTX
{
    public partial class FormDangNhap : Form
    {
        ModelQLKTX db = new ModelQLKTX();
        public FormDangNhap()
        {
            InitializeComponent();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            List<QuanLy> dsQL = db.QuanLies.ToList();
            QuanLy ql = dsQL.Find(a => a.MaQL == txtTaiKhoan.Text);
            if (ql != null)
            {
                if (txtMauKhau.Text == ql.MatKhau)
                {
                    this.Visible = false;                   
                    FormQLKTX f = new FormQLKTX(ql);
                    f.ShowDialog();
                    this.Visible = true;
                    txtTaiKhoan.Text = "";
                    txtMauKhau.Text = "";
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu!");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!");
            }
        }

        private void llbQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            FormQuenMatKhau f = new FormQuenMatKhau();
            f.ShowDialog();
            this.Visible = true;
            txtTaiKhoan.Text = "";
            txtMauKhau.Text = "";
        }
    }
}
