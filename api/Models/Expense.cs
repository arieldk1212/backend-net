using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Expense
    {
        public int ID { get; set; }

        [Display(Name = "Expense Company Name")]
        [StringLength(50)]
        public string? CompanyName { get; set; } = string.Empty;

        [Required]
        [Column("ExpenseName")]
        [Display(Name = "Expense Name")]
        [StringLength(50)]
        public string ExpenseName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Expense Monthly Price")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal MonthlyPrice { get; set; }


        public bool ExpenseStatus{ get; set; } = true;

        public DateTime? CreatedOn { get; set; } = DateTime.Now;
    }
}