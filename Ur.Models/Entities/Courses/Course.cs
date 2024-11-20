using Ur.Models.Entities.Base;
using Ur.Models.Entities.People.Junctions;

namespace Ur.Models.Entities.Courses
{
    public class Course : Entity
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<ProfessorCourse> ProfessorsCourses { get; set; } = new List<ProfessorCourse>();
    }
}
