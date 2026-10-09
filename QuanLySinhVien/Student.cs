using System;

namespace QuanLySinhVien
{
    // Sinh viên: mỗi sinh viên thuộc đúng 1 lớp (quan hệ n - 1)
    public class Student
    {
        public string StudentId { get; set; } = "";
        public string FullName { get; set; } = "";
        public DateTime BirthDate { get; set; } = DateTime.Today;
        public string Gender { get; set; } = "Nam";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public decimal Score { get; set; }
        public string Status { get; set; } = "Đang học";

        public SchoolClass SchoolClass { get; set; }

        // Dùng để hiển thị cột "Lớp" trên bảng
        public string ClassName
        {
            get { return SchoolClass != null ? SchoolClass.Name : ""; }
        }
    }
}
