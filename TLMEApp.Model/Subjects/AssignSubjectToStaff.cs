using TLMEApp.Model.Users;

namespace TLMEApp.Model.Subjects
{
    public class AssignSubjectToStaff
    {
        public int AssignSubjectToStaffId { get; set; }
        public int SubjectId { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public Subject Subject { get; set; }
    }
}
