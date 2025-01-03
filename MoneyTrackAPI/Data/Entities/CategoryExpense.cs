using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyTrackAPI.Entities
{
    [Table("m_category_expense")]
    public class CategoryExpense
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
