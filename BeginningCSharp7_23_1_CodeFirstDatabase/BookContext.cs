using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginningCSharp7_23_1_CodeFirstDatabase
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
