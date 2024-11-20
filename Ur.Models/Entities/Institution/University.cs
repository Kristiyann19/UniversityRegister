using Ur.Models.Entities.Base;
using Ur.Models.Entities.Nomenclatures;
using Ur.Models.Enums;

namespace Ur.Models.Entities.Institution
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

        public List<Faculty> Faculties { get; set; } = new List<Faculty>();
    }
}
