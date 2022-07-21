namespace Stack
{
    public interface IStack<T>
    {
        void clear();
        void peak();
        T pop();
        void print();
        void push(T item);
    }
}