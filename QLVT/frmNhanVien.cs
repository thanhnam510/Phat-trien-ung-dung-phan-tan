using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmNhanVien : Form
    {
        DataRowView drv;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            pNhap.Width = 300;
            bar1.FloatLocation = new Point(standaloneBarDockControl1.Width,0);
            // TODO: This line of code loads data into the 'qLVTDataSet1.NHANVIEN' table. You can move, or remove it, as needed.
            this.ta_nv.Fill(this.ds_qlvt.NHANVIEN);
            bs_nv.Filter = "TRANG_THAI = 1";
            disableBtn();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcNV.Enabled = false;
            pNhap.Visible = pNhap.Enabled = true;
        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pNhap.Visible = pNhap.Enabled = false;
            gcNV.Enabled = true;
        }

        public string validate()
        {
            string msg = "";
            if (txtMANV.Text.Trim().Equals(""))
            {
                msg = "Mã nhân viên không được trống !";
                txtMANV.Focus();
                return msg;
            }
            if (txtHo.Text.Trim().Equals(""))
            {
                msg = "Họ nhân viên không được trống !";
                txtHo.Focus();
                return msg;
            }
            if (txtTen.Text.Trim().Equals(""))
            {
                msg = "Họ nhân viên không được trống !";
                txtTen.Focus();
                return msg;
            }
            if (txtDC.Text.Trim().Equals(""))
            {
                msg = "Địa chỉ không được trống !";
                txtDC.Focus();
                return msg;
            }
            if (txtSDT.Text.Trim().Equals(""))
            {
                msg = "Số điện thoại không được trống !";
                txtSDT.Focus();
                return msg;
            }
            return msg;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string msg = validate();
            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            drv = (DataRowView)bs_nv.Current;
            drv["TRANG_THAI"] = 0;

            try
            {
                string strLenh = "exec spDeactiveNV '" + drv["MANV"] + "'";
                Program.ExecSqlNonQuery(strLenh);
                bs_nv.EndEdit();
                bs_nv.Position = bs_nv.Position - 1;
                disableBtn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bs_nv.Position = bs_nv.Position - 1;
            disableBtn();
        }

        private void disableBtn()
        {
            if (bs_nv.Position < 0)
                btnDelete.Enabled = btnUpdate.Enabled = false;
            else
                btnDelete.Enabled = btnUpdate.Enabled = true;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ta_nv.Fill(this.ds_qlvt.NHANVIEN);
            disableBtn();
        }
    }
}
