using System.ComponentModel.DataAnnotations;
using TLMEApp.Model.Schools;

namespace TLMEApp.Model.Users
{
    public class Staff : Person
    {
        [Key]
        public string StaffId { get; set; }
        public int? SchoolId { get; set; }
        public int? DepartmentId { get; set; }
        public School School { get; set; }
        public Department Department { get; set; }
    }
}
