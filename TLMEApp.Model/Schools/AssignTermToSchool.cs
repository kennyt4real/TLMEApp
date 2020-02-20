using System;
using System.ComponentModel.DataAnnotations;

namespace TLMEApp.Model.Schools
{
    public class AssignTermToSchool
    {
        public int AssignTermToSchoolId { get; set; }
        public int TermId { get; set; }

        [StringLength(5, MinimumLength = 1)]
        public int SchoolId { get; set; }

        [StringLength(10, MinimumLength = 1)]
        public bool IsActiveTerm { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Term Semester { get; set; }
        public School School { get; set; }
    }
}
