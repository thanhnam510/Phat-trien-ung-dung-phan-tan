namespace QLVT
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDN = new DevExpress.XtraBars.BarButtonItem();
            this.btnDX = new DevExpress.XtraBars.BarButtonItem();
            this.btnNV = new DevExpress.XtraBars.BarButtonItem();
            this.rbpTK = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbDN = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbDX = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpDP = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpQL = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbNV = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ds_phanmanh = new QLVT.QLVTDataSet();
            this.bds_ds_phanmanh = new System.Windows.Forms.BindingSource(this.components);
            this.v_ds_phanmanhTableAdapter = new QLVT.QLVTDataSetTableAdapters.v_ds_phanmanhTableAdapter();
            this.tableAdapterManager = new QLVT.QLVTDataSetTableAdapters.TableAdapterManager();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MA = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_phanmanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_ds_phanmanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDN,
            this.btnDX,
            this.btnNV});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpTK,
            this.rbpDP,
            this.rbpQL});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(797, 143);
            // 
            // btnDN
            // 
            this.btnDN.Caption = "Đăng nhập";
            this.btnDN.Id = 3;
            this.btnDN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDN.ImageOptions.Image")));
            this.btnDN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDN.ImageOptions.LargeImage")));
            this.btnDN.Name = "btnDN";
            // 
            // btnDX
            // 
            this.btnDX.Caption = "Đăng xuất";
            this.btnDX.Enabled = false;
            this.btnDX.Id = 6;
            this.btnDX.Name = "btnDX";
            // 
            // btnNV
            // 
            this.btnNV.Caption = "Nhân viên";
            this.btnNV.Id = 7;
            this.btnNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNV.ImageOptions.Image")));
            this.btnNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNV.ImageOptions.LargeImage")));
            this.btnNV.Name = "btnNV";
            this.btnNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNV_ItemClick);
            // 
            // rbpTK
            // 
            this.rbpTK.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbDN,
            this.rbDX});
            this.rbpTK.Name = "rbpTK";
            this.rbpTK.Text = "Tài khoản";
            // 
            // rbDN
            // 
            this.rbDN.ItemLinks.Add(this.btnDN);
            this.rbDN.Name = "rbDN";
            // 
            // rbDX
            // 
            this.rbDX.ItemLinks.Add(this.btnDX);
            this.rbDX.Name = "rbDX";
            // 
            // rbpDP
            // 
            this.rbpDP.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbpDP.Name = "rbpDP";
            this.rbpDP.Text = "Đơn - Phiếu";
            this.rbpDP.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // rbpQL
            // 
            this.rbpQL.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbNV});
            this.rbpQL.Name = "rbpQL";
            this.rbpQL.Text = "Quản lý";
            // 
            // rbNV
            // 
            this.rbNV.ItemLinks.Add(this.btnNV);
            this.rbNV.Name = "rbNV";
            // 
            // ds_phanmanh
            // 
            this.ds_phanmanh.DataSetName = "QLVTDataSet";
            this.ds_phanmanh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_ds_phanmanh
            // 
            this.bds_ds_phanmanh.DataMember = "v_ds_phanmanh";
            this.bds_ds_phanmanh.DataSource = this.ds_phanmanh;
            // 
            // v_ds_phanmanhTableAdapter
            // 
            this.v_ds_phanmanhTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MA,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(797, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MA
            // 
            this.MA.Name = "MA";
            this.MA.Size = new System.Drawing.Size(0, 17);
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(0, 17);
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(0, 17);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Nhân viên";
            this.ribbonPage1.Visible = false;
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 413);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý vật tư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_phanmanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_ds_phanmanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbDN;
        private QLVTDataSet ds_phanmanh;
        private System.Windows.Forms.BindingSource bds_ds_phanmanh;
        private QLVTDataSetTableAdapters.v_ds_phanmanhTableAdapter v_ds_phanmanhTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel MA;
        public DevExpress.XtraBars.BarButtonItem btnDX;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbpTK;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbpDP;
        public DevExpress.XtraBars.BarButtonItem btnDN;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbNV;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbpQL;
        private DevExpress.XtraBars.BarButtonItem btnNV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbDX;
    }
}

