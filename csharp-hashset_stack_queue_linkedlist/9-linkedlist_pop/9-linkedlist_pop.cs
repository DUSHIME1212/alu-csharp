﻿using System;
using System.Collections.Generic;

public class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.First == null)
            return 0; 

        int headValue = myLList.First.Value; 
        myLList.RemoveFirst(); 

        return headValue; 
    }
}
