namespace Stack
{
    public interface IStack<T>
    {
        void clear();
        void peak();
        public T pop();
        void print();
        void push(T item);
    }
}