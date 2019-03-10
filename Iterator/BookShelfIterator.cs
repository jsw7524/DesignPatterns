namespace Iterator
{
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
}