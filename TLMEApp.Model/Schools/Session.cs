using System.Collections.Generic;

namespace TLMEApp.Model.Schools
{
    public class Session
    {
        public int SessionId { get; set; }
        public string SessionName { get; set; }
        public ICollection<AssignSessionToSchool> AssignSessionToSchools { get; set; }
    }
}
