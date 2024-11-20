using Ur.Models.Entities.Base;
using Ur.Models.Entities.Institution;

namespace Ur.Models.Entities.People
{
    public class Rector : Names
    {
        public int UniversityId { get; set; }
        public University University { get; set; }
    }
}
