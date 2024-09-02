using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public int CategoryId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Title { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Icon { get; set; } = "";

        [Column(TypeName = "varchar(50)")]
        public string Type { get; set; } = "Expense";
    }
}
