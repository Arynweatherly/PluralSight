using System;

namespace GradeBook
{
    class Program
    {
        //the following is a method and the stuff in the curlies get executed 

        static void Main(string[] args)
        {
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
