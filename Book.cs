using System;
using System.Collections.Generic;

namespace GradeBook{
   public class Book 
    { 
        //this is a constructor method
        public Book(string name)
        {
            
            grades = new List<double>();
            Name = name;
        }
  

        public void AddGrade(char letter) 
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
            else //how to create an exception:
            {
                throw new ArgumentException($"INVALID {nameof(grade)}"); //throwing exception and someone else has to catch it if they want to handle the condition
            }
        }
   

        public Statistics GetStatistics()
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

            switch(result.Average)
            {
                case var d when d >= 90.0:
                result.Letter = 'A';
                break;       

                case var d when d >= 80.0:
                result.Letter = 'B';
                break;       

                case var d when d >= 70.0:
                result.Letter = 'C';
                break;       

                case var d when d >= 60.0:
                result.Letter = 'D';
                break;       

               default:
                result.Letter = 'F';
                break;       
                 }


            return result;

        }

        private List<double> grades;

    public string Name
    {
        get; 
        set;
    }
    

public const string CATEGORY = "Science";  //you access a static member using the type name 
  
    }
}