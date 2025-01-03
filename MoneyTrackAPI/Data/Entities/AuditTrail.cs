using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyTrackAPI.Entities
{
    public class AuditTrail
    {
        [Column("created_date")]
        public DateTime? CreatedDate { get; set; }
        [Column("updated_date")]
        public DateTime? UpdatedDate { get; set; }
        [Column("deleted")]
        public char? Deleted { get; set; } = '0';
    }
}
