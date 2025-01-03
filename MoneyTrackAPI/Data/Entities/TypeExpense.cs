using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyTrackAPI.Entities
{
    [Table("m_type_expense")]
    public class TypeExpense : AuditTrail
    {
        [Key]
        [Column("id")]
        public string? Id { get; set; }

        [Column("code")]
        public string? Code { get; set; }

        [Column("name")]
        public string? Name { get; set; }
    }
}
