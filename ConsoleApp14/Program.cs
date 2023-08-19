//try and catch, exceptions C#

using System;
using System.IO;
using System.Runtime.CompilerServices;

class Program
{
    static void Main (string[] args)
    {        try
        {
            string[] cats = {"Perky","Bobi","Jolly" };
            Console.WriteLine(cats[11]);
        }
        catch (Exception e) { Console.WriteLine ("An error occured! Please try again! "+e.Message); }
        finally { Console.WriteLine("The try catch has finished"); }
        try
        {
            Console.WriteLine("How many cats do you have? ");
            int numOfCats = Convert.ToInt16(Console.ReadLine());


            if (numOfCats < 0)
            {
                throw new Exception("You can't have less than 0 cats");
            }
            else if (numOfCats == 0)
            {
                throw new Exception("Not having a cat is a big error!");
            }
            else if (numOfCats == 1)
            {
                throw new Exception("You should have more than one cat");
            }
            else if (numOfCats >= 2)
            {
                Console.WriteLine("That is an appropriate number of cats to have, however it'd be better to adopt more of them");
            }
        }catch (Exception a) { Console.WriteLine(a.Message); }
        finally
        {
            Console.WriteLine("Potential errors handled");
        }

        
        
    }
}