using System;

namespace GradeBook
{
    class Program
    {
        //the following is a method and the stuff in the curlies get executed 

        static void Main(string[] args)
        {
            //variable declaration 
            //declare variable x to hold a floating point value 
// initialization expression
            double[] numbers = new[] {12.7, 10.3, 6.11}; //array can hold 3 floating point numbers
            var result = 0.0;
            foreach(var number in numbers) 
            {
                result += number;
            }
Console.WriteLine(result);

          
         if(args.Length > 0)
         {
            Console.WriteLine($"Hello,  {args[0]} !");
        }
        else
         {
            Console.WriteLine("Hello!");
        }
    }
}
}
