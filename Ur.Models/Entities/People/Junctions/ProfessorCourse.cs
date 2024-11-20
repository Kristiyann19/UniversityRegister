using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Ur.Models.Entities.Base;
using Ur.Models.Entities.Courses;
using Ur.Models.Entities.People;

namespace Ur.Models.Entities.People.Junctions
{
    public class ProfessorCourse : Entity
    {
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public class SupplierOfferingEquipmentConfiguration : IEntityTypeConfiguration<ProfessorCourse>
        {
            public void Configure(EntityTypeBuilder<ProfessorCourse> builder)
            {
                builder.HasIndex(e => new { e.ProfessorId, e.CourseId })
                    .IsUnique();
            }
        }
    }
}
