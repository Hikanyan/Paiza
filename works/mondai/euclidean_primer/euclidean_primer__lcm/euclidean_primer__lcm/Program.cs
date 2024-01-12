using System;

class Program
{
    static long Gcd(long a, long b)
    {
        if (a < b)
        {
            var tmp = a;
            a = b;
            b = tmp;
        }

        while (b != 0)
        {
            var r = a % b;
            a = b;
            b = r;
        }

        return a;
    }

    static long Lcm(long a, long b)
    {
        return a * b / Gcd(a, b);
    }

    static void Main()
    {
        var input = Console.ReadLine().Split(' ');

        var a = long.Parse(input[0]);
        var b = long.Parse(input[1]);

        Console.WriteLine(Lcm(a, b));
    }
}