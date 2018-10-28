using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;

        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            this.v_ds_phanmanhTableAdapter.Fill(this.ds_phanmanh.v_ds_phanmanh);
            Program.bds_dspm = bds_ds_phanmanh;
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show();
        }


        private void btnDangnhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmDangNhap));
            if (f != null) f.Activate();
            else
            {
                f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmNhanVien));
            if (f != null) f.Activate();
            else
            {
                f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
