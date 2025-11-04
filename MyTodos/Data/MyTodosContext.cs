using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyTodos.Models;

namespace MyTodos.Data
{
    public class MyTodosContext : DbContext
    {
        public MyTodosContext (DbContextOptions<MyTodosContext> options)
            : base(options)
        {
        }

        public DbSet<MyTodos.Models.Person> Person { get; set; } = default!;
        public DbSet<MyTodos.Models.Todo> Todo { get; set; } = default!;
    }
}
