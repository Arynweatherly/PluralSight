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

            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var number in grades) 
            {
              lowGrade = Math.Min(number, lowGrade);
              highGrade = Math.Max(number, highGrade);  
                result += number;
            }
            result /= grades.Count; 
            Console.WriteLine($"the lowest grade is {lowGrade}");
            Console.WriteLine($"The average grade is {result:N1}");

          

    }
}
}
