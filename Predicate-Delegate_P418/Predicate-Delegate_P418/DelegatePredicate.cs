using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_Delegate_P418
{
    public class DelegatePredicate
    {
        public void CountOfNizamisBook(List<Book> books)
        {
            int count = 0;
            foreach (Book book in books)
            {
                if (book.AuthorName == "Nizami")
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public delegate bool CheckSalary(Person people);

        public bool CheckRequiredSalary(Person people)
        {
            return people.Salary > 1000;
        }

        public void MoreThanRequiredSalary(List<Person> people, CheckSalary func) 
        {
            foreach (Person person in people)
            {
                if (func(person))
                {
                    Console.WriteLine($"{person.Name}--- {person.Surname} --- {person.Salary}");
                }
            }
        }

        public void ShowResult()
        {
            MoreThanRequiredSalary(DbContext.People(), CheckRequiredSalary);
        }
    }
}
