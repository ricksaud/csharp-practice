using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentGradeSystem;

namespace StudentGradeSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Student> students = new List<Student>();

            bool keepRunning = true;


            while (keepRunning) {


                Console.WriteLine("Select the option: ");
                Console.WriteLine(" 1 - Add Student");
                Console.WriteLine(" 2 - Add Grade to Student");
                Console.WriteLine(" 3 - View Report");
                Console.WriteLine(" 4 - Exit");


                string optionText = Console.ReadLine();
                bool isValidOption = int.TryParse(optionText, out int option);

                if (!isValidOption || option > 4 || option < 1) {

                    Console.WriteLine("Please, provide one of the options available");
                    continue;
                }





                switch (option)
                {
                    case 1:
                        Console.Write("Enter the student name: ");
                        string studentName = Console.ReadLine();

                        Student newStudent = new Student(studentName);

                        students.Add(newStudent);

                        Console.WriteLine("Student added successfully!");
                        break;

         

                    case 2:

                        if (students.Count == 0)
                        {
                            Console.WriteLine("There are no students registered.");
                            break;
                        }

                        int studentNumber = 1;

                        foreach (Student student in students)
                        {
                            Console.WriteLine($"{studentNumber} - {student.Name}");
                            studentNumber++;
                        }

                        Console.Write("Please, select one of the students by the number: ");
                        string studentSelectedText = Console.ReadLine();

                        bool isStudentValid = int.TryParse(studentSelectedText, out int studentSelected);

                        if (!isStudentValid || studentSelected < 1 || studentSelected > students.Count)
                        {
                            Console.WriteLine("Please, select a valid option.");
                            break;
                        }

                        Console.Write("What is the grade? ");
                        string gradeInText = Console.ReadLine();

                        bool isGradeValid = double.TryParse(gradeInText, out double studentGrade);

                        if (!isGradeValid || studentGrade > 10 || studentGrade < 0)
                        {
                            Console.WriteLine("Please, provide a valid grade.");
                            break;
                        }

                        Student selectedStudent = students[studentSelected - 1];

                        selectedStudent.AddGrade(studentGrade);

                        Console.WriteLine($"Grade added successfully to {selectedStudent.Name}!");

                        break;


                    case 3:
                        if (students.Count == 0)
                        {
                            Console.WriteLine("There are no students registered.");
                            break;
                        }

                        studentNumber = 1;

                        foreach (Student student in students)
                        {
                            Console.WriteLine($"{studentNumber} - {student.Name}");
                            Console.WriteLine($"Average: {student.CalculateAverage():F2}");
                            if (student.IsPassing())
                            {
                                Console.WriteLine("Status : Passed");
                            }
                            else
                            {
                                Console.WriteLine("Status : Not Passed");
                            }
                            studentNumber++;
                        }


                        break;

                    case 4:
                        keepRunning = false;
                        break;



                }




            }


            

        }
    }
}
