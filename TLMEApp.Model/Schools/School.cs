using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TLMEApp.Model.Users;

namespace TLMEApp.Model.Schools
{
    public class School
    {
        public int SchoolId { get; set; }
        [StringLength(20, MinimumLength = 1)]
        public string SchoolCode { get; set; }
        [StringLength(150, MinimumLength = 1)]
        public string SchoolName { get; set; }
        public string Description { get; set; }
        public string SchooType { get; set; }
        public string SchoolCategory { get; set; }
        public string State { get; set; }
        public string Lga { get; set; }
        public string Town { get; set; }
        public string Address { get; set; }
        public bool IsEnabled { get; set; }
        public byte[] Schoologo { get; set; }
        public ICollection<Staff> Staffs { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
