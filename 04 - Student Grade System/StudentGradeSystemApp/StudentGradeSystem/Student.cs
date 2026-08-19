using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeSystem
{
    public class Student
    {

       

        // Get and set are auto-properties and say this data can be read and altered outisde the class.
        public string Name { get; set; }
        public List<double> Grades { get; set; }



        // This is the constructor. Special method that runs automatically when i cretae a new student
        public Student(string name) {

            Name = name;
            Grades = new List<double>();
        
        }



        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }


        public double CalculateAverage()
        {

            if (Grades.Count == 0)
            {
                return 0;
            }

            return Grades.Average();

        }


        public bool IsPassing()
        {
            double passingGrade = 7.0;
            return CalculateAverage() >= passingGrade;
         
        }

    }
}
