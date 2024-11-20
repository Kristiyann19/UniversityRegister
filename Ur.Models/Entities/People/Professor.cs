using Ur.Models.Entities.Base;
using Ur.Models.Entities.Institution;
using Ur.Models.Entities.Nomenclatures;

namespace Ur.Models.Entities.People
{
    public class Professor : Names
    {
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
    }
}
