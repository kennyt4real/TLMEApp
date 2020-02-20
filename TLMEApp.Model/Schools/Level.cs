using System.Collections.Generic;
using TLMEApp.Model.Subjects;

namespace TLMEApp.Model.Schools
{
    public class Level
    {
        public int LevelId { get; set; }
        public string LevelName { get; set; }
        public ICollection<Subject> Subjects { get; set; }
    }
}
