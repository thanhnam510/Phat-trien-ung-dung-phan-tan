namespace QLVT
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.cbbCN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTK
            // 
            resources.ApplyResources(this.txtTK, "txtTK");
            this.txtTK.Name = "txtTK";
            // 
            // txtMK
            // 
            resources.ApplyResources(this.txtMK, "txtMK");
            this.txtMK.Name = "txtMK";
            // 
            // cbbCN
            // 
            this.cbbCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCN.FormattingEnabled = true;
            resources.ApplyResources(this.cbbCN, "cbbCN");
            this.cbbCN.Name = "cbbCN";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Name = "label4";
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnLogin.Appearance.Font")));
            this.btnLogin.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // btnnCancel
            // 
            this.btnnCancel.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnnCancel.Appearance.Font")));
            this.btnnCancel.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnnCancel, "btnnCancel");
            this.btnnCancel.Name = "btnnCancel";
            this.btnnCancel.Click += new System.EventHandler(this.btnnHuy_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtTK);
            this.panel3.Controls.Add(this.cbbCN);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Controls.Add(this.btnnCancel);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtMK);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // frmDangNhap
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "frmDangNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.ComboBox cbbCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnnCancel;
        private System.Windows.Forms.Panel panel3;
    }
}