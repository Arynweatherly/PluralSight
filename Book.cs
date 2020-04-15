using System;
using System.Collections.Generic;

namespace GradeBook{
    class Book 
    { 
        //constructor
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        //make method for adding a grade . type is double and name of parameter is grade
    
        public void AddGrade(double grade) 
        {
            grades.Add(grade);
        }
   

        public void ShowStatistics()
        {
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

        private List<double> grades;
        private string name;
    }
}