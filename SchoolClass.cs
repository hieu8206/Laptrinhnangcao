using System.Collections.Generic;

namespace QuanLySinhVien
{
    // Lớp học: 1 lớp có nhiều sinh viên (quan hệ 1 - n)
    public class SchoolClass
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public List<Student> Students { get; set; } = new List<Student>();

        public override string ToString()
        {
            return Name;
        }
    }
}
