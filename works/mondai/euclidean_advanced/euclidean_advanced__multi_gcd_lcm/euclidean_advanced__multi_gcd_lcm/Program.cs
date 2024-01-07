using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        long[] numbers = new long[N];
        for (int i = 0; i < N; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        long gcd = numbers[0];
        long lcm = numbers[0];
        for (int i = 1; i < N; i++)
        {
            gcd = Gcd(gcd, numbers[i]);
            lcm = Lcm(lcm, numbers[i]);
        }

        Console.WriteLine(gcd);
        Console.WriteLine(lcm);
    }

    static long Gcd(long a, long b)
    {
        while (b != 0)
        {
            long t = b;
            b = a % b;
            a = t;
        }
        return a;
    }

    static long Lcm(long a, long b)
    {
        return a / Gcd(a, b) * b;
    }
}