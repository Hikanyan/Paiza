using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static readonly List<List<int>> JobRelation = new List<List<int>>(100000);
    private static readonly List<long> Memo = Enumerable.Repeat(-1L, 100000).ToList();

    private static long JobSeqCount(int job)
    {
        if (Memo[job] != -1) return Memo[job];
        if (JobRelation[job].Count == 0) return Memo[job] = 1;

        long count = 0;
        foreach (int j in JobRelation[job])
        {
            count += JobSeqCount(j);
            count %= 1000000007;
        }

        return Memo[job] = count;
    }

    private static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);

        for (int i = 0; i < 100000; i++)
        {
            JobRelation.Add(new List<int>());
        }

        for (int i = 0; i < k; i++)
        {
            input = Console.ReadLine().Split(' ');
            int j = int.Parse(input[0]) - 1;
            int w = int.Parse(input[1]) - 1;
            JobRelation[w].Add(j);
        }

        for (int i = 0; i < n; i++)
        {
            JobRelation[i].Sort((a, b) => b.CompareTo(a)); // 降順にソート
        }

        Console.WriteLine(JobSeqCount(n - 1));
    }
}