using System.Collections.Generic;

namespace Iterator
{
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
}