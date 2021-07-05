using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore_lesson1_2
{
    class MyContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        public MyContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AMANURLANUULU;Database=DbForLesson1;Trusted_Connection=True;");
        }
    }
}
