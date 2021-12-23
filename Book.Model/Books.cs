using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Model
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }
        public string  BookName { get; set; }

        //public Authors Author { get; set; }
        public int AuthorId { get; set; }
    }
}
