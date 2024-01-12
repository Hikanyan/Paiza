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

    static void Main()
    {
        // 入力を受け取ります
        string input = Console.ReadLine();
        string[] inputArray = input.Split();
        int a = int.Parse(inputArray[0]);
        int b = int.Parse(inputArray[1]);

        // 最大公約数を求めて出力します
        int result = Gcd(a, b);
        Console.WriteLine(result);
    }
}