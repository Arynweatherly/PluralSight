using System.Collections.Generic;

namespace GradeBook{
    class Book 
    { 
        //constructor
        public Book()
        {
            
        }
        //make method for adding a grade . type is double and name of parameter is grade
    
        public void AddGrade(double grade) 
        {
            grades.Add(grade);
        }
        List<double> grades;
    }
}