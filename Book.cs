using System;
using System.Collections.Generic;
using System.IO;

namespace GradeBook{

    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public class Namedobject 
    {
        //create non-default constructor(requires name param)
        public Namedobject(string name)
        {
            Name = name; //Name property equals this incoming name value 
        }


        public string Name
        {
            get; set;
        }
    }

    public interface IBook 
    {
        void AddGrade(double grade);
        Statistics GetStatistics();
        string Name { get; }
        event GradeAddedDelegate GradeAdded;
    }





//abstract class
//goal is polymorphism so that classes derived from bookBase can have different implementations of addgrade
public abstract class Book : Namedobject, IBook
{
        public Book(string name) : base(name)
        {
        }

        public abstract event GradeAddedDelegate GradeAdded; //making this abstract forces a derived class like diskbook to provide an implementation for gradeadded

        public abstract void AddGrade(double grade);

        public abstract Statistics GetStatistics();
     
    }

    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
        }



        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)

        //write code so that every time this method envoked itll open file that has the same name as book and write new line into file that contains grade value
        {
            var writer = File.AppendText($"{Name}.txt");
            writer.WriteLine(grade);
               }







        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }

    public class InMemoryBook : Book//derived from namedobject
    { 
        //this is a constructor method
        //book requires a name to be instantiated
        public InMemoryBook(string name) : base(name)
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









        //want to invoke the delegate inside of addgrade

        public override void AddGrade(double grade) 
        {
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs()); //eventargs is where you can pass along additional information about this event 
                }
            }
            else //how to create an exception:
            {
                throw new ArgumentException($"INVALID {nameof(grade)}"); //throwing exception and someone else has to catch it if they want to handle the condition
            }
        }
   

   //event can be a member of a class 
   //type is GradeAddedDelegate name is GradeAdded
   //now have a book class definition and every book object wil have a grade added event

   public override event GradeAddedDelegate GradeAdded; //this is just a field on the book class

        public override Statistics GetStatistics()
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


public const string CATEGORY = "Science";  //you access a static member using the type name 
  
    }
}