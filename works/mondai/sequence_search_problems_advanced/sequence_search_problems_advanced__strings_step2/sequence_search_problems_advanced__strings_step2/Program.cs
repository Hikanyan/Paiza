using System;

class Program
{
    static void Main()
    {
        var inputS = Console.ReadLine();
        var inputT = Console.ReadLine();

        var count = 0;
        for (var i = 0; i < inputS.Length; i++)
        {
            for (var j = i; j < inputS.Length; j++)
            {
                var subString = inputS.Substring(i, j - i + 1);
                if (subString == inputT)
                {
                    count++;
                }
            }
        }
        
        Console.WriteLine(count);
    }
}