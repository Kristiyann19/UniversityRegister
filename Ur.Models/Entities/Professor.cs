using Ur.Models.Entities.Base;

namespace Ur.Models.Entities
{
    public class Professor : Entity
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Uic { get; set; }

        public DateTime BirthDate { get; set; }

        public int BirthPlaceId { get; set; }

        public Settlement BirthPlace { get; set; }

        public int? UniversityId { get; set; }

        public University University { get; set; }
    }
}
