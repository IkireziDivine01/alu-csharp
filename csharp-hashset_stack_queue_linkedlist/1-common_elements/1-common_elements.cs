public static class List {
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        if (list1 == null || list2 == null)
            return new List<int>();

        List<int> commonElements -new List<int>();
        HashSet<int> set2 = new HashSet<int>(list2);
        HashSet<int> addedElements = new HashSet<int>();

        foreach (int element in list1) {
            if (set2.Contains(element) && !addedElements.Contains(element))
            {
                commonElements.Add(element);
                addedElements.Add(element);
            }
        }

        commonElements.Sort();

        return commonElements;
    }
}