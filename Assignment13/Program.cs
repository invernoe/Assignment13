namespace Assignment13
{
    internal class Program
    {
        public static void ProcessBooks<T>(List<Book> books, Func<Book, T> fPtr)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(fPtr(book));
            }
        }

        static void Main(string[] args)
        {
            #region Part 1
            List<Book> books = new List<Book>()
            {
                new Book("123123", "Title1", ["Mahmoud", "Khaled"], DateTime.Now, 200),
                new Book("332131", "Title2", ["Mahmoud", "Khaled"], DateTime.Now, 300),
                new Book("876876", "Title3", ["Mahmoud", "Khaled"], DateTime.Now, 400)
            };

            ProcessBooks(books, BookFunctions.GetTitle);
            ProcessBooks(books, BookFunctions.GetAuthors);
            ProcessBooks(books, BookFunctions.GetPrice);
            #endregion

            #region Part 2
            MyList<int> myList = new MyList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("==========================================");
            Console.WriteLine(myList);
            Console.WriteLine(myList.Exists((a) => a % 2 == 0));
            Console.WriteLine(myList.Find((a) => a % 2 == 0));
            Console.WriteLine(myList.FindAll((a) => a % 2 == 0));
            Console.WriteLine(myList.FindIndex((a) => a % 2 == 0));
            Console.WriteLine(myList.FindLast((a) => a % 2 == 0));
            Console.WriteLine(myList.FindLastIndex((a) => a % 2 == 0));
            Console.WriteLine(myList.TrueForAll((a) => a % 2 == 0));
            #endregion
        }
    }
}
