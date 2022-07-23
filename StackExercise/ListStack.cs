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
           
            try
            {
                Console.WriteLine(_stack.Last());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
   
        }

        public T pop()
        {
            try
            {
                T item = _stack.Last();
                _stack.Remove(_stack.Last());
                return item;
            }
            catch (Exception e )
            {
                T item = default(T);
                Console.WriteLine(e.Message);
                return item; 
               
            }
        }

        public void print()
        {
            try
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
            catch
            {

            }
           
        }

        public void push(T item)
        {
            _stack.Add(item);
        }
        
        
    }


}
