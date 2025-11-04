using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyTodos.Data;
using MyTodos.Models;

namespace MyTodos.Pages.Admin.PersonAdmin
{
    public class IndexModel : PageModel
    {
        private readonly MyTodos.Data.MyTodosContext _context;

        public IndexModel(MyTodos.Data.MyTodosContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Person.ToListAsync();
        }
    }
}
