using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        
        var query = from num in numbers
                    where num % 2 == 0
                    select num;

        
        Console.WriteLine("The numbers which produce the remainder 0 after divided by 2 are:");
        foreach (int num in query)
        {
            Console.Write(num + " ");
        }

       
    }
}
