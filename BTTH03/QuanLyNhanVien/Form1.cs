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

namespace QuanLyNhanVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet("dsQLNV");
        SqlDataAdapter daChucVu;
        SqlDataAdapter daNhanVien;

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QLNV;Integrated Security=True";
            // Dữ liệu combobox Chức vụ
            string sQueryChucVu = @"select * from chucvu";
            daChucVu = new SqlDataAdapter(sQueryChucVu, conn);
            daChucVu.Fill(ds, "tblChucVu");
            cboChucVu.DataSource = ds.Tables["tblChucVu"];
            cboChucVu.DisplayMember = "tencv";
            cboChucVu.ValueMember = "macv";
            // Dữ liệu datagrid Danh sách nhân viên
            string sQueryNhanVien = @"select n.*, c.tencv from nhanvien n, chucvu c where
n.macv=c.macv";
            daNhanVien = new SqlDataAdapter(sQueryNhanVien, conn);
            daNhanVien.Fill(ds, "tblDSNhanVien");
            dgDSNhanVien.DataSource = ds.Tables["tblDSNhanVien"];
            dgDSNhanVien.Columns["manv"].HeaderText = "Mã số";
            dgDSNhanVien.Columns["manv"].Width = 60;
            dgDSNhanVien.Columns["holot"].HeaderText = "Họ và lót";
            dgDSNhanVien.Columns["holot"].Width = 120;
            dgDSNhanVien.Columns["tennv"].HeaderText = "Tên";
            dgDSNhanVien.Columns["tennv"].Width = 60;
            dgDSNhanVien.Columns["phai"].HeaderText = "Phái";
            dgDSNhanVien.Columns["phai"].Width = 60;
            dgDSNhanVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgDSNhanVien.Columns["ngaysinh"].Width = 90;
            dgDSNhanVien.Columns["tencv"].HeaderText = "Chức vụ";
            dgDSNhanVien.Columns["tencv"].Width = 120;
            dgDSNhanVien.Columns["macv"].Visible = false;

            string sThemNV = @"insert into nhanvien values(@MaNV, @HoLot, @TenNV, @Phai,
@NgaySinh, @MaCV)";
            SqlCommand cmThemNV = new SqlCommand(sThemNV, conn);
            cmThemNV.Parameters.Add("@MaNV", SqlDbType.NVarChar, 5, "manv");
            cmThemNV.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
            cmThemNV.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "tennv");
            cmThemNV.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "phai");
            cmThemNV.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 10,
            "ngaysinh");
            cmThemNV.Parameters.Add("@MaCV", SqlDbType.NVarChar, 5, "macv");
            daNhanVien.InsertCommand = cmThemNV;
        }
        private void dgDSNhanVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgDSNhanVien.SelectedRows[0];
            txtMaNV.Text = dr.Cells["manv"].Value.ToString();
            txtHoLot.Text = dr.Cells["holot"].Value.ToString();
            txtTen.Text = dr.Cells["tennv"].Value.ToString();
            if (dr.Cells["phai"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            dtpNgaySinh.Text = dr.Cells["ngaysinh"].Value.ToString();
            cboChucVu.SelectedValue = dr.Cells["macv"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtHoLot.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            DataRow[] rows = ds.Tables["tblDSNhanVien"]
                .Select("manv = '" + txtMaNV.Text + "'");
            if (rows.Length > 0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }

            DataRow row = ds.Tables["tblDSNhanVien"].NewRow();
            row["manv"] = txtMaNV.Text;
            row["holot"] = txtHoLot.Text;
            row["tennv"] = txtTen.Text;

            if (radNu.Checked == true)
                row["phai"] = "Nữ";
            else
                row["phai"] = "Nam";

            row["ngaysinh"] = dtpNgaySinh.Value;
            row["macv"] = cboChucVu.SelectedValue;

            ds.Tables["tblDSNhanVien"].Rows.Add(row);
            MessageBox.Show("Thêm nhân viên thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgDSNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
                return;
            }

            int index = dgDSNhanVien.CurrentRow.Index;
            DataRow row = ds.Tables["tblDSNhanVien"].Rows[index];

            row["holot"] = txtHoLot.Text;
            row["tennv"] = txtTen.Text;

            if (radNu.Checked)
                row["phai"] = "Nữ";
            else
                row["phai"] = "Nam";

            row["ngaysinh"] = dtpNgaySinh.Value;
            row["macv"] = cboChucVu.SelectedValue;

            dgDSNhanVien.Refresh();

            MessageBox.Show("Sửa thông tin nhân viên thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgDSNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?","Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                int index = dgDSNhanVien.CurrentRow.Index;
                ds.Tables["tblDSNhanVien"].Rows[index].Delete();

                MessageBox.Show("Đã xóa nhân viên!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder cb = new SqlCommandBuilder(daNhanVien);
                daNhanVien.Update(ds, "tblDSNhanVien");

                MessageBox.Show("Lưu dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ds.Tables["tblDSNhanVien"].RejectChanges();

            MessageBox.Show("Đã hủy các thay đổi!");
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
