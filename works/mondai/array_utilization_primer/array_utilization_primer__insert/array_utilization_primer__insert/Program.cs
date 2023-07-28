// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__insert

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == b[0])
            {
                InsertElement(array, i + 1, b[1]);
                break;
            }
        }

        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
    }

    static void InsertElement(int[] array, int index, int element)
    {
        Array.Resize(ref array, array.Length + 1);
        for (int i = array.Length - 1; i > index; i--)
        {
            array[i] = array[i - 1];
        }

        array[index] = element;
    }
}