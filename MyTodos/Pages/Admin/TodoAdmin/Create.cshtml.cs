using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyTodos.Data;
using MyTodos.Models;

namespace MyTodos.Pages.Admin.TodoAdmin
{
    public class CreateModel : PageModel
    {
        private readonly MyTodos.Data.MyTodosContext _context;

        public CreateModel(MyTodos.Data.MyTodosContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PersonId"] = new SelectList(_context.Person, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Todo Todo { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Todo.Add(Todo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
