namespace Stack;
public partial class program
{
    public class LinkedStack<T> : IStack<T>
    {

        LinkedList<T> _stack = new LinkedList<T>();
        public void clear()
        {
            _stack.Clear();
        }

        public void peak()
        {
            if (_stack.Count == 0)
            {
                InvalidOperationException ex = new InvalidOperationException();
                throw ex;
            }
            else
            {
                T item = _stack.Last();
                Console.WriteLine(item);  
            }
        }

        public T pop()
        {
            if (_stack.Count == 0)
            {
                InvalidOperationException ex = new InvalidOperationException();
                throw ex;
            }
            else
            {
                T item = _stack.Last();
                _stack.RemoveLast();
                return item;
            }
        }

        public void print()
        {
            if (_stack.Count() == 0)
            {
                InvalidOperationException ex = new InvalidOperationException();
                throw ex;
            }
            else
            {
                foreach (T item in _stack)
                {
                    Console.WriteLine(item);
                }
            }
            
        }

        public void push(T item)
        {
            _stack.AddLast(item);
        }
    }

}
