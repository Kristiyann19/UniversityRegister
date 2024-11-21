using System.ComponentModel;

namespace Ur.Models.Enums.Common
{
    [Description("Добавени модели към конструирана заявка")]
    public enum IncludeType
    {
        [Description("Всички")]
        All = 1,

        [Description("Обекти")]
        NavProperties = 2,

        [Description("Колекции")]
        Collections = 3,

        [Description("Нищо")]
        None = 4
    }
}
