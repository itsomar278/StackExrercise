namespace Stack;


    public class Stack<T>
    {

        List<T> list = new List<T> (); 
        private static int  currentIndex = -1 ; 
        public void  push (T item)
        {
            list.Add (item);
            currentIndex++;
        }
        public T peek()
        {
        return list [currentIndex]; 
        }
        
    


       
    }



