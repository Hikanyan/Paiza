using System;
using System.Collections.Generic;

class Program
{
    static List<int>[] children;
    static int[] incomes;

    static int CalculateIncome(int company)
    {
        int maxIncome = incomes[company];

        foreach (int child in children[company])
        {
            int childIncome = CalculateIncome(child);
            maxIncome = Math.Max(maxIncome, childIncome);
        }

        return maxIncome;
    }

    static void Main()
    {
        var input = Console.ReadLine().Split(' ');

        int n = int.Parse(input[0]);
        int q = int.Parse(input[1]);

        incomes = new int[n];
        children = new List<int>[n];

        input = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            incomes[i] = int.Parse(input[i]);
            children[i] = new List<int>();
        }

        for (int i = 1; i < n; i++)
        {
            input = Console.ReadLine().Split(' ');
            int c = int.Parse(input[0]);
            int d = int.Parse(input[1]);

            children[c].Add(d);
        }

        for (int i = 0; i < q; i++)
        {
            int query = int.Parse(Console.ReadLine());
            int result = CalculateIncome(query);
            Console.WriteLine(result);
        }
    }
}