using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TLMEApp.Model.Subjects;
using TLMEApp.Model.Users;

namespace TLMEApp.Model.Schools
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [StringLength(20, MinimumLength = 1)]
        public string DepartmentCode { get; set; }

        [StringLength(100, MinimumLength = 1)]
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Staff> Staffs { get; set; }
    }
}
