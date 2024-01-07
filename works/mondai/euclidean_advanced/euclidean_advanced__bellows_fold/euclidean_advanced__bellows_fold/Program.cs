using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int gcd = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            int length = int.Parse(Console.ReadLine());
            gcd = Gcd(gcd, length);
        }

        Console.WriteLine(gcd);
    }

    static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int t = b;
            b = a % b;
            a = t;
        }

        return a;
    }
}