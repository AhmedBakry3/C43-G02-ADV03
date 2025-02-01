using Assignment_Session_3_C_.Question_1.Classes;


namespace Assignment_Session_3_C_.Question_1
{
    internal class BookFunctions : Book
    {
        #region Constructors
        public BookFunctions(string? _ISBN, string? _Title, string[]? _Authors, DateTime _PublicationDate, decimal _price) : base(_ISBN, _Title, _Authors, _PublicationDate, _price)
        {
        }

        #endregion

        #region Methods

        //GetTitle Method
        public static string GetTitle(Book B)
        {
            return B?.Title ?? "";
        }

        //GetAuthors Method
        public static string GetAuthors(Book B) {
        if(B.Authors is not null) 
        {
          return string.Join(", ", B.Authors);
        }
        else 
        { 
            return null;
        }        
        }

        //GetPrice Method
        public static string GetPrice(Book B)
        {
            return B.Price.ToString("C");
        }
        #endregion
    }
}
