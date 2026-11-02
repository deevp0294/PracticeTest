namespace PracticeTest
{
    public class Book
    {
        bool isAvailable;

        public int Id = 0;
        public string Name = "Book1";

        public Book(int id ,string name,bool availability)
        {
            Id = id;
            Name = name;
            isAvailable = availability;
        }

        public bool IsAvailable()
        {
            return isAvailable;
        }
    }
    internal class Question18
    {
        List<Book> books = new List<Book>()
        {
            new Book(34,"Book35",true),
            new Book(234,"Book35",true),
            new Book(14,"Book35",true),
            new Book(3224,"Book35",true),
            new Book(4,"Book35",true),
        };
        public void AddBook(int id, string name, bool avail)
        {
            if(!CopyIdentifier(id)) books.Add(new Book(id, name, avail)); 
        }
        bool CopyIdentifier(int id)
        {
            foreach(Book book in books)
            {
                if (book.Id == id)
                {
                    Console.WriteLine("Already existed");
                    return true;
                }
            }
            return false;
        }
        public void Borrow(int id)
        {
            try
            {
                foreach (Book book in books)
                {
                    if (book.Id == id)
                    {
                        Console.WriteLine("Successful");
                        books.Remove(book);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not available");
                        break;
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void Return(int id)
        {
            try
            {
                foreach (Book book in books)
                {
                    if (book.Id != id)
                    {
                        Console.WriteLine("Successful");
                        books.Add(book);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Already present");
                        break;
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
