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
    public partial class FormVattu : Form
    {
        int vitri = 0;
        public FormVattu()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVattu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormVattu_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.vattuTableAdapter.Fill(this.dS.Vattu);
            // TODO: This line of code loads data into the 'dS.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.dS.CTDDH);
            // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Fill(this.dS.CTPN);
            // TODO: This line of code loads data into the 'dS.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Fill(this.dS.CTPX);
            // TODO: This line of code loads data into the 'dS.Vattu' table. You can move, or remove it, as needed.
            groupBox1.Enabled = bbiPhuchoiVT.Enabled = bbiLuuVT.Enabled = false;


        }
        private void bbiThemVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVattu.Position;
            groupBox1.Enabled = true;
            bdsVattu.AddNew();
            bbiThemVT.Enabled = bbiSuaVT.Enabled = bbiXoaVT.Enabled = bbiReloadVT.Enabled = bbiThoatVT.Enabled = false;
            bbiLuuVT.Enabled = bbiPhuchoiVT.Enabled = true;
            vattuGridControl.Enabled = false;
        }

        private void bbiLuuVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(mAVTTextEdit.Text.Trim()=="")
            {
                MessageBox.Show("Mã vật tư không được để trống !", "", MessageBoxButtons.OK);
                mAVTTextEdit.Focus();
                return;
            }
            if (tENVTTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Tên vật tư không được để trống !", "", MessageBoxButtons.OK);
                tENVTTextEdit.Focus();
                return;
            }
            if (sOLUONGTONSpinEdit.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng tồn không được để trống !", "", MessageBoxButtons.OK);
                sOLUONGTONSpinEdit.Focus();
                return;
            }
            if (dVTTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Đơn vị tính không được để trống !", "", MessageBoxButtons.OK);
                dVTTextEdit.Focus();
                return;
            }
            try
            {
                bdsVattu.EndEdit();
                bdsVattu.ResetCurrentItem();
            
                this.vattuTableAdapter.Update(this.dS.Vattu);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi vật tư .\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            vattuGridControl.Enabled = true;
            groupBox1.Enabled = false;
            bbiThemVT.Enabled = bbiSuaVT.Enabled = bbiXoaVT.Enabled = bbiReloadVT.Enabled = bbiThoatVT.Enabled = true;
            bbiLuuVT.Enabled = bbiPhuchoiVT.Enabled = false;
            

        }

        private void bbiXoaVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String mavt = "";
            if (bdsCTDH.Count > 0 || bdsCTPN.Count > 0 || bdsCTPX.Count > 0)
            {
                MessageBox.Show("Vật tư này đã được sử dụng", "Lỗi xóa vật tư", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK) ;
            {
                try
                {
                    mavt = ((DataRowView)bdsVattu[bdsVattu.Position])["MANV"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsVattu.RemoveCurrent();
                    this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.vattuTableAdapter.Update(this.dS.Vattu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa vật tư. Bạn hãy xóa lại\n" + ex.Message, "",MessageBoxButtons.OK);
                    this.vattuTableAdapter.Fill(this.dS.Vattu);
                    bdsVattu.Position = bdsVattu.Find("MANV", mavt);
                    return;
                }
            }
        }

        private void bbiSuaVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVattu.Position;
            groupBox1.Enabled = true;
            bbiThemVT.Enabled = bbiSuaVT.Enabled = bbiXoaVT.Enabled = false;
            bbiLuuVT.Enabled = bbiPhuchoiVT.Enabled = true;
            vattuGridControl.Enabled = false;
        }

        private void bbiThoatVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            this.Hide();
            using (FormMain fm = new FormMain())
                fm.ShowDialog();
        }
    }
}
