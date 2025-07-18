﻿using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);
        List<int> differentList = new List<int>();

        
        foreach (int num in set1)
        {
            if (!set2.Contains(num))
            {
                differentList.Add(num);
            }
        }

        
        foreach (int num in set2)
        {
            if (!set1.Contains(num))
            {
                differentList.Add(num);
            }
        }

        
        differentList.Sort();
        
        return differentList;
    }
}
