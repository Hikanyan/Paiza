/*

最大公約数（以後 gcd）と対になる値として、最小公倍数（以後 lcm）があります。
一般的に直接 lcm を求めるよりも、gcd を求めてから計算によって lcm を求めるほうが簡単とされています。
2 つの整数 A , B の lcm(A,B) は、lcm(A,B) = A×B/gcd(A,B) で求めることができます。
2 つの整数 A , B が与えられるので、lcm (A,B) を求めてください。

*/


using System;
class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var a = int.Parse(input[0]);
        var b = int.Parse(input[1]);
        
        Console.WriteLine(Lcm(a, b));
    }
    
    // ユークリッドの互除法 再帰
    static long Gcd(long a, long b)
    {
        if (b == 0) return a;
        return Gcd(b, a % b);
    }
    
    static long Lcm(long a, long b)
    {
        return a / Gcd(a, b) * b; // 先に除算を行い、次に掛け算をする
    }
}