namespace QLVT_PHANTAN2018
{
    partial class FormVattu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label sOLUONGTONLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVattu));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbiThemVT = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXoaVT = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSuaVT = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPhuchoiVT = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReloadVT = new DevExpress.XtraBars.BarButtonItem();
            this.bbiLuuVT = new DevExpress.XtraBars.BarButtonItem();
            this.bbiThoatVT = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.dS = new QLVT_PHANTAN2018.DS();
            this.bdsVattu = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLVT_PHANTAN2018.DSTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT_PHANTAN2018.DSTableAdapters.TableAdapterManager();
            this.vattuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sOLUONGTONSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.dVTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENVTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mAVTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.cTPXTableAdapter = new QLVT_PHANTAN2018.DSTableAdapters.CTPXTableAdapter();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.cTPNTableAdapter = new QLVT_PHANTAN2018.DSTableAdapters.CTPNTableAdapter();
            this.bdsCTDH = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new QLVT_PHANTAN2018.DSTableAdapters.CTDDHTableAdapter();
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            sOLUONGTONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVattu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGTONSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENVTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAVTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDH)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAVTLabel.Location = new System.Drawing.Point(34, 49);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(63, 16);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã Vật tư";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENVTLabel.Location = new System.Drawing.Point(258, 49);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(68, 16);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "Tên Vật tư";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dVTLabel.Location = new System.Drawing.Point(23, 97);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(68, 16);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "Đơn vị tính";
            // 
            // sOLUONGTONLabel
            // 
            sOLUONGTONLabel.AutoSize = true;
            sOLUONGTONLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOLUONGTONLabel.Location = new System.Drawing.Point(254, 97);
            sOLUONGTONLabel.Name = "sOLUONGTONLabel";
            sOLUONGTONLabel.Size = new System.Drawing.Size(82, 16);
            sOLUONGTONLabel.TabIndex = 6;
            sOLUONGTONLabel.Text = "Số lượng tồn";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiThemVT,
            this.bbiXoaVT,
            this.bbiSuaVT,
            this.bbiPhuchoiVT,
            this.bbiReloadVT,
            this.bbiLuuVT,
            this.bbiThoatVT});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar4;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiThemVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiXoaVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiSuaVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiPhuchoiVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiReloadVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiLuuVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiThoatVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // bbiThemVT
            // 
            this.bbiThemVT.Caption = "Thêm";
            this.bbiThemVT.Id = 0;
            this.bbiThemVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiThemVT.ImageOptions.Image")));
            this.bbiThemVT.Name = "bbiThemVT";
            this.bbiThemVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiThemVT_ItemClick);
            // 
            // bbiXoaVT
            // 
            this.bbiXoaVT.Caption = "Xóa";
            this.bbiXoaVT.Id = 1;
            this.bbiXoaVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiXoaVT.ImageOptions.Image")));
            this.bbiXoaVT.Name = "bbiXoaVT";
            this.bbiXoaVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiXoaVT_ItemClick);
            // 
            // bbiSuaVT
            // 
            this.bbiSuaVT.Caption = "Sửa";
            this.bbiSuaVT.Id = 2;
            this.bbiSuaVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiSuaVT.ImageOptions.Image")));
            this.bbiSuaVT.Name = "bbiSuaVT";
            this.bbiSuaVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSuaVT_ItemClick);
            // 
            // bbiPhuchoiVT
            // 
            this.bbiPhuchoiVT.Caption = "Phục hồi";
            this.bbiPhuchoiVT.Id = 3;
            this.bbiPhuchoiVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiPhuchoiVT.ImageOptions.Image")));
            this.bbiPhuchoiVT.Name = "bbiPhuchoiVT";
            // 
            // bbiReloadVT
            // 
            this.bbiReloadVT.Caption = "Reload";
            this.bbiReloadVT.Id = 4;
            this.bbiReloadVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiReloadVT.ImageOptions.Image")));
            this.bbiReloadVT.Name = "bbiReloadVT";
            // 
            // bbiLuuVT
            // 
            this.bbiLuuVT.Caption = "Lưu";
            this.bbiLuuVT.Id = 5;
            this.bbiLuuVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiLuuVT.ImageOptions.Image")));
            this.bbiLuuVT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiLuuVT.ImageOptions.LargeImage")));
            this.bbiLuuVT.Name = "bbiLuuVT";
            this.bbiLuuVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiLuuVT_ItemClick);
            // 
            // bbiThoatVT
            // 
            this.bbiThoatVT.Caption = "Thoát";
            this.bbiThoatVT.Id = 6;
            this.bbiThoatVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiThoatVT.ImageOptions.Image")));
            this.bbiThoatVT.Name = "bbiThoatVT";
            this.bbiThoatVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiThoatVT_ItemClick);
            // 
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(985, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 595);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(985, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 555);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(985, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 555);
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsVattu
            // 
            this.bdsVattu.DataMember = "Vattu";
            this.bdsVattu.DataSource = this.dS;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_PHANTAN2018.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // vattuGridControl
            // 
            this.vattuGridControl.DataSource = this.bdsVattu;
            this.vattuGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.vattuGridControl.Location = new System.Drawing.Point(0, 40);
            this.vattuGridControl.MainView = this.gridView1;
            this.vattuGridControl.MenuManager = this.barManager1;
            this.vattuGridControl.Name = "vattuGridControl";
            this.vattuGridControl.Size = new System.Drawing.Size(985, 293);
            this.vattuGridControl.TabIndex = 5;
            this.vattuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView1.GridControl = this.vattuGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã Vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên Vật tư";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn vị ";
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.Caption = "Số lượng tồn";
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(sOLUONGTONLabel);
            this.groupBox1.Controls.Add(this.sOLUONGTONSpinEdit);
            this.groupBox1.Controls.Add(dVTLabel);
            this.groupBox1.Controls.Add(this.dVTTextEdit);
            this.groupBox1.Controls.Add(tENVTLabel);
            this.groupBox1.Controls.Add(this.tENVTTextEdit);
            this.groupBox1.Controls.Add(mAVTLabel);
            this.groupBox1.Controls.Add(this.mAVTTextEdit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 262);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // sOLUONGTONSpinEdit
            // 
            this.sOLUONGTONSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVattu, "SOLUONGTON", true));
            this.sOLUONGTONSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sOLUONGTONSpinEdit.Location = new System.Drawing.Point(343, 94);
            this.sOLUONGTONSpinEdit.MenuManager = this.barManager1;
            this.sOLUONGTONSpinEdit.Name = "sOLUONGTONSpinEdit";
            this.sOLUONGTONSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sOLUONGTONSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.sOLUONGTONSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sOLUONGTONSpinEdit.Size = new System.Drawing.Size(104, 22);
            this.sOLUONGTONSpinEdit.TabIndex = 7;
            // 
            // dVTTextEdit
            // 
            this.dVTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVattu, "DVT", true));
            this.dVTTextEdit.Location = new System.Drawing.Point(105, 94);
            this.dVTTextEdit.MenuManager = this.barManager1;
            this.dVTTextEdit.Name = "dVTTextEdit";
            this.dVTTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dVTTextEdit.Properties.Appearance.Options.UseFont = true;
            this.dVTTextEdit.Size = new System.Drawing.Size(120, 22);
            this.dVTTextEdit.TabIndex = 5;
            // 
            // tENVTTextEdit
            // 
            this.tENVTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVattu, "TENVT", true));
            this.tENVTTextEdit.Location = new System.Drawing.Point(343, 47);
            this.tENVTTextEdit.MenuManager = this.barManager1;
            this.tENVTTextEdit.Name = "tENVTTextEdit";
            this.tENVTTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENVTTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tENVTTextEdit.Size = new System.Drawing.Size(173, 22);
            this.tENVTTextEdit.TabIndex = 3;
            // 
            // mAVTTextEdit
            // 
            this.mAVTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVattu, "MAVT", true));
            this.mAVTTextEdit.Location = new System.Drawing.Point(105, 46);
            this.mAVTTextEdit.MenuManager = this.barManager1;
            this.mAVTTextEdit.Name = "mAVTTextEdit";
            this.mAVTTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAVTTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mAVTTextEdit.Size = new System.Drawing.Size(120, 22);
            this.mAVTTextEdit.TabIndex = 1;
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "FK_CTPX_VatTu";
            this.bdsCTPX.DataSource = this.bdsVattu;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_VatTu";
            this.bdsCTPN.DataSource = this.bdsVattu;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTDH
            // 
            this.bdsCTDH.DataMember = "FK_CTDDH_VatTu";
            this.bdsCTDH.DataSource = this.bdsVattu;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // FormVattu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 618);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vattuGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormVattu";
            this.Text = "Quản lí vật tư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVattu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVattu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGTONSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENVTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAVTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbiThemVT;
        private DevExpress.XtraBars.BarButtonItem bbiXoaVT;
        private DevExpress.XtraBars.BarButtonItem bbiSuaVT;
        private DevExpress.XtraBars.BarButtonItem bbiPhuchoiVT;
        private DevExpress.XtraBars.BarButtonItem bbiReloadVT;
        private DevExpress.XtraBars.BarButtonItem bbiLuuVT;
        private DevExpress.XtraBars.BarButtonItem bbiThoatVT;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.BindingSource bdsVattu;
        private DS dS;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SpinEdit sOLUONGTONSpinEdit;
        private DevExpress.XtraEditors.TextEdit dVTTextEdit;
        private DevExpress.XtraEditors.TextEdit tENVTTextEdit;
        private DevExpress.XtraEditors.TextEdit mAVTTextEdit;
        private DevExpress.XtraGrid.GridControl vattuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private DSTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DSTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDH;
        private DSTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
    }
}