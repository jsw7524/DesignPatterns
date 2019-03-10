using System;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
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
