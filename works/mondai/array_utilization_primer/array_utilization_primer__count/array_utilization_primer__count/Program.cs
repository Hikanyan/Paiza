//https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__count
 
 using System;
 
 class Program
 {
     static void Main()
     {
         int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
         int count = 0;
         for (int i = 0; i < n[0]; i++)
         {
             var a = int.Parse(Console.ReadLine());
             if (n[1] == a) count++;
         }
         Console.WriteLine(count);
     }
 }