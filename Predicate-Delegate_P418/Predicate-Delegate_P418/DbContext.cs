using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_Delegate_P418
{
    public static class DbContext
    {
        public static List<Book> Books()
        {
            return new List<Book>
            {
                new Book {Id = 1, AuthorName = "Nizami", BookDescription = "really good book"},
                new Book {Id = 2, AuthorName = "Nizami", BookDescription = "really fun to read"},
                new Book {Id = 3, AuthorName = "Omar", BookDescription = "needs some work"}
            };
            
        }

        public static List<Person> People()
        {
            return new List<Person>
            {
                new Person { Id = 1, Name = "Name 1", Surname="Surname 1", Address = "Baku, Azerbaijan", Salary = 2000},
                new Person { Id = 1, Name = "Name 2", Surname="Surname 2", Address = "Baku, Azerbaijan", Salary = 1500},
                new Person { Id = 1, Name = "Name 3", Surname="Surname 3", Address = "Baku, Azerbaijan", Salary = 200}
            };
        }
    }
}
