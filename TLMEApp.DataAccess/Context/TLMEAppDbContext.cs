using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TLMEApp.Model.Schools;
using TLMEApp.Model.Subjects;
using TLMEApp.Model.Users;

namespace TLMEApp.DataAccess.Context
{
    public class TLMEAppDbContext : IdentityDbContext<ApplicationUser>
    {
        public TLMEAppDbContext(DbContextOptions<TLMEAppDbContext> options) : base(options)
        {

        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<LessonNote> LessonNotes { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Term> Terms { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<AssignSubjectToStaff> AssignSubjectToStaffs { get; set; }
        public DbSet<AssignTermToSchool> AssignTermToSchools { get; set; } 
        public DbSet<AssignSessionToSchool> AssignSessionToSchools { get; set; }
    }
}
