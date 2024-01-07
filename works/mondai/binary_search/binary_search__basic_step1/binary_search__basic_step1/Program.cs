using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split(' ');
        int[] array = new int[num];
        for (int i = 0; i < num; i++)
        {
            array[i] = int.Parse(inputs[i]);
        }

        int q = int.Parse(Console.ReadLine());
        int[] key = new int[q];
        for (int i = 0; i < q; i++)
        {
            key[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        for (int i = 0; i < q; i++)
        {
            Console.WriteLine(binary_search(array, num, key[i]));
        }
    }

    static int binary_search(IReadOnlyList<int> array, int size, int key)
    {
        int left = 0;
        int right = size;
        while (left < right)
        {
            int mid = (left + right) / 2;
            if (array[mid] < key)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return right;
    }
}