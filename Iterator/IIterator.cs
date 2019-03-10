namespace Iterator
{
    interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}