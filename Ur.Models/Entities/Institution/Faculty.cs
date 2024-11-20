using Ur.Models.Entities.Base;

namespace Ur.Models.Entities.Institution
{
    public class Faculty : Entity
    {
        public string Name { get; set; }
        public string NameAlt { get; set; }

        public int UniversityId { get; set; }
        public University University { get; set; }

        public bool IsActive { get; set; }
    }
}
