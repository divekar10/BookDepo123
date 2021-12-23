using Book.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Database
{
    public class BookDbContex : DbContext
    {
        public BookDbContex(DbContextOptions options ) : base(options)
        {

        }

        public DbSet<Books> Books { get; set; }
        public DbSet<Authors> Authors { get; set; }
    }
}
