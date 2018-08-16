using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_PHANTAN2018
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            lbHoten.Text = Program.mHoten;
            lbNhom.Text = Program.mGroup;
        }

      

        private void tiQlnv_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Hide();
            FormNhanVien fnv = new FormNhanVien();
            fnv.Show();
        }

        private void tiQlvt_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Hide();
            FormVattu fvt = new FormVattu();
            fvt.Show();
        }

        private void tiDangxuat_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Application.Exit();
        }

        private void tiQlkho_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Hide();
            FormKho fk = new FormKho();
            fk.Show();
        }
    }
}
