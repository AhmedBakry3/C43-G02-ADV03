using Assignment_Session_3_C_.Question_1;
using Assignment_Session_3_C_.Question_1.Classes;

namespace Assignment_Session_3_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an array of Authors
            string[] Authors = { "Ahmed", "Mohamed", "Mahmoud" };

            //Create a list of Book
            List<Book> book = new List<Book>() {
               new Book("123-456-789", "The NoteBook", Authors , new DateTime(), 300)
            };
            
            #region a. User Defined Delegate Datatype

            //Assign User Define Delegate for a variable to GetTtitle of the Book
            Console.Write("Book Title : ");
            FunctionsDelegate functionsDelegateTtitle = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(book, functionsDelegateTtitle); // Book Title : The NoteBook

            //Assign User Define Delegate for a variable to GetAuthors of the Book
            Console.Write("Book Aurthors : ");
            FunctionsDelegate functionsDelegateAuthors = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(book, functionsDelegateAuthors); //Book Aurthors : Ahmed, Mohamed, Mahmoud

            //Assign User Define Delegate for a variable to GetPrice of the Book
            Console.Write("Book Price : ");
            FunctionsDelegate functionsDelegatePrice = BookFunctions.GetPrice;
            LibraryEngine.ProcessBooks(book, functionsDelegatePrice); //Book Price: $300.00

            #endregion

            #region b. BCL Delegates

            //Assign a BCL Delegate for a variable to GetTitle of the Book
            Console.Write("Book Title : ");
            Func<Book, string> TitleFunc = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(book, TitleFunc); // Book Title : The NoteBook

            //Assign a BCL Delegate for a variable to GetAuthors of the Book
            Console.Write("Book Aurthors : ");
            Func<Book, string> AuthorsFunc = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(book, AuthorsFunc); //Book Aurthors : Ahmed, Mohamed, Mahmoud

            //Assign a BCL Delegate for a variable to GetPrice of the Book
            Console.Write("Book Price : ");
            Func<Book, string> PriceFunc = BookFunctions.GetPrice;
            LibraryEngine.ProcessBooks(book, PriceFunc); //Book Price: $300.00

            #endregion

            #region c. Anonymous Method (GetISBN)

            //Assign a BCL Delegate for a variable to Anonymous Method (GetISBN) of the Book
            Console.Write("Book ISBN : ");
            Func<Book, string> GetISBN = delegate (Book B) { return B?.ISBN ?? ""; };
            LibraryEngine.ProcessBooks(book, GetISBN); //123 - 456 - 789

            #endregion

            #region d. Lambda Expression (GetPublicationDate)

            //Assign a BCL Delegate for a variable to  Lambda Expression (GetPublicationDate) of the Book
            Console.Write("Book PublicationDate : ");
            Func<Book, string> GetPublicationDate = B => B.PublicationDate.ToString("yyyy-MM-dd");
            LibraryEngine.ProcessBooks(book, GetPublicationDate); //0001 - 01 - 01

            #endregion
        }
    }
}
