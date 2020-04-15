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
        private List<double> grades;
        private string name;
    }
}