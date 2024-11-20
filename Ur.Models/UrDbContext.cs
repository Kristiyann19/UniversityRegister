using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Reflection;
using Ur.Models.Entities.Courses;
using Ur.Models.Entities.Institution;
using Ur.Models.Entities.Nomenclatures;
using Ur.Models.Entities.People;
using Ur.Models.Entities.People.Junctions;

namespace Ur.Models
{
    public class UrDbContext : DbContext
    {
        #region People
        DbSet<Dean> Deans { get; set; }
        DbSet<Rector> Rectors { get; set; }
        DbSet<Professor> Professors { get; set; }

        DbSet<ProfessorCourse> ProfessorCourses { get; set; }
        #endregion

        #region Nomenclatures
        DbSet<Settlement> Settlements { get; set; }
        #endregion

        #region Institutions
        DbSet<Faculty> Faculties { get; set; }
        DbSet<University> Universities { get; set; }
        #endregion

        #region Courses
        DbSet<Course> Courses { get; set; }
        #endregion

        public UrDbContext(DbContextOptions<UrDbContext> options)
            : base(options)
        {

        }

        public IDbContextTransaction BeginTransaction()
        {
            return Database.BeginTransaction();
        }

        protected void ApplyConfigurations(ModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                   .Where(t => t.GetInterfaces().Any(gi =>
                       gi.IsGenericType
                       && gi.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>)))
                   .ToList();

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);
            }
        }

        protected void ConfigurePgSqlNameMappings(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                // Configure pgsql table names convention.
                entity.SetTableName(entity.ClrType.Name.ToLower());

                // Configure pgsql column names convention.
                foreach (var property in entity.GetProperties())
                {
                    property.SetColumnName(property.Name.ToLower());
                }
            }
        }
    }
}
