using System;
using System.Collections.Generic;

namespace Stack;
public class program
{

   static void  Main ()
    {
        Stack<int> stack = new Stack<int> ();
        stack.push (1);
        stack.push (2);
        stack.push (3); 
        stack.print ();
        stack.pop();
        stack.peak();
        stack.clear();
        stack.peak();



    }


}
