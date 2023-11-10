using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var n = int.Parse(input[0]);
        var x = int.Parse(input[1]);

        for (var i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split(',');
            // var a = int.Parse(line[0]);
            // var b = int.Parse(line[1]);
            // if (b >= x)
            // {
            //     Console.WriteLine($"{a},{b}");
            // }

            if (int.Parse(line[1]) >= x)
            {
                Console.WriteLine(line[0] + "," + line[1]);
            }
        }
    }
}