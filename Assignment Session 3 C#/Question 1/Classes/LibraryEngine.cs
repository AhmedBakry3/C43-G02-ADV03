
namespace Assignment_Session_3_C_.Question_1.Classes
{
    //User defined Delegate
    public delegate string FunctionsDelegate(Book B);
    internal class LibraryEngine
    {
        #region Methods
        //a. User Defined Delegate Datatype
        public static void ProcessBooks(List<Book> blist , FunctionsDelegate functionsDelegate) {

            foreach (Book B in blist)
            {
                Console.WriteLine(functionsDelegate(B));
            }
        }

        //b. BCL Delegates
        public static void ProcessBooks<T>(List<Book> blist, Func<Book,T> functionsDelegate)
        {
            foreach (Book B in blist)
            {
                Console.WriteLine(functionsDelegate(B));
            }
        }
        #endregion
    }
}
