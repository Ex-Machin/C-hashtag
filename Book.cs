namespace hwapp
{
    public class Book
    {
        public string title = "";
        public string author = "";
        public int pages = 0;
        public Book() {
            
        }

        public Book(string aTitle, string aAuthor, int aPages) 
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}