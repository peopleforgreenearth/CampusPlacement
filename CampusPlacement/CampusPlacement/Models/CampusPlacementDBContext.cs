using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CampusPlacement.Models.Mapping;

namespace CampusPlacement.Models
{
    public partial class CampusPlacementDBContext : DbContext
    {
        static CampusPlacementDBContext()
        {
            Database.SetInitializer<CampusPlacementDBContext>(null);
        }

        public CampusPlacementDBContext()
            : base("Name=CampusPlacementDBContext")
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<ExperienceLevel> ExperienceLevels { get; set; }
        public DbSet<JobPosting> JobPostings { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<MyJob> MyJobs { get; set; }
        public DbSet<MyResume> MyResumes { get; set; }
        public DbSet<MySearch> MySearches { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<State> States { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CompanyMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new EducationLevelMap());
            modelBuilder.Configurations.Add(new ExperienceLevelMap());
            modelBuilder.Configurations.Add(new JobPostingMap());
            modelBuilder.Configurations.Add(new JobTypeMap());
            modelBuilder.Configurations.Add(new MyJobMap());
            modelBuilder.Configurations.Add(new MyResumeMap());
            modelBuilder.Configurations.Add(new MySearchMap());
            modelBuilder.Configurations.Add(new ResumeMap());
            modelBuilder.Configurations.Add(new StateMap());
        }
    }
}
