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
    public partial class FormDN : Form
    {
        public FormDN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVATTUDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVATTUDataSet.V_DS_PHANMANH);
            cbChiNhanh.SelectedIndex = 1;
            cbChiNhanh.SelectedIndex = 0;

        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cbChiNhanh.SelectedValue.ToString();
            }
            catch(Exception r)
            {
                return;
            }
            
           
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(tbUser.Text.Trim()=="")
            {
                MessageBox.Show("Tài khoản đăng nhập không được rỗng", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                tbUser.Focus();
                return;
            }
            Program.mlogin = tbUser.Text.Trim();
            Program.password = tbPass.Text.Trim();
            if (Program.KetNoi() == 0)
                return;
           // MessageBox.Show("Đăng nhập thành công", " ", MessageBoxButtons.OK);
            Program.mChinhanh = cbChiNhanh.SelectedIndex;
            Program.bds_dspm = bdsDSPM;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            
            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            this.Hide();
            FormMain fm1 = new FormMain();
            fm1.Show();
           
            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
