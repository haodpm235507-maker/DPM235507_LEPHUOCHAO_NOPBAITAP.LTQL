using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frm_dmNhanVien : Form
    {
        public frm_dmNhanVien()
        {
            InitializeComponent();
        }

        private void frm_dmNhanVien_Load(object sender, EventArgs e)
        {
            cboChucVu.DataSource = ChucVu_BUS.LayChucVu();
            cboChucVu.DisplayMember = "STenCV";
            cboChucVu.ValueMember = "SMaCV";

            dgDSNhanVien.DataSource = NhanVien_BUS.LayNhanVien();
        }
    }
}
