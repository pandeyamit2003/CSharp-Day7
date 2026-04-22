using System;

class BinarySearchExample
{
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter elements in sorted order:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter number to search: ");
        int target = Convert.ToInt32(Console.ReadLine());

        int result = BinarySearch(arr, target);

        if (result != -1)
            Console.WriteLine("Element found at index: " + result);
        else
            Console.WriteLine("Element not found.");
    }
}