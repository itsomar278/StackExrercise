using static Stack.program;

namespace Stack
{
    public interface IStack<T>
    {
        void clear();
        void peak();
        public T pop();
        void print(Action<String> p);
        void push(T item);
    }
}