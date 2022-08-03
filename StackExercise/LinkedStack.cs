namespace Stack;
public partial class program
{
    public class LinkedStack<T> : IStack<T>
    {

        private readonly LinkedList<T> _stack;
        public LinkedStack()
        {
         _stack = new LinkedList<T>(); 
        }
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

        public void print(Action<String> p)
        {
            if (_stack.Count() == 0)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                foreach (T item in _stack)
                {
                    p(item.ToString());
                }
            }
        }

        public void push(T item)
        {
            _stack.AddLast(item);
        }
    }

}
