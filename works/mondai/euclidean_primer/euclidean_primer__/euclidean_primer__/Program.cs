using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var a = int.Parse(input[0]);
        var b = int.Parse(input[1]);
        var c = int.Parse(input[2]);

        var x = 0;
        var y = 0;

        if (c == a % b)
        {
            x = 1;
            y = -(a / b);
        }
        else
        {
            x = -(b / a);
            y = 1;
        }

        Console.WriteLine($"{x} {y}");
    }
}