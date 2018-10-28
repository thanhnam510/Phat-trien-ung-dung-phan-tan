using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            int x = ParentForm.Width / 2  - panel3.Width / 2;
            int y = this.Height / 2 - panel3.Height/2;
            panel3.Location = new Point(x, y);
            try
            {
                cbbCN.DataSource = Program.bds_dspm;
                cbbCN.DisplayMember = "CHINHANH";
                cbbCN.ValueMember = "TENSERVER";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cbbCN.SelectedIndex = 0;
            cbbCN.SelectedIndex = 0;
            txtTK.Focus();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (txtTK.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được rỗng.", "Thất bại", MessageBoxButtons.OK);
                txtTK.Focus();
                return;
            }
            Program.login = txtTK.Text;
            Program.password = txtMK.Text;
            Program.servername = cbbCN.SelectedValue.ToString();
            if (Program.KetNoi() == 0) return;
            SqlDataReader myReader;

            String strLenh = "exec SP_DANGNHAP '" + Program.login + "'";
            myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader == null) return;
            myReader.Read();

            try
            {
                Program.username = myReader.GetString(0);     // Lay user name
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Tài khoản không hợp lệ.\n Xin kiểm tra lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);
            myReader.Close();
            Program.conn.Close();
            Program.frmChinh.MA.Text = "Mã: " + Program.username;
            Program.frmChinh.HOTEN.Text = "| Họ tên: " + Program.mHoten;
            Program.frmChinh.NHOM.Text = "| Nhóm: " + TuDien.tudien[Program.mGroup];
            Program.mlogin = Program.login;
            Program.mpassword = Program.password;
            Program.mChiNhanh = cbbCN.SelectedIndex;
            Program.frmChinh.btnDN.Enabled = false;
            Program.frmChinh.btnDX.Enabled = true;
            Program.frmChinh.rbpDP.Visible = true;
            if ("NHANVIEN" != Program.mGroup)
                Program.frmChinh.rbpQL.Visible = true;
                

        Close();
        }

        private void btnnHuy_Click(object sender, EventArgs e)
        {
            txtMK.Text = "";
            txtTK.Text = "";
        }
    }
}
