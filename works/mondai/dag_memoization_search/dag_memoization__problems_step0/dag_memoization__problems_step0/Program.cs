using System;
using System.Collections.Generic;

class Program
{
    private static readonly long[] FibArray = new long[100001]; // メモ化用の配列

    private static long Fibonacci(int n)
    {
        if (n <= 1) return n;
        if (FibArray[n] != 0) return FibArray[n];
        FibArray[n] = (Fibonacci(n - 1) + Fibonacci(n - 2)) % 1000000007; //整数が大きくなるとオーバーフローするので、1000000007で割った余りを求める
        return FibArray[n];
    }

    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Fibonacci(n));
    }
}