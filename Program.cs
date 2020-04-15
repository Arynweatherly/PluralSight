// using System;
// using System.Collections.Generic;

// namespace GradeBook
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
            
//             var numbers = new[] {12.7, 10.3, 6.11, 4.1}; //array can hold 3 floating point numbers
//            //initialization syntax
//            var grades = new List<double>() {12.7, 10.3, 6.11, 4.1 };
//            grades.Add(56.1);
           
//             var result = 0.0;
//             //iterate over the lsit
//             foreach(var number in grades) 
//             {
//                 result += number;
//             }
// Console.WriteLine(result);

          
//          if(args.Length > 0)
//          {
//             Console.WriteLine($"Hello,  {args[0]} !");
//         }
//         else
//          {
//             Console.WriteLine("Hello!");
//         }
//     }
// }
// }




//compute average grade:

using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
         

            var book = new Book("Aryn's Gradebook");
            book.AddGrade(89.1);
            book.AddGrade(90.5);

            
           //initialization syntax
           var grades = new List<double>() {12.7, 10.3, 6.11, 4.1 };
           grades.Add(56.1);
           
            var result = 0.0;

            //want to find highest grade in this list 
            var highGrade = double.MinValue;
            //iterate over the lsit
            foreach(var number in grades) 
            {
                if(number > highGrade) {
                    highGrade = number;
                }
                result += number;
            }
            result /= grades.Count; 
            Console.WriteLine($"The average grade is {result:N1}");

          

    }
}
}
