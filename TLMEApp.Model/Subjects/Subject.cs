using System.Collections.Generic;
using TLMEApp.Model.Schools;

namespace TLMEApp.Model.Subjects
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public int DepartmentId { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public Department Department { get; set; }
        public ICollection<LessonNote> LessonNotes { get; set; }
    }
}
