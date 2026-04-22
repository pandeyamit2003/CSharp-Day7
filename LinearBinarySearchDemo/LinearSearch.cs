using System;

class LinearSearchExample
{
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter number to search: ");
        int target = Convert.ToInt32(Console.ReadLine());

        int result = LinearSearch(arr, target);

        if (result != -1)
        {
            Console.WriteLine("Element found at index: " + result);
        }
        else
        {
            Console.WriteLine("Element not found.");
        }
    }
}
