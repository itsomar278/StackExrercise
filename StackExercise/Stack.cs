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


        public void peek()
        {
        T item = list [currentIndex];
        Console.WriteLine(item);

        }


        public T pop()
        {
        T item = list [currentIndex]; 
        currentIndex --;
        return item;
        }

        public void print ()
        {

        foreach (T item in list)
        {
            Console.WriteLine (item);
        }

        }


        
    


       
    }



