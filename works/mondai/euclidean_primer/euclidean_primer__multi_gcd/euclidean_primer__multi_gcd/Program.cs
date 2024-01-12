using System;

class Program
{
    // ユークリッドの互除法で最大公約数を求める関数
    static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // N個の整数の最大公約数を求める関数
    private static int FindGcd(int[] numbers)
    {
        int result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            result = Gcd(result, numbers[i]);
        }
        return result;
    }

    static void Main()
    {
        // Nを受け取ります
        int n = int.Parse(Console.ReadLine());

        // 整数A_iを受け取ります
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // N個の整数の最大公約数を求めて出力します
        int result = FindGcd(numbers);
        Console.WriteLine(result);
    }
}