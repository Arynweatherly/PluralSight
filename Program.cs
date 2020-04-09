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

            double[] numbers = new double[3]; //array can hold 3 floating point numbers
            numbers[0] = 12.7;
            numbers[1] = 10.3;
            numbers[2] = 6.11;

            var result = numbers[0];
            result = result + numbers[1];
            result = result + numbers[2];
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
