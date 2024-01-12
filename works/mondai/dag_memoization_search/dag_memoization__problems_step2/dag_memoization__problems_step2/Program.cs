using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static List<int>[] _children = new List<int>[100000];
    private static long[] _memo = new long[100000];

    private static long CalculateIncome(int company)
    {
        if (_memo[company] != -1)
            return _memo[company];

        long income = 1 + _children[company].Sum(CalculateIncome);

        _memo[company] = income;
        return income;
    }

    static void Main()
    {
        var input = Console.ReadLine().Split(' ');

        int n = int.Parse(input[0]);
        int q = int.Parse(input[1]);

        _memo = new long[n];
        _children = new List<int>[n];

        for (int i = 0; i < n; i++)
        {
            _children[i] = new List<int>();
            _memo[i] = -1;
        }

        for (int i = 1; i < n; i++)
        {
            input = Console.ReadLine().Split(' ');
            int c = int.Parse(input[0]);
            int d = int.Parse(input[1]);

            _children[c].Add(d);
        }

        CalculateIncome(0);

        for (int i = 0; i < q; i++)
        {
            int query = int.Parse(Console.ReadLine());
            Console.WriteLine(_memo[query]);
        }
    }
}