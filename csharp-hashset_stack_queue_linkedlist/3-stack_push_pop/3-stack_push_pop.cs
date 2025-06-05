using System;
using System.Collections.Generic;

public static class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        
        Console.WriteLine("Number of items: {0}", aStack.Count);

        
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine("Top item: {0}", aStack.Peek());
        }

        
        bool containsSearch = aStack.Contains(search);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, containsSearch);

        
        if (containsSearch)
        {
            
            Stack<string> tempStack = new Stack<string>();

            
            while (aStack.Peek() != search)
            {
                tempStack.Push(aStack.Pop());
            }

            
            aStack.Pop();

            
            while (tempStack.Count > 0)
            {
                aStack.Push(tempStack.Pop());
            }
        }

        
        aStack.Push(newItem);

        
        return aStack;
    }
}