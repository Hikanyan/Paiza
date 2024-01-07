using System;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine()!);
        var a = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);
        var q = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < q; i++)
        {
            var k = int.Parse(Console.ReadLine()!);
            Console.WriteLine(binary_search(a, n, k) ? "Yes" : "No");
        }
    }

    private static bool binary_search(IReadOnlyList<int> a, int n, int k)
    {
        int left = 0;
        int right = n - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (a[mid] == k)
            {
                return true;
            }
            else if (a[mid] < k)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
    }
}