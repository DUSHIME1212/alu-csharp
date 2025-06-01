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

        
        string firstItem = null;
        if (aQueue.Count > 0)
            firstItem = aQueue.Dequeue();

        Queue<string> tempQueue = new Queue<string>();

        if (firstItem != null)
            tempQueue.Enqueue(firstItem);

        
        foreach (var item in aQueue)
        {
            tempQueue.Enqueue(item);
        }

        
        aQueue = tempQueue;

        aQueue.Enqueue(newItem);

        return aQueue;
    }
}
