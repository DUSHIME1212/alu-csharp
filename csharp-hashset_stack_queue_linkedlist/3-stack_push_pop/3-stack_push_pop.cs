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
            
            List<string> stackItems = new List<string>(aStack);
            int searchIndex = stackItems.IndexOf(search);

            
            aStack.Clear();

            
            for (int i = stackItems.Count - 1; i >= 0; i--)
            {
                if (i > searchIndex)
                {
                    continue; 
                }
                else if (i == searchIndex)
                {
                    continue; 
                }
                else
                {
                    aStack.Push(stackItems[i]);
                }
            }
        }

        
        aStack.Push(newItem);

        
        return aStack;
    }
}