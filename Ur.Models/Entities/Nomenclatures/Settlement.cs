using Ur.Models.Entities.Base;

namespace Ur.Models.Entities.Nomenclatures
{
    public class Settlement : Entity
    {
        public string Name { get; set; }
        public string NameAlt { get; set; }
        public bool IsActive { get; set; }
    }
}
