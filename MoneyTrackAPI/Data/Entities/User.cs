using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyTrackAPI.Entities
{
    [Table("m_users")]
    public class User : AuditTrail
    {
        [Key]
        [Column("id")]
        public string? Id { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("username")]
        public string? Username { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("password")]
        public string? Password { get; set; }
    }
}
