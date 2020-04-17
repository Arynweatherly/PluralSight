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
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);

            }
        }
   

        public Statistics GetStatistics() //public method named getstatistics and its return type (type of obj it will return) is Statistics
        {
            var result = new Statistics();
            result.Average = 0.0;
         
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            //foreach(var grade in grades)
            var index = 0;
            do 
            {
              result.Low = Math.Min(grades[index], result.Low); //take result.low and compare it to existing result.Low
              result.High = Math.Max(grades[index], result.High);  
              result.Average += grades[index];
              //write condition in while statement that tells when to terminate loop
                index += 1;
            } while(index < grades.Count);
            result.Average /= grades.Count; 

             //how do i return the statistics ive computed?

            return result;

        }

        private List<double> grades;
        public string Name;
    }
}