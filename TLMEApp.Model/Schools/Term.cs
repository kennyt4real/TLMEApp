using System.Collections.Generic;

namespace TLMEApp.Model.Schools
{
    public class Term
    {
        public int TermId { get; set; }
        public string TermName { get; set; }
        public ICollection<AssignTermToSchool> AssignTermToSchools { get; set; }
    }
}
