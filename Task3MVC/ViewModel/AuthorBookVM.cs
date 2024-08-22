using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3MVC.Context;

namespace Task3MVC.ViewModel
{
    public class AuthorBookVM
    {
        public List<Book> Books { get; set; }
        public List<Author> Authors { get; set; }
    }
}
