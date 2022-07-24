namespace Stack;
public partial class program
{
    public class ListStack<T> : IStack<T>
    {

        private readonly List<T> _stack = new List<T>();
        public ListStack()
        {
            
        }
         
        public void clear()
        {
            _stack.Clear();
        }

        public void peak()
        {
           
           if (_stack.Count == 0 )
            {

                InvalidOperationException ex = new InvalidOperationException();
                Console.WriteLine("you cant pop from an empty stack !");
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
                Console.WriteLine("you cant pop from an empty stack !");
                throw ex;
            }
            else
            {
              T item = _stack.Last();
                _stack.Remove(_stack.Last());
                return item;
            }
            
        }

        public void print()
        {
          
                if (_stack.Count == 0)
                {
                    Console.WriteLine(" THE STACK IS EMPTY !");
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
            _stack.Add(item);
        }
        
        
    }


}
