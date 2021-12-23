using Book.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Database.Repo
{

    public interface IBookRepository : IRepository<Books>
    {

    }

    public class BookRepository : Repository<Books>, IBookRepository
    {
        public BookRepository(BookDbContex context) : base(context)
        {

        }
    }
}
