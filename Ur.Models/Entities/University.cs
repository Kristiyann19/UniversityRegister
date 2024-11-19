using Ur.Models.Entities.Base;
using Ur.Models.Enums;

namespace Ur.Models.Entities
{
    public class University : Entity
    {
        public string Name { get; set; }

        public string NameAlt { get; set; }

        public int SettlementId { get; set; }

        public Settlement Settlement { get; set; }

        public string Address { get; set; }

        public string Website { get; set; }

        public bool IsActive { get; set; }

        public UniversityType Type { get; set; }
    }
}
