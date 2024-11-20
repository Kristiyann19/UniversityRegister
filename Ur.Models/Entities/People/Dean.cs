using Ur.Models.Entities.Base;
using Ur.Models.Entities.Institution;

namespace Ur.Models.Entities.People
{
    public class Dean : Names
    {
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
    }
}
