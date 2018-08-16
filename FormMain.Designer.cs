namespace QLVT_PHANTAN2018
{
    partial class FormMain
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame1 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame2 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tiQlnv = new DevExpress.XtraEditors.TileItem();
            this.tiAnh = new DevExpress.XtraEditors.TileItem();
            this.tileGroup4 = new DevExpress.XtraEditors.TileGroup();
            this.tiQlkho = new DevExpress.XtraEditors.TileItem();
            this.tiQlvt = new DevExpress.XtraEditors.TileItem();
            this.tiPhieunhap = new DevExpress.XtraEditors.TileItem();
            this.tiPhieuxuat = new DevExpress.XtraEditors.TileItem();
            this.tileGroup5 = new DevExpress.XtraEditors.TileGroup();
            this.tiDangxuat = new DevExpress.XtraEditors.TileItem();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem7 = new DevExpress.XtraEditors.TileItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNhom = new System.Windows.Forms.Label();
            this.lbHoten = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.BackgroundImage = global::QLVT_PHANTAN2018.Properties.Resources.backgroud1;
            this.tileControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Groups.Add(this.tileGroup3);
            this.tileControl1.Groups.Add(this.tileGroup4);
            this.tileControl1.Groups.Add(this.tileGroup5);
            this.tileControl1.ItemSize = 150;
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.MaxId = 30;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.SelectionColor = System.Drawing.Color.DarkRed;
            this.tileControl1.Size = new System.Drawing.Size(1025, 519);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "fmqlvt";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.tiQlnv);
            this.tileGroup3.Items.Add(this.tiAnh);
            this.tileGroup3.Name = "tileGroup3";
            // 
            // tiQlnv
            // 
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemElement1.Text = "Quản lí Nhân Viên";
            this.tiQlnv.Elements.Add(tileItemElement1);
            this.tiQlnv.Id = 17;
            this.tiQlnv.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tiQlnv.Name = "tiQlnv";
            this.tiQlnv.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tiQlnv_ItemClick);
            // 
            // tiAnh
            // 
            this.tiAnh.BackgroundImage = global::QLVT_PHANTAN2018.Properties.Resources.ndp2;
            this.tiAnh.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            this.tiAnh.CurrentFrameIndex = 1;
            tileItemElement2.Text = "Seo Công ty";
            this.tiAnh.Elements.Add(tileItemElement2);
            tileItemFrame1.BackgroundImage = global::QLVT_PHANTAN2018.Properties.Resources.ndp4;
            tileItemElement3.Text = "Seo Công ty";
            tileItemFrame1.Elements.Add(tileItemElement3);
            tileItemFrame2.BackgroundImage = global::QLVT_PHANTAN2018.Properties.Resources.ndp2;
            tileItemElement4.Text = "Seo Công ty";
            tileItemFrame2.Elements.Add(tileItemElement4);
            this.tiAnh.Frames.Add(tileItemFrame1);
            this.tiAnh.Frames.Add(tileItemFrame2);
            this.tiAnh.Id = 15;
            this.tiAnh.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tiAnh.Name = "tiAnh";
            // 
            // tileGroup4
            // 
            this.tileGroup4.Items.Add(this.tiQlkho);
            this.tileGroup4.Items.Add(this.tiQlvt);
            this.tileGroup4.Items.Add(this.tiPhieunhap);
            this.tileGroup4.Items.Add(this.tiPhieuxuat);
            this.tileGroup4.Name = "tileGroup4";
            // 
            // tiQlkho
            // 
            tileItemElement5.Image = global::QLVT_PHANTAN2018.Properties.Resources.kho3;
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            tileItemElement5.Text = "Quản lí Kho Hàng";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.tiQlkho.Elements.Add(tileItemElement5);
            this.tiQlkho.Id = 19;
            this.tiQlkho.Name = "tiQlkho";
            this.tiQlkho.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tiQlkho_ItemClick);
            // 
            // tiQlvt
            // 
            tileItemElement6.Image = global::QLVT_PHANTAN2018.Properties.Resources.vattu;
            tileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            tileItemElement6.Text = "Quản lí Vật tư";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.tiQlvt.Elements.Add(tileItemElement6);
            this.tiQlvt.Id = 20;
            this.tiQlvt.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tiQlvt.Name = "tiQlvt";
            this.tiQlvt.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tiQlvt_ItemClick);
            // 
            // tiPhieunhap
            // 
            tileItemElement7.Image = global::QLVT_PHANTAN2018.Properties.Resources.phieunhap1;
            tileItemElement7.Text = "Phiếu Nhập";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.tiPhieunhap.Elements.Add(tileItemElement7);
            this.tiPhieunhap.Id = 24;
            this.tiPhieunhap.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tiPhieunhap.Name = "tiPhieunhap";
            // 
            // tiPhieuxuat
            // 
            tileItemElement8.Image = global::QLVT_PHANTAN2018.Properties.Resources.phieuxuat;
            tileItemElement8.Text = "Phiếu Xuất";
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.tiPhieuxuat.Elements.Add(tileItemElement8);
            this.tiPhieuxuat.Id = 23;
            this.tiPhieuxuat.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tiPhieuxuat.Name = "tiPhieuxuat";
            // 
            // tileGroup5
            // 
            this.tileGroup5.Items.Add(this.tiDangxuat);
            this.tileGroup5.Name = "tileGroup5";
            // 
            // tiDangxuat
            // 
            tileItemElement9.Text = "Đăng Xuất";
            this.tiDangxuat.Elements.Add(tileItemElement9);
            this.tiDangxuat.Id = 29;
            this.tiDangxuat.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tiDangxuat.Name = "tiDangxuat";
            this.tiDangxuat.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tiDangxuat_ItemClick);
            // 
            // tileGroup2
            // 
            this.tileGroup2.Name = "tileGroup2";
            this.tileGroup2.Text = "Báo Cáo";
            // 
            // tileItem7
            // 
            tileItemElement10.Text = "tileItem7";
            this.tileItem7.Elements.Add(tileItemElement10);
            this.tileItem7.Id = 28;
            this.tileItem7.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem7.Name = "tileItem7";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNhom);
            this.groupBox1.Controls.Add(this.lbHoten);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 487);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 32);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lbNhom
            // 
            this.lbNhom.AutoSize = true;
            this.lbNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhom.Location = new System.Drawing.Point(400, 10);
            this.lbNhom.Name = "lbNhom";
            this.lbNhom.Size = new System.Drawing.Size(51, 16);
            this.lbNhom.TabIndex = 10;
            this.lbNhom.Text = "label3";
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoten.Location = new System.Drawing.Point(153, 10);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(20, 16);
            this.lbHoten.TabIndex = 9;
            this.lbHoten.Text = "ht";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhóm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Xin Chào:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tileControl1);
            this.Name = "FormMain";
            this.Text = "Quản lí Vật tư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TileGroup tileGroup4;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileItem tiAnh;
        private DevExpress.XtraEditors.TileItem tiQlnv;
        private DevExpress.XtraEditors.TileItem tiQlkho;
        private DevExpress.XtraEditors.TileItem tiQlvt;
        private DevExpress.XtraEditors.TileItem tiPhieunhap;
        private DevExpress.XtraEditors.TileItem tiPhieuxuat;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.Label lbNhom;
        private DevExpress.XtraEditors.TileGroup tileGroup5;
        private DevExpress.XtraEditors.TileItem tiDangxuat;
    }
}