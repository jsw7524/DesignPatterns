using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{

    interface IAggregate<T>
    {
        IIterator<T> Iterator();
    }

    interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }

    class BookShelfIterator : IIterator<Book>
    {
        private BookShelf bookShelf;
        private int index;
        public BookShelfIterator(BookShelf bs)
        {
            bookShelf = bs;
            index = 0;
        }
        public bool HasNext()
        {
            return index < bookShelf.GetLength();
        }

        public Book Next()
        {
            return bookShelf.GetBookAt(index++);
        }
    }

    class BookShelf : IAggregate<Book>
    {
        private List<Book> Books = new List<Book>();

        public Book GetBookAt(int i)
        {
            return Books[i];
        }

        public void AppendBook(Book b)
        {
            Books.Add(b);
        }

        public int GetLength()
        {
            return Books.Count;
        }

        public IIterator<Book> Iterator()
        {
            return new BookShelfIterator(this);
        }
    }

    class Book
    {
        public Book(string n)
        {
            Name = n;
        }
        public string Name { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var myBookShelf = new BookShelf();
            myBookShelf.AppendBook(new Book("C++ 三個月從入門到放棄"));
            myBookShelf.AppendBook(new Book("用PHP做義大利麵"));
            myBookShelf.AppendBook(new Book("程式設計師最佳入門語言:英文"));
            myBookShelf.AppendBook(new Book("Javascript 昆蟲大圖鑑"));
            IIterator<Book> it=myBookShelf.Iterator();
            while (it.HasNext())
            {
                Book book = it.Next();
                Console.WriteLine(book.Name);
            }

            Console.ReadLine();
        }
    }
}
