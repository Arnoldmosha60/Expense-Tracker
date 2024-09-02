using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public string TransactionId {  get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Note { get; set; }

        public int Amount { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
