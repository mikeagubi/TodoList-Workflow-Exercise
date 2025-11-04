using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyTodos.Data;
using MyTodos.Models;

namespace MyTodos.Pages.Admin.TodoAdmin
{
    public class DetailsModel : PageModel
    {
        private readonly MyTodos.Data.MyTodosContext _context;

        public DetailsModel(MyTodos.Data.MyTodosContext context)
        {
            _context = context;
        }

        public Todo Todo { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var todo = await _context.Todo.FirstOrDefaultAsync(m => m.Id == id);

            if (todo is not null)
            {
                Todo = todo;

                return Page();
            }

            return NotFound();
        }
    }
}
