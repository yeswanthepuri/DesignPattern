using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.LINQ
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {

            return new List<Book>()
            {
                new Book(){Title="Book 1",Price=10},
                new Book(){Title="Book 2",Price=100},
                new Book(){Title="Book 3",Price=5},
                new Book(){Title="Book 4",Price=20},
                new Book(){Title="Book 6",Price=10000},
                new Book(){Title="Book 7",Price=7},
            };
        }

    }
    //Extension method for LINQ
    public static class BookExtensions
    {
        public static IEnumerable<Book> WherePriceGreaterThan(this IEnumerable<Book> books, float minPrice)
        {
            return books.Where(book => book.Price > minPrice);
        }
        public static IEnumerable<Book> WhereCustom(this IEnumerable<Book> books, Func<Book, bool> predicate)
        {
            foreach (var book in books)
            {
                if (predicate(book))
                {
                    yield return book;
                }
            }
        }
    }

    // New extension method that takes a predicate

    }
