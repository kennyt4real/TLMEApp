namespace TLMEApp.Model.Subjects
{
    public class LessonNote
    {
        public int LessonNoteId { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
