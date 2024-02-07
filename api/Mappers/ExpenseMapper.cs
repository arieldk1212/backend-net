using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Expense;
using api.Models;

namespace api.Mappers
{
    public static class ExpenseMapper
    {
        public static ExpenseDto ToExpenseDto(this Expense expenseModel)
        {
            return new ExpenseDto
            {
                Id = expenseModel.Id,
                CompanyName = expenseModel.CompanyName,
                MonthlyPrice = expenseModel.MonthlyPrice,
                ExpenseStatus = expenseModel.ExpenseStatus
            };
        }
    }
}