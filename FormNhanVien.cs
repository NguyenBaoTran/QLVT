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
    public partial class FormNhanVien : Form
    {
        int vitri = 0;
        string macn = "";
        int sl_nhanvien = 0;
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();   
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dS.DatHang);
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            macn = ((DataRowView)nhanVienBindingSource[0])["MACN"].ToString();
            cbChiNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
            cbChiNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CONGTY") cbChiNhanh.Enabled = true;  // bật tắt theo phân quyền
            else cbChiNhanh.Enabled = false;
            tennv.Caption = "Họ tên :" +Program.mHoten;
            tennhom.Caption = "Nhóm :" + Program.mGroup;
            groupBox1.Enabled = false;
            bbiPhuchoiNV.Enabled =bbiLuu.Enabled = false;
            sl_nhanvien = nhanVienBindingSource.Count;
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.servername = cbChiNhanh.SelectedValue.ToString();

                if (cbChiNhanh.SelectedIndex != Program.mChinhanh)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == 0)
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                else
                {
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangTableAdapter.Fill(this.dS.DatHang);
                    macn = ((DataRowView)nhanVienBindingSource[0])["MACN"].ToString();
                }
            }
            catch
            {
                return;
            }
           
        }

        private void bbiThemNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                vitri = nhanVienBindingSource.Position;
                groupBox1.Enabled = true;
                nhanVienBindingSource.AddNew();
                mACNTextEdit.Text = macn;
                nGAYSINHDateEdit.EditValue = "";
                mACNTextEdit.Enabled = false;
                bbiThemNV.Enabled = bbiSuaNV.Enabled = bbiXoaNV.Enabled = bbiReloadNV.Enabled = false;
                bbiLuu.Enabled = bbiPhuchoiNV.Enabled = true;
                nhanVienGridControl.Enabled = false;
                int dongcuoi = nhanVienBindingSource.Count - 2;
                int manvTutang;
                manvTutang = int.Parse(gridView1.GetRowCellValue(dongcuoi, "MANV").ToString().Trim());
                manvTutang += 2;
               
                // MessageBox.Show(manvthem);

                mANVTextBox.Text = manvTutang.ToString().Trim();
                mANVTextBox.Enabled = false;
            }
            catch(Exception r)
            {

                MessageBox.Show("Lỗi thêm nhân viên" + r, "", MessageBoxButtons.OK);
                return;
            }
            
        }

        private void bbiXoaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 manv = 0;
            if (phieuNhapBindingSource.Count > 0 || phieuXuatBindingSource.Count > 0||datHangBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    manv = int.Parse(((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["MANV"].ToString()); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    nhanVienBindingSource.RemoveCurrent();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                    nhanVienBindingSource.Position = nhanVienBindingSource.Find("MANV", manv);
                    return;
                }
            }

            if (nhanVienBindingSource.Count == 0) bbiXoaNV.Enabled = false;
        }

        private void bbiSuaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = nhanVienBindingSource.Position;
            groupBox1.Enabled = true;
            bbiThemNV.Enabled = bbiSuaNV.Enabled = bbiXoaNV.Enabled = bbiReloadNV.Enabled = false;
            bbiLuu.Enabled = bbiPhuchoiNV.Enabled = true;
            nhanVienGridControl.Enabled = false;
        }

        private void bbiPhuchoiNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nhanVienBindingSource.CancelEdit();
            if (bbiThemNV.Enabled == false) nhanVienBindingSource.Position = vitri;
            nhanVienGridControl.Enabled = true;
            groupBox1.Enabled = false;
            bbiThemNV.Enabled = bbiSuaNV.Enabled = bbiXoaNV.Enabled = bbiReloadNV.Enabled = true;
            bbiLuu.Enabled = bbiPhuchoiNV.Enabled = false;
        }

        private void bbiReloadNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void bbiLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mANVTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                mANVTextBox.Focus();
                return;
            }
            if (hOTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                hOTextEdit.Focus();
                return;
            }
            if (tENTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                tENTextEdit.Focus();
                return;
            }
            // Kiểm tra MACN, PHAI, NGAYSINH  phải có
            // LUONg thỏa Miền giá trị
            // MANV không được trùng trên các phân mảnh

            try
            {
                nhanVienBindingSource.EndEdit();
                nhanVienBindingSource.ResetCurrentItem();
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Update(this.dS.NhanVien);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            nhanVienGridControl.Enabled = true;
            bbiThemNV.Enabled = bbiSuaNV.Enabled = bbiXoaNV.Enabled = bbiReloadNV.Enabled =  true;
            bbiLuu.Enabled = bbiPhuchoiNV.Enabled = false;

            groupBox1.Enabled = false;
        }

        private void bbiThoatNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sl_nhanvien != nhanVienBindingSource.Count && mANVTextBox.Text.Trim() != "")
            {
                DialogResult dlr = MessageBox.Show("Bạn có muốn lưu lại thay đổi nhân viên.\n", "", MessageBoxButtons.YesNo);
                {
                    if (dlr == DialogResult.Yes)
                    {
                        try
                        {
                            nhanVienBindingSource.EndEdit();
                            nhanVienBindingSource.ResetCurrentItem();
                            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                            this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                           
                            using (FormMain fm = new FormMain())
                                fm.ShowDialog();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    else
                    {
                        
                        using (FormMain fm = new FormMain())
                            fm.ShowDialog();

                    }

                }


            }
            else
            {
                this.Hide();
                using (FormMain fm = new FormMain())
                    fm.ShowDialog();
               
            }


            //using (FormMain fm = new FormMain())
            //    fm.ShowDialog();

        }
    }
}
