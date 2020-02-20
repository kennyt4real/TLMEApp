using System.ComponentModel.DataAnnotations;
using TLMEApp.Model.Schools;

namespace TLMEApp.Model.Users
{
    public class Student
    {
        [Key]
        public string StudentId { get; set; }
        public int SchoolId { get; set; }
        public bool IsGraduated { get; set; }
        public string StudentStatus { get; set; }
        public School School { get; set; }
    }
}
