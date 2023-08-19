//try and catch, exceptions C#

using System;
using System.IO;

class Program
{
    static void Main (string[] args)
    {        try
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(numbers[11]);
        }
        catch (Exception e) { Console.WriteLine ("An error occured! Please try again! "+e.Message); }
        finally { Console.WriteLine("The try catch has finished"); }
    }
}