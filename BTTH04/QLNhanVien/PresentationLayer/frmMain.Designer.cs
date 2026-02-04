namespace PresentationLayer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nmuChuongTrinh = new System.Windows.Forms.ToolStripMenuItem();
            this.nmuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.nmuChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.nmuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.nmuNghiepVu = new System.Windows.Forms.ToolStripMenuItem();
            this.nmuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.nmuGiupDo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nmuChuongTrinh,
            this.nmuDanhMuc,
            this.nmuNghiepVu,
            this.nmuBaoCao,
            this.nmuGiupDo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nmuChuongTrinh
            // 
            this.nmuChuongTrinh.Name = "nmuChuongTrinh";
            this.nmuChuongTrinh.Size = new System.Drawing.Size(109, 24);
            this.nmuChuongTrinh.Text = "Chương trình";
            // 
            // nmuDanhMuc
            // 
            this.nmuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nmuChucVu,
            this.nmuNhanVien});
            this.nmuDanhMuc.Name = "nmuDanhMuc";
            this.nmuDanhMuc.Size = new System.Drawing.Size(90, 24);
            this.nmuDanhMuc.Text = "Danh mục";
            // 
            // nmuChucVu
            // 
            this.nmuChucVu.Name = "nmuChucVu";
            this.nmuChucVu.Size = new System.Drawing.Size(224, 26);
            this.nmuChucVu.Text = "Chức vụ";
            this.nmuChucVu.Click += new System.EventHandler(this.nmuChucVu_Click);
            // 
            // nmuNhanVien
            // 
            this.nmuNhanVien.Name = "nmuNhanVien";
            this.nmuNhanVien.Size = new System.Drawing.Size(224, 26);
            this.nmuNhanVien.Text = "Nhân viên";
            this.nmuNhanVien.Click += new System.EventHandler(this.nmuNhanVien_Click);
            // 
            // nmuNghiepVu
            // 
            this.nmuNghiepVu.Name = "nmuNghiepVu";
            this.nmuNghiepVu.Size = new System.Drawing.Size(91, 24);
            this.nmuNghiepVu.Text = "Nghiệp vụ";
            // 
            // nmuBaoCao
            // 
            this.nmuBaoCao.Name = "nmuBaoCao";
            this.nmuBaoCao.Size = new System.Drawing.Size(77, 24);
            this.nmuBaoCao.Text = "Báo cáo";
            // 
            // nmuGiupDo
            // 
            this.nmuGiupDo.Name = "nmuGiupDo";
            this.nmuGiupDo.Size = new System.Drawing.Size(76, 24);
            this.nmuGiupDo.Text = "Giúp đỡ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 497);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Chương trình quản lý nhân viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nmuChuongTrinh;
        private System.Windows.Forms.ToolStripMenuItem nmuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem nmuChucVu;
        private System.Windows.Forms.ToolStripMenuItem nmuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem nmuNghiepVu;
        private System.Windows.Forms.ToolStripMenuItem nmuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem nmuGiupDo;
    }
}