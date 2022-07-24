using System;
using System.Collections.Generic;

namespace Stack;
public partial class program
{

    static void  Main ()
    {
        /*
        ListStack<int> stack = new ListStack<int>();
     
       
        stack.push(1);
        stack.push(2);
        stack.push(3);
        stack.push(4);
        stack.print();
        stack.pop();
        stack.peak();
        stack.clear();
        stack.pop();
        stack.print();
        */

        LinkedStack<int> stack = new LinkedStack<int>();
        stack.push(1);
        stack.push(2);
        stack.push(3);
        stack.push(4);
        stack.print();
        Console.WriteLine(stack.pop());
        stack.peak();
        stack.clear();
        stack.print();








    }

}
