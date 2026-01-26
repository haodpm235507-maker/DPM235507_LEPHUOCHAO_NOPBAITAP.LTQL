namespace QuanLyNhanVien
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tblMaNV = new System.Windows.Forms.Label();
            this.tblHoLot = new System.Windows.Forms.Label();
            this.tblPhai = new System.Windows.Forms.Label();
            this.tblChucVu = new System.Windows.Forms.Label();
            this.tblNgaySinh = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.tblDSNhanVien = new System.Windows.Forms.GroupBox();
            this.dgDSNhanVien = new System.Windows.Forms.DataGridView();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.tblDSNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Nhân VIên";
            // 
            // tblMaNV
            // 
            this.tblMaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblMaNV.AutoSize = true;
            this.tblMaNV.Location = new System.Drawing.Point(16, 84);
            this.tblMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tblMaNV.Name = "tblMaNV";
            this.tblMaNV.Size = new System.Drawing.Size(44, 16);
            this.tblMaNV.TabIndex = 1;
            this.tblMaNV.Text = "Mã số";
            // 
            // tblHoLot
            // 
            this.tblHoLot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblHoLot.AutoSize = true;
            this.tblHoLot.Location = new System.Drawing.Point(16, 130);
            this.tblHoLot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tblHoLot.Name = "tblHoLot";
            this.tblHoLot.Size = new System.Drawing.Size(46, 16);
            this.tblHoLot.TabIndex = 1;
            this.tblHoLot.Text = "Họ tên";
            // 
            // tblPhai
            // 
            this.tblPhai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblPhai.AutoSize = true;
            this.tblPhai.Location = new System.Drawing.Point(16, 171);
            this.tblPhai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tblPhai.Name = "tblPhai";
            this.tblPhai.Size = new System.Drawing.Size(34, 16);
            this.tblPhai.TabIndex = 1;
            this.tblPhai.Text = "Phái";
            // 
            // tblChucVu
            // 
            this.tblChucVu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblChucVu.AutoSize = true;
            this.tblChucVu.Location = new System.Drawing.Point(292, 84);
            this.tblChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tblChucVu.Name = "tblChucVu";
            this.tblChucVu.Size = new System.Drawing.Size(54, 16);
            this.tblChucVu.TabIndex = 1;
            this.tblChucVu.Text = "Chức vụ";
            // 
            // tblNgaySinh
            // 
            this.tblNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblNgaySinh.AutoSize = true;
            this.tblNgaySinh.Location = new System.Drawing.Point(292, 174);
            this.tblNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tblNgaySinh.Name = "tblNgaySinh";
            this.tblNgaySinh.Size = new System.Drawing.Size(67, 16);
            this.tblNgaySinh.TabIndex = 1;
            this.tblNgaySinh.Text = "Ngày sinh";
            // 
            // radNam
            // 
            this.radNam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(81, 166);
            this.radNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 5;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(152, 169);
            this.radNu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 20);
            this.radNu.TabIndex = 6;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // tblDSNhanVien
            // 
            this.tblDSNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblDSNhanVien.Controls.Add(this.dgDSNhanVien);
            this.tblDSNhanVien.Location = new System.Drawing.Point(7, 207);
            this.tblDSNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblDSNhanVien.Name = "tblDSNhanVien";
            this.tblDSNhanVien.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblDSNhanVien.Size = new System.Drawing.Size(700, 332);
            this.tblDSNhanVien.TabIndex = 3;
            this.tblDSNhanVien.TabStop = false;
            this.tblDSNhanVien.Text = "Danh sách nhân viên";
            // 
            // dgDSNhanVien
            // 
            this.dgDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDSNhanVien.Location = new System.Drawing.Point(4, 19);
            this.dgDSNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgDSNhanVien.Name = "dgDSNhanVien";
            this.dgDSNhanVien.RowHeadersWidth = 51;
            this.dgDSNhanVien.Size = new System.Drawing.Size(692, 309);
            this.dgDSNhanVien.TabIndex = 0;
            this.dgDSNhanVien.Click += new System.EventHandler(this.dgDSNhanVien_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaNV.Location = new System.Drawing.Point(81, 75);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(200, 22);
            this.txtMaNV.TabIndex = 2;
            // 
            // txtHoLot
            // 
            this.txtHoLot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHoLot.Location = new System.Drawing.Point(81, 122);
            this.txtHoLot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(308, 22);
            this.txtHoLot.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTen.Location = new System.Drawing.Point(399, 122);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(132, 22);
            this.txtTen.TabIndex = 4;
            // 
            // cboChucVu
            // 
            this.cboChucVu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(363, 80);
            this.cboChucVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(168, 24);
            this.cboChucVu.TabIndex = 7;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(363, 171);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(171, 22);
            this.dtpNgaySinh.TabIndex = 8;
            this.dtpNgaySinh.Value = new System.DateTime(2026, 1, 26, 0, 0, 0, 0);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Location = new System.Drawing.Point(564, 80);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(61, 28);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Location = new System.Drawing.Point(564, 124);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 28);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Location = new System.Drawing.Point(564, 171);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 28);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Thoat
            // 
            this.Thoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Thoat.Location = new System.Drawing.Point(633, 172);
            this.Thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(61, 28);
            this.Thoat.TabIndex = 14;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.Location = new System.Drawing.Point(633, 124);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(61, 28);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.Location = new System.Drawing.Point(633, 78);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(61, 28);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 554);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.cboChucVu);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHoLot);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.tblDSNhanVien);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.tblPhai);
            this.Controls.Add(this.tblHoLot);
            this.Controls.Add(this.tblNgaySinh);
            this.Controls.Add(this.tblChucVu);
            this.Controls.Add(this.tblMaNV);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tblDSNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tblMaNV;
        private System.Windows.Forms.Label tblHoLot;
        private System.Windows.Forms.Label tblPhai;
        private System.Windows.Forms.Label tblChucVu;
        private System.Windows.Forms.Label tblNgaySinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.GroupBox tblDSNhanVien;
        private System.Windows.Forms.DataGridView dgDSNhanVien;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtHoLot;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
    }
}

