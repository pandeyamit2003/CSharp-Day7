using System;
using System.Collections.Generic;

class MyCollection
{
    private List<string> items = new List<string>();

    // Indexer
    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= items.Count)
                throw new IndexOutOfRangeException("Invalid index");
            return items[index];
        }
        set
        {
            if (index < 0 || index >= items.Count)
                throw new IndexOutOfRangeException("Invalid index");
            items[index] = value;
        }
    }

    public void Add(string item)
    {
        items.Add(item);
    }
}

class Indexes
{
    static void Main()
    {
        MyCollection collection = new MyCollection();

        // Adding items
        collection.Add("Apple");
        collection.Add("Banana");
        collection.Add("Mango");

        // Access using indexer
        Console.WriteLine(collection[0]); // Apple

        // Modify using indexer
        collection[1] = "Orange";

        Console.WriteLine(collection[1]); // Orange
    }
}