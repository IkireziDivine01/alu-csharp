using System;
using System.Collections.Generic;

public static class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        if (list1 == null && list2 == null)
            return new List<int>();
        
        if (list1 == null)
        {
            List<int> result = new List<int>(new HashSet<int>(list2));
            result.Sort();
            return result;
        }
        
        if (list2 == null)
        {
            List<int> result = new List<int>(new HashSet<int>(list1));
            result.Sort();
            return result;
        }
        
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);
        List<int> differentElements = new List<int>();
        
        foreach (int element in set1)
        {
            if (!set2.Contains(element))
            {
                differentElements.Add(element);
            }
        }
        
        foreach (int element in set2)
        {
            if (!set1.Contains(element))
            {
                differentElements.Add(element);
            }
        }
        
        differentElements.Sort();
        
        return differentElements;
    }
}