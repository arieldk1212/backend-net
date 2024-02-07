using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api.Data;
using api.Dtos.Expense;
using api.Mappers;

namespace api.Controllers
{
    [Route("api/expense")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ExpenseController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var expenses = _context.Expenses.ToList()
                .Select(s => s.ToExpenseDto());

            return Ok(expenses);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var expense = _context.Expenses.Find(id);
            
            if (expense == null) {
                return NotFound();
            }
            return Ok(expense.ToExpenseDto());
        }
    }
}