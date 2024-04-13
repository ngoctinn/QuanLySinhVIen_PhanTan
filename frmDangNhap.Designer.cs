
namespace QLNV1
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txbTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txbMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txbTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMatKhau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(121, 123);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 29);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Chi Nhánh";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(121, 194);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(104, 29);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tài khoản";
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.EditValue = "N15DCCN001";
            this.txbTaiKhoan.Location = new System.Drawing.Point(249, 191);
            this.txbTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.txbTaiKhoan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTaiKhoan.Properties.Appearance.Options.UseBackColor = true;
            this.txbTaiKhoan.Properties.Appearance.Options.UseFont = true;
            this.txbTaiKhoan.Size = new System.Drawing.Size(365, 36);
            this.txbTaiKhoan.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(121, 266);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(99, 29);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Mật khẩu";
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.EditValue = "test";
            this.txbMatKhau.Location = new System.Drawing.Point(248, 263);
            this.txbMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau.Properties.Appearance.Options.UseBackColor = true;
            this.txbMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txbMatKhau.Properties.UseSystemPasswordChar = true;
            this.txbMatKhau.Size = new System.Drawing.Size(365, 36);
            this.txbMatKhau.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.Options.UseBackColor = true;
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.AutoSize = true;
            this.btnDangNhap.Location = new System.Drawing.Point(282, 397);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(162, 43);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.BackColor = System.Drawing.Color.IndianRed;
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseBackColor = true;
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(452, 397);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(161, 43);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Trở về ";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChiNhanh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChiNhanh.ForeColor = System.Drawing.Color.SteelBlue;
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(249, 120);
            this.cbChiNhanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(364, 37);
            this.cbChiNhanh.TabIndex = 1;
            this.cbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbChiNhanh_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkBox1.Location = new System.Drawing.Point(248, 344);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 33);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Sinh viên";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cbChiNhanh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txbTaiKhoan);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txbTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMatKhau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txbTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txbMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}