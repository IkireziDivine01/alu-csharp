using System;
using System.Collections.Generic;
using System.Linq;

public static class List
{
    public static int Sum(List<int> myList)
    {
        if (myList == null || myList.Count == 0)
            return 0;
        
        return myList.Distinct().Sum();
    }
}