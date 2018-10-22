using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> library = new List<Book>
            {
                new Book() { title = "The Hero with a Thousand Faces", author = "Joseph Campbell"},
                new Book() { title = "The Histories", author = "Herodotus"},
                new Book() { title = "Odyssey", author = "Homer"},
                new Book() { title = "The Fellowship of the Ring", author = "J. R. R. Tolkien"},
                new Book() { title = "The Two Towers", author = "J. R. R. Tolkien"},
                new Book() { title = "The Return of the King", author = "J. R. R. Tolkien"},
                new Book() { title = "The Well-Grounded Rubyist", author = "David A. Black"},
                new Book() { title = "Detroit An American Autopsy", author = "Charlie LeDuff"},
                new Book() { title = "SPQR", author = "Mary Beard"},
                new Book() { title = "The Elegance of the Hedgehog", author = "Muriel Barbery"},
                new Book() { title = "Gates of Fire", author = "Steven Pressfield"},
                new Book() { title = "Iliad", author = "Homer"}
            };

            library.Sort();

            Console.WriteLine($"Welcome to the library. ");

            bool quit = false;

            while (!quit)
            {
                Console.Write("Would you like to search by author name(n), search by title(t), add a book to the collection(a), or quit(q)? ");
                char responseKey = Char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine("");
                Console.WriteLine("");
                switch (responseKey)
                {
                    case 'n':
                        lookUp(ref library, "author name");
                        break;
                    case 't':
                        lookUp(ref library, "title");
                        break;
                    case 'a':
                        addNewBook(ref library);
                        break;
                    case 'q':
                        quit = true;
                        Console.Write("Thanks");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("That is not a valid response. Please try again. (enter \"l\", \"a\", or \"q\"): ");
                        continue;
                }
            }
        }

        static void addNewBook(ref List<Book> library)
        {
            Book newBook = makeBook();
            library.Insert(~(library.BinarySearch(newBook)), newBook);
            showBooks(library);
        }

        static Book makeBook()
        {
            return new Book() { title = makeDetail("What is the title of the book? "), author = makeDetail("Who wrote this book? ") };
        }

        static string makeDetail(string message)
        {
            Console.Write(message);
            string detail = Console.ReadLine();
            Console.WriteLine("");
            if (string.IsNullOrWhiteSpace(detail))
            {
                return makeDetail(message);
            }
            else
            {
                return detail;
            }

        }

        static void lookUp(ref List<Book> library, string searchType)
        {
            List<Book> matchingBooks = getBooks(library, searchType);
            if (matchingBooks.Count == 0)
            {
                Console.WriteLine("No books match this search term. ");
                return;
            }
            completeBookTransaction(ref library, matchingBooks);
        }

        static void showBooks(List<Book> library)
        {
            library.ForEach(book => Console.WriteLine($"{library.IndexOf(book)}: [" + (book.checkedOut?($"Unavailable, due back on {book.dueDate:d}"):"Available!") + $"] {book.title} by {book.author}"));
            Console.WriteLine("");
        }


        static List<Book> getBooks(List<Book> library, string searchType)
        {
            Console.Write("Search: ");
            string searchTerm = Console.ReadLine().ToLower();
            Console.WriteLine("");
            if (searchType == "author name")
            {
                return library.Where(book => book.author.ToLower().Contains(searchTerm)).ToList();
            }
            else if (searchType == "title")
            {
                return library.Where(book => book.title.ToLower().Contains(searchTerm)).ToList();
            }
            else
            {
                return library.Where(book => book.title.ToLower().Contains(searchTerm) || book.author.ToLower().Contains(searchTerm)).ToList();
            }
        }

        static void completeBookTransaction(ref List<Book> library, List<Book> matchingBooks)
        {
            showBooks(matchingBooks);
            int bookIndex = int.Parse(promptUser($"Enter the number of the book you would like to check out or return between 0 and {matchingBooks.Count - 1}: ", (str => int.TryParse(str, out bookIndex) && bookIndex < (matchingBooks.Count) && bookIndex >= 0)));
            Console.WriteLine("");
            Book checkedOutBook = library[library.IndexOf(matchingBooks[bookIndex])];
            checkedOutBook.checkedOut = !checkedOutBook.checkedOut;
            if(checkedOutBook.checkedOut)
            {
                checkedOutBook.dueDate = DateTime.Now.AddDays(14);
                Console.WriteLine($"You checked out {checkedOutBook.title} by {checkedOutBook.author} and it is due back {checkedOutBook.dueDate:D}.");
            }
            else
            {
                checkedOutBook.dueDate = null;
                Console.WriteLine($"You successfully returned {checkedOutBook.title} by {checkedOutBook.author}.");
            }
            
            Console.WriteLine("");
        }

        static string promptUser(string message, Func<string, bool> condition)
        {
            Console.Write(message);
            string textValue = Console.ReadLine();
            if (condition(textValue))
            {
                return textValue;
            }
            else
            {
                Console.WriteLine("This is not valid input.");
                return promptUser(message, condition);
            }
        }
    }
}
