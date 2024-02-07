using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Expense
{
    public class ExpenseDto
    {
        
        public int Id { get; set; }
            
        public string? CompanyName { get; set; } = string.Empty;
    
        public string ExpenseName { get; set; } = string.Empty;

        public decimal MonthlyPrice { get; set; }

        public bool ExpenseStatus{ get; set; } = true;

        public DateTime? CreatedOn { get; set; } = DateTime.Now;
    }
}