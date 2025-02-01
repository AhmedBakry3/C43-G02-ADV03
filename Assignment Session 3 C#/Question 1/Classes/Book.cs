namespace Assignment_Session_3_C_.Question_1.Classes
{
    public class Book
    {
        #region Properties
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string[]? Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        #endregion

        #region Constructors
        public Book(string? _ISBN, string? _Title , string[]? _Authors, DateTime _PublicationDate , decimal _price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _price;
        }
        #endregion

        #region Methods
        //Override in tostring() Method
        public override string ToString()
        {
            return $"ISBN = {ISBN} , Title = {Title} , Authors = {Authors} , PublicationDate = {PublicationDate} , price = {Price:C}";
        }
        #endregion
        
    }
}
