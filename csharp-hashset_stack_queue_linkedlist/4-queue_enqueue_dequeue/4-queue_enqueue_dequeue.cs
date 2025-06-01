using System;
using System.Collections.Generic;

public class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        
        Console.WriteLine("Number of items: " + aQueue.Count);

        
        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            
            Console.WriteLine("First item: " + aQueue.Peek());
        }

        
        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        
        if (containsSearch)
        {
            Queue<string> tempQueue = new Queue<string>();
            bool found = false;

            while (aQueue.Count > 0)
            {
                string item = aQueue.Dequeue(); 
                if (item == search)
                {
                    found = true;
                    break;
                }
                tempQueue.Enqueue(item);
            }

            
            while (aQueue.Count > 0)
            {
                tempQueue.Enqueue(aQueue.Dequeue());
            }

            aQueue = tempQueue;
        }

        
        aQueue.Enqueue(newItem);

        return aQueue;
    }
}
