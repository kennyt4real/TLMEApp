using System;
using System.ComponentModel.DataAnnotations;

namespace TLMEApp.Model.Schools
{
    public class AssignSessionToSchool
    {
        public int AssignSessionToSchoolId { get; set; }
        public int SessionId { get; set; }
        public int SchoolId { get; set; }
        [StringLength(10, MinimumLength = 1)]
        public bool IsActiveSession { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Session Session { get; set; }
        public School School { get; set; }
    }
}
