﻿using System;
using System.Collections.Generic;

public class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);
        List<int> commonList = new List<int>();

        foreach (int num in set1)
        {
            if (set2.Contains(num))
            {
                commonList.Add(num);
            }
        }

        commonList.Sort();
        return commonList;
    }
}
