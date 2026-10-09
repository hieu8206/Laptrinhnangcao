using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        // ===== Dữ liệu lưu trong bộ nhớ (tắt chương trình là mất) =====
        private readonly List<SchoolClass> _classes = new List<SchoolClass>();
        private readonly List<Student> _students = new List<Student>();

        // true khi đang nạp lại bảng, để SelectionChanged không ghi đè form
        private bool _binding;

        // Hiện chữ gợi ý (placeholder) trong ô Từ khóa
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);
        private const int EM_SETCUEBANNER = 0x1501;

        public Form1()
        {
            InitializeComponent();
        }

        // =====================================================================
        //  KHỞI TẠO
        // =====================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            SeedData();
            SetupControls();
            SetupGrid();
            StyleGrid();
            ApplyFilter(null);

            // Giống ảnh: chọn sẵn dòng đầu tiên
            if (_students.Count > 0)
            {
                SelectRow(_students[0]);
            }
        }

        private void SeedData()
        {
            SchoolClass se = new SchoolClass { Id = 1, Name = "Kỹ thuật phần mềm 01" };
            SchoolClass ai = new SchoolClass { Id = 2, Name = "Trí tuệ nhân tạo 01" };
            SchoolClass ds = new SchoolClass { Id = 3, Name = "Khoa học dữ liệu 01" };
            _classes.Add(se);
            _classes.Add(ai);
            _classes.Add(ds);

            AddSeed("SV000123", "Nguyễn Văn An", new DateTime(2006, 8, 15), "Nam", "an.nv@vju.ac.vn", "0912345678", 8.5m, se);
            AddSeed("SV000124", "Trần Minh Anh", new DateTime(2006, 1, 22), "Nữ", "anh.tm@vju.ac.vn", "0987654321", 9.0m, ai);
            AddSeed("SV000125", "Lê Hoàng Bình", new DateTime(2006, 5, 9), "Nam", "binh.lh@vju.ac.vn", "0355556677", 7.4m, se);
            AddSeed("SV000126", "Đỗ Thị Hồng", new DateTime(2006, 11, 30), "Nữ", "hong.dt@vju.ac.vn", "0777888999", 8.1m, ds);
        }

        private void AddSeed(string id, string name, DateTime dob, string gender,
                             string email, string phone, decimal score, SchoolClass cls)
        {
            Student s = new Student
            {
                StudentId = id,
                FullName = name,
                BirthDate = dob,
                Gender = gender,
                Email = email,
                Phone = phone,
                Score = score,
                Status = "Đang học",
                SchoolClass = cls
            };
            _students.Add(s);
            cls.Students.Add(s);
        }

        private void SetupControls()
        {
            // Combobox chọn lớp trong form nhập liệu
            cboLop.DisplayMember = nameof(SchoolClass.Name);
            cboLop.DataSource = _classes.ToList();

            // Combobox lọc lớp (thêm mục "Tất cả lớp" ở đầu)
            List<SchoolClass> filterList = new List<SchoolClass>();
            filterList.Add(new SchoolClass { Id = 0, Name = "Tất cả lớp" });
            filterList.AddRange(_classes);
            cboLocLop.DisplayMember = nameof(SchoolClass.Name);
            cboLocLop.DataSource = filterList;

            cboTrangThai.Items.AddRange(new object[] { "Đang học", "Bảo lưu", "Thôi học", "Đã tốt nghiệp" });
            cboTrangThai.SelectedIndex = 0;

            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Value = DateTime.Today;
            dtpNgaySinh.MaxDate = DateTime.Today;   // không cho chọn ngày sinh ở tương lai

            foreach (NumericUpDown nud in new NumericUpDown[] { nudDiem, nudDiemTu })
            {
                nud.DecimalPlaces = 1;
                nud.Increment = 0.1m;
                nud.Minimum = 0;
                nud.Maximum = 10;
            }

            rdoNam.Checked = true;

            SendMessage(txtTuKhoa.Handle, EM_SETCUEBANNER, IntPtr.Zero, "Mã, họ tên, email hoặc điện thoại");
        }

        private void SetupGrid()
        {
            dgvSinhVien.AutoGenerateColumns = false;
            dgvSinhVien.Columns.Clear();

            AddColumn("Mã SV", nameof(Student.StudentId), 80, null);
            AddColumn("Họ và tên", nameof(Student.FullName), 140, null);
            AddColumn("Ngày sinh", nameof(Student.BirthDate), 90, "dd/MM/yyyy");
            AddColumn("Giới tính", nameof(Student.Gender), 70, null);
            AddColumn("Email", nameof(Student.Email), 170, null);
            AddColumn("Điện thoại", nameof(Student.Phone), 100, null);
            AddColumn("Điểm", nameof(Student.Score), 55, "0.0");
            AddColumn("Lớp", nameof(Student.ClassName), 150, null);
            AddColumn("Trạng thái", nameof(Student.Status), 100, null);
        }

        private void AddColumn(string header, string property, float weight, string format)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = header;
            col.DataPropertyName = property;
            col.FillWeight = weight;
            col.MinimumWidth = 40;
            col.SortMode = DataGridViewColumnSortMode.NotSortable;
            if (format != null)
            {
                col.DefaultCellStyle.Format = format;
            }
            dgvSinhVien.Columns.Add(col);
        }

        private void StyleGrid()
        {
            Color navy = Color.FromArgb(27, 63, 102);

            dgvSinhVien.EnableHeadersVisualStyles = false;
            dgvSinhVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSinhVien.ColumnHeadersHeight = 38;

            DataGridViewCellStyle head = dgvSinhVien.ColumnHeadersDefaultCellStyle;
            head.BackColor = Color.FromArgb(232, 240, 250);
            head.ForeColor = navy;
            head.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            head.SelectionBackColor = head.BackColor;
            head.SelectionForeColor = head.ForeColor;
            head.Alignment = DataGridViewContentAlignment.MiddleLeft;
            head.Padding = new Padding(6, 0, 0, 0);

            dgvSinhVien.RowTemplate.Height = 34;
            dgvSinhVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSinhVien.GridColor = Color.FromArgb(230, 235, 241);

            DataGridViewCellStyle cell = dgvSinhVien.DefaultCellStyle;
            cell.BackColor = Color.White;
            cell.ForeColor = Color.FromArgb(60, 70, 85);
            cell.SelectionBackColor = Color.FromArgb(219, 235, 248);
            cell.SelectionForeColor = navy;
            cell.Padding = new Padding(6, 0, 0, 0);
        }

        // =====================================================================
        //  HIỂN THỊ / LỌC / CHỌN DÒNG
        // =====================================================================
        private static bool Has(string source, string keyword)
        {
            return source != null && source.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        // keep: sinh viên cần chọn lại sau khi nạp bảng (null = không chọn dòng nào)
        private void ApplyFilter(Student keep)
        {
            string kw = txtTuKhoa.Text.Trim();
            SchoolClass cls = cboLocLop.SelectedItem as SchoolClass;
            decimal minScore = nudDiemTu.Value;

            List<Student> result = _students.Where(s =>
                    (kw.Length == 0
                        || Has(s.StudentId, kw)
                        || Has(s.FullName, kw)
                        || Has(s.Email, kw)
                        || Has(s.Phone, kw))
                    && (cls == null || cls.Id == 0 || ReferenceEquals(s.SchoolClass, cls))
                    && s.Score >= minScore)
                .ToList();

            _binding = true;
            try
            {
                dgvSinhVien.DataSource = result;
                dgvSinhVien.ClearSelection();
                dgvSinhVien.CurrentCell = null;
            }
            finally
            {
                _binding = false;
            }

            lblTong.Text = "Tổng số: " + result.Count + " sinh viên";

            if (keep != null)
            {
                SelectRow(keep);
            }
        }

        private Student GetSelected()
        {
            if (dgvSinhVien.SelectedRows.Count == 0)
            {
                return null;
            }
            return dgvSinhVien.SelectedRows[0].DataBoundItem as Student;
        }

        private void SelectRow(Student s)
        {
            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                if (ReferenceEquals(row.DataBoundItem, s))
                {
                    dgvSinhVien.CurrentCell = row.Cells[0];
                    row.Selected = true;
                    return;
                }
            }
        }

        // Bấm vào dòng nào thì đổ dữ liệu dòng đó lên form
        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (_binding)
            {
                return;
            }
            Student s = GetSelected();
            if (s != null)
            {
                ShowStudent(s);
            }
        }

        private void ShowStudent(Student s)
        {
            txtMaSV.Text = s.StudentId;
            txtHoTen.Text = s.FullName;

            DateTime d = s.BirthDate;
            if (d > dtpNgaySinh.MaxDate) d = dtpNgaySinh.MaxDate;
            if (d < dtpNgaySinh.MinDate) d = dtpNgaySinh.MinDate;
            dtpNgaySinh.Value = d;

            rdoNam.Checked = s.Gender == "Nam";
            rdoNu.Checked = s.Gender != "Nam";
            txtEmail.Text = s.Email;
            txtDienThoai.Text = s.Phone;
            nudDiem.Value = Math.Max(nudDiem.Minimum, Math.Min(nudDiem.Maximum, s.Score));
            cboLop.SelectedItem = s.SchoolClass;
            cboTrangThai.SelectedItem = s.Status;
        }

        // =====================================================================
        //  TÌM KIẾM
        // =====================================================================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ApplyFilter(GetSelected());
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ApplyFilter(GetSelected());
            }
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            txtTuKhoa.Clear();
            cboLocLop.SelectedIndex = 0;
            nudDiemTu.Value = 0;
            ApplyFilter(GetSelected());
        }

        // =====================================================================
        //  THÊM / SỬA / XÓA / LÀM MỚI
        // =====================================================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(null))
            {
                return;
            }

            Student s = new Student();
            FillStudentFromForm(s);
            _students.Add(s);
            s.SchoolClass.Students.Add(s);

            ApplyFilter(null);
            ClearForm();
            Info("Đã thêm sinh viên mới.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Student s = GetSelected();
            if (s == null)
            {
                Info("Hãy chọn một sinh viên trong danh sách để sửa.");
                return;
            }
            if (!ValidateInput(s))
            {
                return;
            }

            if (s.SchoolClass != null)
            {
                s.SchoolClass.Students.Remove(s);   // bỏ khỏi lớp cũ
            }
            FillStudentFromForm(s);
            s.SchoolClass.Students.Add(s);          // thêm vào lớp mới

            ApplyFilter(s);
            Info("Đã cập nhật thông tin sinh viên.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Student s = GetSelected();
            if (s == null)
            {
                Info("Hãy chọn một sinh viên trong danh sách để xóa.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Xóa sinh viên " + s.FullName + " (" + s.StudentId + ")?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            if (s.SchoolClass != null)
            {
                s.SchoolClass.Students.Remove(s);
            }
            _students.Remove(s);

            ApplyFilter(null);
            ClearForm();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // =====================================================================
        //  HÀM HỖ TRỢ
        // =====================================================================
        private void FillStudentFromForm(Student s)
        {
            s.StudentId = txtMaSV.Text.Trim();
            s.FullName = txtHoTen.Text.Trim();
            s.BirthDate = dtpNgaySinh.Value.Date;
            s.Gender = rdoNam.Checked ? "Nam" : "Nữ";
            s.Email = txtEmail.Text.Trim();
            s.Phone = txtDienThoai.Text.Trim();
            s.Score = nudDiem.Value;
            s.SchoolClass = (SchoolClass)cboLop.SelectedItem;
            s.Status = cboTrangThai.SelectedItem != null ? cboTrangThai.SelectedItem.ToString() : "Đang học";
        }

        // editing = null khi thêm mới, = sinh viên đang sửa khi cập nhật
        private bool ValidateInput(Student editing)
        {
            string id = txtMaSV.Text.Trim();

            if (id.Length == 0)
            {
                return Warn("Vui lòng nhập mã sinh viên.", txtMaSV);
            }

            bool duplicate = _students.Any(x =>
                !ReferenceEquals(x, editing)
                && string.Equals(x.StudentId, id, StringComparison.OrdinalIgnoreCase));
            if (duplicate)
            {
                return Warn("Mã sinh viên \"" + id + "\" đã tồn tại.\n"
                          + "Nếu muốn thêm sinh viên mới, hãy bấm \"Làm mới\" rồi nhập lại.", txtMaSV);
            }

            if (txtHoTen.Text.Trim().Length == 0)
            {
                return Warn("Vui lòng nhập họ và tên.", txtHoTen);
            }
            if (cboLop.SelectedItem == null)
            {
                return Warn("Vui lòng chọn lớp học.", cboLop);
            }
            if (!Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return Warn("Email không hợp lệ.", txtEmail);
            }
            if (!Regex.IsMatch(txtDienThoai.Text.Trim(), @"^0\d{9}$"))
            {
                return Warn("Số điện thoại phải gồm 10 chữ số và bắt đầu bằng số 0.", txtDienThoai);
            }
            return true;
        }

        private static bool Warn(string message, Control focusTo)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            focusTo.Focus();
            return false;
        }

        private static void Info(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearForm()
        {
            // Bỏ chọn dòng trên bảng (không để SelectionChanged đổ lại dữ liệu cũ)
            _binding = true;
            try
            {
                dgvSinhVien.ClearSelection();
                dgvSinhVien.CurrentCell = null;
            }
            finally
            {
                _binding = false;
            }

            txtMaSV.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            rdoNam.Checked = true;
            txtEmail.Clear();
            txtDienThoai.Clear();
            nudDiem.Value = 0;
            if (cboLop.Items.Count > 0)
            {
                cboLop.SelectedIndex = 0;
            }
            cboTrangThai.SelectedIndex = 0;
            txtMaSV.Focus();
        }

        // =====================================================================
        //  VẼ NHÃN "TRẠNG THÁI" DẠNG VIÊN THUỐC (PILL) GIỐNG TRONG ẢNH
        // =====================================================================
        private void dgvSinhVien_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            if (dgvSinhVien.Columns[e.ColumnIndex].DataPropertyName != nameof(Student.Status))
            {
                return;
            }

            e.PaintBackground(e.CellBounds, true);

            string text = Convert.ToString(e.FormattedValue) ?? "";
            Color back;
            Color fore;
            switch (text)
            {
                case "Đang học":
                    back = Color.FromArgb(220, 240, 232);
                    fore = Color.FromArgb(30, 110, 80);
                    break;
                case "Bảo lưu":
                    back = Color.FromArgb(253, 240, 213);
                    fore = Color.FromArgb(150, 100, 10);
                    break;
                case "Thôi học":
                    back = Color.FromArgb(250, 224, 228);
                    fore = Color.FromArgb(170, 40, 60);
                    break;
                default:
                    back = Color.FromArgb(220, 232, 248);
                    fore = Color.FromArgb(40, 90, 150);
                    break;
            }

            Graphics g = e.Graphics;
            using (Font font = new Font("Segoe UI", 8.5F, FontStyle.Bold))
            {
                Size size = TextRenderer.MeasureText(g, text, font);
                Rectangle rect = new Rectangle(
                    e.CellBounds.X + 6,
                    e.CellBounds.Y + (e.CellBounds.Height - 22) / 2,
                    size.Width + 16,
                    22);

                SmoothingMode oldMode = g.SmoothingMode;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = RoundedRect(rect, 11))
                using (SolidBrush brush = new SolidBrush(back))
                {
                    g.FillPath(brush, path);
                }
                g.SmoothingMode = oldMode;

                TextRenderer.DrawText(g, text, font, rect, fore,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }

            e.Handled = true;
        }

        private static GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            int d = radius * 2;
            GraphicsPath p = new GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }
    }
}
