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

        public void AddLetterGrade(char letter) //char is a value type
        {
            switch(letter) 
            {
                case 'A':
                    AddGrade(90);
                    break;
                
                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;
                
                default:
                    AddGrade(0);
                    break;
            }
        }


        public void AddGrade(double grade) 
        {
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else 
            {
                Console.WriteLine("Invalid Value");
            }
        }
   

        public Statistics GetStatistics() //public method named getstatistics and its return type (type of obj it will return) is Statistics
        {
            var result = new Statistics();
            result.Average = 0.0;
         
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            //foreach(var grade in grades)
            for(var index = 0; index < grades.Count; index += 1)
            {
                if(grades[index] == 42.1)
                {
                    break; //results in us skipping the 3 lines of code following this
                }
              result.Low = Math.Min(grades[index], result.Low); //take result.low and compare it to existing result.Low
              result.High = Math.Max(grades[index], result.High);  
              result.Average += grades[index];
            };
            result.Average /= grades.Count; 

             //how do i return the statistics ive computed?

            return result;

        }

        private List<double> grades;
        public string Name;
    }
}