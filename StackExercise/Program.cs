using System;
using System.Collections.Generic;

namespace Stack;
public partial class program
{


    static void consPrint(String s) // printing method by user using the Action delegate print 
    {
        Console.WriteLine(s);
    }



    static void Main()
    {
        Action<String> print = new Action<String>(consPrint); // delegate for customizing the print pattern by user

        ListStack<int> stack = new ListStack<int>(); // new List stack initialized 

        // some commands on the stack 
        stack.push(1);
        stack.push(2);
        stack.push(3);
        stack.push(4);
        stack.print(print);
        stack.pop();
        stack.peak();
        stack.clear();
        stack.print(print);


        // new LinkedList stack initialized 
        LinkedStack<int> stack2 = new LinkedStack<int>();
        stack2.push(1);
        stack2.push(2);
        stack2.push(3);
        stack2.push(4);
        stack2.print(print);
        stack2.pop();
        stack2.peak();
        stack2.clear();
        stack2.print(print);











    }

}
