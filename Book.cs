using System;
using System.Collections.Generic;

namespace GradeBook{
   public class Book 
    { 
        //constructor
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        //make method for adding a grade . type is double and name of parameter is grade
    
        public void AddGrade(double grade) 
        {
            grades.Add(grade);
        }
   

        public Statistics GetStatistics() //public method named getstatistics and its return type (type of obj it will return) is Statistics
        {
            var result = new Statistics();
            result.Average = 0.0;
         
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach(var grade in grades) 
            {
              result.Low = Math.Min(grade, result.Low); //take result.low and compare it to existing result.Low
              result.High = Math.Max(grade, result.High);  
                result.Average += grade;
            }
            result.Average /= grades.Count; 

             //how do i return the statistics ive computed?

            return result;

        }

        private List<double> grades;
        public string Name;
    }
}