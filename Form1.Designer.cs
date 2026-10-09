namespace QuanLySinhVien
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblApp = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.lblDiem = new System.Windows.Forms.Label();
            this.nudDiem = new System.Windows.Forms.NumericUpDown();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.lblLocLop = new System.Windows.Forms.Label();
            this.cboLocLop = new System.Windows.Forms.ComboBox();
            this.lblDiemTu = new System.Windows.Forms.Label();
            this.nudDiemTu = new System.Windows.Forms.NumericUpDown();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnHienThiTatCa = new System.Windows.Forms.Button();
            this.pnlDanhSach = new System.Windows.Forms.Panel();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblBatBuoc = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRight = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlHeader.SuspendLayout();
            this.pnlThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiem)).BeginInit();
            this.pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemTu)).BeginInit();
            this.pnlDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(27, 63, 102);
            this.pnlHeader.Controls.Add(this.lblApp);
            this.pnlHeader.Controls.Add(this.lblLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1060, 38);
            this.pnlHeader.TabIndex = 0;
            //
            // lblLogo
            //
            this.lblLogo.BackColor = System.Drawing.Color.FromArgb(242, 133, 62);
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(16, 8);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(22, 22);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "S";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblApp
            //
            this.lblApp.AutoSize = true;
            this.lblApp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApp.ForeColor = System.Drawing.Color.White;
            this.lblApp.Location = new System.Drawing.Point(46, 6);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(209, 20);
            this.lblApp.TabIndex = 1;
            this.lblApp.Text = "Ứng dụng quản lý sinh viên";
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(27, 63, 102);
            this.lblTitle.Location = new System.Drawing.Point(14, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(265, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "QUẢN LÝ SINH VIÊN";
            //
            // lblSub
            //
            this.lblSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(70, 80, 95);
            this.lblSub.Location = new System.Drawing.Point(592, 56);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(450, 20);
            this.lblSub.TabIndex = 2;
            this.lblSub.Text = "Bài tập Windows Forms • Quan hệ SchoolClass 1 — n Student";
            this.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // pnlThongTin
            //
            this.pnlThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThongTin.BackColor = System.Drawing.Color.White;
            this.pnlThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThongTin.Controls.Add(this.pnlBar);
            this.pnlThongTin.Controls.Add(this.lblThongTin);
            this.pnlThongTin.Controls.Add(this.lblMaSV);
            this.pnlThongTin.Controls.Add(this.txtMaSV);
            this.pnlThongTin.Controls.Add(this.lblHoTen);
            this.pnlThongTin.Controls.Add(this.txtHoTen);
            this.pnlThongTin.Controls.Add(this.lblLop);
            this.pnlThongTin.Controls.Add(this.cboLop);
            this.pnlThongTin.Controls.Add(this.lblNgaySinh);
            this.pnlThongTin.Controls.Add(this.dtpNgaySinh);
            this.pnlThongTin.Controls.Add(this.lblGioiTinh);
            this.pnlThongTin.Controls.Add(this.rdoNam);
            this.pnlThongTin.Controls.Add(this.rdoNu);
            this.pnlThongTin.Controls.Add(this.lblDiem);
            this.pnlThongTin.Controls.Add(this.nudDiem);
            this.pnlThongTin.Controls.Add(this.lblEmail);
            this.pnlThongTin.Controls.Add(this.txtEmail);
            this.pnlThongTin.Controls.Add(this.lblDienThoai);
            this.pnlThongTin.Controls.Add(this.txtDienThoai);
            this.pnlThongTin.Controls.Add(this.lblTrangThai);
            this.pnlThongTin.Controls.Add(this.cboTrangThai);
            this.pnlThongTin.Controls.Add(this.pnlLine);
            this.pnlThongTin.Controls.Add(this.btnThem);
            this.pnlThongTin.Controls.Add(this.btnSua);
            this.pnlThongTin.Controls.Add(this.btnXoa);
            this.pnlThongTin.Controls.Add(this.btnLamMoi);
            this.pnlThongTin.Location = new System.Drawing.Point(18, 88);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(1024, 206);
            this.pnlThongTin.TabIndex = 3;
            //
            // pnlBar
            //
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(242, 133, 62);
            this.pnlBar.Location = new System.Drawing.Point(12, 12);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(4, 22);
            this.pnlBar.TabIndex = 0;
            //
            // lblThongTin
            //
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblThongTin.ForeColor = System.Drawing.Color.FromArgb(27, 63, 102);
            this.lblThongTin.Location = new System.Drawing.Point(22, 10);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(152, 20);
            this.lblThongTin.TabIndex = 1;
            this.lblThongTin.Text = "Thông tin sinh viên";
            //
            // lblMaSV
            //
            this.lblMaSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaSV.ForeColor = System.Drawing.Color.FromArgb(27, 63, 102);
            this.lblMaSV.Location = new System.Drawing.Point(6, 48);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(102, 23);
            this.lblMaSV.TabIndex = 2;
            this.lblMaSV.Text = "Mã sinh viên *";
            this.lblMaSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // txtMaSV
            //
            this.txtMaSV.Location = new System.Drawing.Point(114, 48);
            this.txtMaSV.MaxLength = 20;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(178, 23);
            this.txtMaSV.TabIndex = 3;
            //
            // lblHoTen
            //
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(27, 63, 102);
            this.lblHoTen.Location = new System.Drawing.Point(298, 48);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(84, 23);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Họ và tên *";
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // txtHoTen
            //
            this.txtHoTen.Location = new System.Drawing.Point(388, 48);
            this.txtHoTen.MaxLength = 100;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(186, 23);
            this.txtHoTen.TabIndex = 5;
            //
            // lblLop
            //
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLop.ForeColor = System.Drawing.Color.FromArgb(27, 63, 102);
            this.lblLop.Location = new System.Drawing.Point(580, 48);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(88, 23);
            this.lblLop.TabIndex = 6;
            this.lblLop.Text = "Lớp học *";
            this.lblLop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // cboLop
            //
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(674, 48);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(184, 23);
            this.cboLop.TabIndex = 7;
            //
            // lblNgaySinh
            //
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNgaySinh.ForeColor = System.Drawing.Color.FromArgb(27, 63, 102);
            this.lblNgaySinh.Location = new System.Drawing.Point(6, 84);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(102, 23);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Text = "Ngày sinh";
            this.lblNgaySinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // dtpNgaySinh
            //
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(114, 84);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(178, 23);
            this.dtpNgaySinh.TabIndex = 9;
            //
            // lblGioiTinh
            //
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGioiTinh.ForeColor = System.Drawing.Color.FromArgb(27, 63, 102);
            this.lblGioiTinh.Location = new System.Drawing.Point(298, 84);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(84, 23);
            this.lblGioiTinh.TabIndex = 10;
            this.lblGioiTinh.Text = "Giới tính";
            this.lblGioiTinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // rdoNam
            //
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Location = new System.Drawing.Point(388, 86);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(24, 19);
            this.rdoNam.TabIndex = 11;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            //
            // rdoNu
            //
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(462, 86);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(24, 19);
            this.rdoNu.TabIndex = 12;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            //
            // lblDiem
            //
            this.lblDiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiem.ForeColor = System.Drawing.Color.FromArgb(27, 63, 102);
            this.lblDiem.Location = new System.Drawing.Point(580, 84);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(88, 23);
            this.lblDiem.TabIndex = 13;
            this.lblDiem.Text = "Điểm *";
            this.lblDiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // nudDiem
            //
            this.nudDiem.Location = new System.Drawing.Point(674, 84);
            this.nudDiem.Name = "nudDiem";
            this.nudDiem.Size = new System.Drawing.Size(184, 23);
            this.nudDiem.TabIndex = 14;
            //
            // lblEmail
            //
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(27, 63, 102);
            this.lblEmail.Location = new System.Drawing.Point(6, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(102, 23);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email *";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // txtEmail
            //
            this.txtEmail.Location = new System.Drawing.Point(114, 120);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 23);
            this.txtEmail.TabIndex = 16;
            //
            // lblDienThoai
            //
            this.lblDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDienThoai.ForeColor = System.Drawing.Color.FromArgb(27, 63, 102);
            this.lblDienThoai.Location = new System.Drawing.Point(298, 120);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(84, 23);
            this.lblDienThoai.TabIndex = 17;
            this.lblDienThoai.Text = "Điện thoại *";
            this.lblDienThoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // txtDienThoai
            //
            this.txtDienThoai.Location = new System.Drawing.Point(388, 120);
            this.txtDienThoai.MaxLength = 15;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(186, 23);
            this.txtDienThoai.TabIndex = 18;
            //
            // lblTrangThai
            //
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(27, 63, 102);
            this.lblTrangThai.Location = new System.Drawing.Point(580, 120);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(88, 23);
            this.lblTrangThai.TabIndex = 19;
            this.lblTrangThai.Text = "Trạng thái";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // cboTrangThai
            //
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(674, 120);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(184, 23);
            this.cboTrangThai.TabIndex = 20;
            //
            // pnlLine
            //
            this.pnlLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(230, 235, 241);
            this.pnlLine.Location = new System.Drawing.Point(12, 158);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(998, 1);
            this.pnlLine.TabIndex = 21;
            //
            // btnThem
            //
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(46, 139, 106);
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(652, 166);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(76, 30);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            //
            // btnSua
            //
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(47, 110, 168);
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(736, 166);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(76, 30);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            //
            // btnXoa
            //
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(208, 72, 90);
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(820, 166);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(76, 30);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            //
            // btnLamMoi
            //
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(107, 122, 143);
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(904, 166);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(92, 30);
            this.btnLamMoi.TabIndex = 25;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            //
            // pnlTimKiem
            //
            this.pnlTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTimKiem.BackColor = System.Drawing.Color.White;
            this.pnlTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTimKiem.Controls.Add(this.lblTuKhoa);
            this.pnlTimKiem.Controls.Add(this.txtTuKhoa);
            this.pnlTimKiem.Controls.Add(this.lblLocLop);
            this.pnlTimKiem.Controls.Add(this.cboLocLop);
            this.pnlTimKiem.Controls.Add(this.lblDiemTu);
            this.pnlTimKiem.Controls.Add(this.nudDiemTu);
            this.pnlTimKiem.Controls.Add(this.btnTimKiem);
            this.pnlTimKiem.Controls.Add(this.btnHienThiTatCa);
            this.pnlTimKiem.Location = new System.Drawing.Point(18, 304);
            this.pnlTimKiem.Name = "pnlTimKiem";
            this.pnlTimKiem.Size = new System.Drawing.Size(1024, 52);
            this.pnlTimKiem.TabIndex = 4;
            //
            // lblTuKhoa
            //
            this.lblTuKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTuKhoa.ForeColor = System.Drawing.Color.FromArgb(27, 63, 102);
            this.lblTuKhoa.Location = new System.Drawing.Point(8, 14);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(62, 23);
            this.lblTuKhoa.TabIndex = 0;
            this.lblTuKhoa.Text = "Từ khóa";
            this.lblTuKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // txtTuKhoa
            //
            this.txtTuKhoa.Location = new System.Drawing.Point(76, 14);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(250, 23);
            this.txtTuKhoa.TabIndex = 1;
            this.txtTuKhoa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTuKhoa_KeyDown);
            //
            // lblLocLop
            //
            this.lblLocLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLocLop.ForeColor = System.Drawing.Color.FromArgb(27, 63, 102);
            this.lblLocLop.Location = new System.Drawing.Point(332, 14);
            this.lblLocLop.Name = "lblLocLop";
            this.lblLocLop.Size = new System.Drawing.Size(34, 23);
            this.lblLocLop.TabIndex = 2;
            this.lblLocLop.Text = "Lớp";
            this.lblLocLop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // cboLocLop
            //
            this.cboLocLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocLop.FormattingEnabled = true;
            this.cboLocLop.Location = new System.Drawing.Point(372, 14);
            this.cboLocLop.Name = "cboLocLop";
            this.cboLocLop.Size = new System.Drawing.Size(180, 23);
            this.cboLocLop.TabIndex = 3;
            //
            // lblDiemTu
            //
            this.lblDiemTu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiemTu.ForeColor = System.Drawing.Color.FromArgb(27, 63, 102);
            this.lblDiemTu.Location = new System.Drawing.Point(558, 14);
            this.lblDiemTu.Name = "lblDiemTu";
            this.lblDiemTu.Size = new System.Drawing.Size(62, 23);
            this.lblDiemTu.TabIndex = 4;
            this.lblDiemTu.Text = "Điểm từ";
            this.lblDiemTu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // nudDiemTu
            //
            this.nudDiemTu.Location = new System.Drawing.Point(626, 14);
            this.nudDiemTu.Name = "nudDiemTu";
            this.nudDiemTu.Size = new System.Drawing.Size(70, 23);
            this.nudDiemTu.TabIndex = 5;
            //
            // btnTimKiem
            //
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(47, 110, 168);
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(712, 11);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 29);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            //
            // btnHienThiTatCa
            //
            this.btnHienThiTatCa.BackColor = System.Drawing.Color.FromArgb(234, 243, 251);
            this.btnHienThiTatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHienThiTatCa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(150, 185, 215);
            this.btnHienThiTatCa.FlatAppearance.BorderSize = 1;
            this.btnHienThiTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThiTatCa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHienThiTatCa.ForeColor = System.Drawing.Color.FromArgb(27, 63, 102);
            this.btnHienThiTatCa.Location = new System.Drawing.Point(812, 11);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(120, 29);
            this.btnHienThiTatCa.TabIndex = 7;
            this.btnHienThiTatCa.Text = "Hiển thị tất cả";
            this.btnHienThiTatCa.UseVisualStyleBackColor = false;
            this.btnHienThiTatCa.Click += new System.EventHandler(this.btnHienThiTatCa_Click);
            //
            // pnlDanhSach
            //
            this.pnlDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDanhSach.BackColor = System.Drawing.Color.White;
            this.pnlDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDanhSach.Controls.Add(this.lblDanhSach);
            this.pnlDanhSach.Controls.Add(this.lblTong);
            this.pnlDanhSach.Controls.Add(this.dgvSinhVien);
            this.pnlDanhSach.Controls.Add(this.lblHint);
            this.pnlDanhSach.Controls.Add(this.lblBatBuoc);
            this.pnlDanhSach.Location = new System.Drawing.Point(18, 366);
            this.pnlDanhSach.Name = "pnlDanhSach";
            this.pnlDanhSach.Size = new System.Drawing.Size(1024, 262);
            this.pnlDanhSach.TabIndex = 5;
            //
            // lblDanhSach
            //
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDanhSach.ForeColor = System.Drawing.Color.FromArgb(27, 63, 102);
            this.lblDanhSach.Location = new System.Drawing.Point(12, 10);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(150, 20);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "Danh sách sinh viên";
            //
            // lblTong
            //
            this.lblTong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTong.BackColor = System.Drawing.Color.FromArgb(226, 244, 236);
            this.lblTong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTong.ForeColor = System.Drawing.Color.FromArgb(30, 110, 80);
            this.lblTong.Location = new System.Drawing.Point(884, 9);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(126, 26);
            this.lblTong.TabIndex = 1;
            this.lblTong.Text = "Tổng số: 0 sinh viên";
            this.lblTong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // dgvSinhVien
            //
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.AllowUserToResizeRows = false;
            this.dgvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 44);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(1022, 178);
            this.dgvSinhVien.TabIndex = 2;
            this.dgvSinhVien.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvSinhVien_CellPainting);
            this.dgvSinhVien.SelectionChanged += new System.EventHandler(this.dgvSinhVien_SelectionChanged);
            //
            // lblHint
            //
            this.lblHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHint.AutoSize = true;
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(90, 100, 115);
            this.lblHint.Location = new System.Drawing.Point(12, 232);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(318, 15);
            this.lblHint.TabIndex = 3;
            this.lblHint.Text = "Chọn một dòng để xem, sửa hoặc xóa thông tin sinh viên.";
            //
            // lblBatBuoc
            //
            this.lblBatBuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBatBuoc.ForeColor = System.Drawing.Color.FromArgb(90, 100, 115);
            this.lblBatBuoc.Location = new System.Drawing.Point(750, 232);
            this.lblBatBuoc.Name = "lblBatBuoc";
            this.lblBatBuoc.Size = new System.Drawing.Size(260, 18);
            this.lblBatBuoc.TabIndex = 4;
            this.lblBatBuoc.Text = "Các trường có dấu * là bắt buộc.";
            this.lblBatBuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // statusStrip1
            //
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(240, 243, 247);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslLeft,
            this.tsslRight});
            this.statusStrip1.Location = new System.Drawing.Point(0, 638);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1060, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            //
            // tsslLeft
            //
            this.tsslLeft.Name = "tsslLeft";
            this.tsslLeft.Size = new System.Drawing.Size(311, 17);
            this.tsslLeft.Text = "Bài tập: xây dựng Windows Forms quản lý sinh viên theo lớp";
            //
            // tsslRight
            //
            this.tsslRight.Name = "tsslRight";
            this.tsslRight.Size = new System.Drawing.Size(734, 17);
            this.tsslRight.Spring = true;
            this.tsslRight.Text = "Thêm • Sửa • Xóa • Tìm kiếm • Lọc theo lớp";
            this.tsslRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 246, 250);
            this.ClientSize = new System.Drawing.Size(1060, 660);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlDanhSach);
            this.Controls.Add(this.pnlTimKiem);
            this.Controls.Add(this.pnlThongTin);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng dụng quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiem)).EndInit();
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemTu)).EndInit();
            this.pnlDanhSach.ResumeLayout(false);
            this.pnlDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.NumericUpDown nudDiem;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlTimKiem;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label lblLocLop;
        private System.Windows.Forms.ComboBox cboLocLop;
        private System.Windows.Forms.Label lblDiemTu;
        private System.Windows.Forms.NumericUpDown nudDiemTu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnHienThiTatCa;
        private System.Windows.Forms.Panel pnlDanhSach;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblBatBuoc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslLeft;
        private System.Windows.Forms.ToolStripStatusLabel tsslRight;
    }
}
