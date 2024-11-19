using Ur.Models.Entities.Base;

namespace Ur.Models.Entities
{
    public class ProfessorUniversity : Entity
    {
        //public PositionEnum Position { get; set; }

        public int PersonId { get; set; }

        public Professor Professor { get; set; }

        public int UniversityId { get; set; }

        public University University { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
