using System;
using System.Collections.Generic;

namespace Project 
{
    class Program
    {

       static void Main(string[] args) 
        {
            List<string> studentNames = new List<string>();
            List<int> studentGrades = new List<int>();

            bool addingStudents = true;

            Console.WriteLine("Wlecome to the Student Grade System!");
            while (addingStudents)
            {
                Console.WriteLine("\nEnter Student's name (or type 'Done' to finish)");
                string name = Console.ReadLine();

                if (name.ToLower() == "done")
                {
                    addingStudents = false;
                    break;
                }
                Console.WriteLine("Enter student's grade: ");
                if(int.TryParse(Console.ReadLine(), out int grade) ) 
                {
                    studentNames.Add(name);
                    studentGrades.Add(grade);
                }
                else
                {
                    Console.WriteLine("Invalid grade entered. Plases enter a number.");
                }
            }
            Console.WriteLine("\nStudents names and grades:");
            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.Write($"Student: {studentNames[i]}, Grade: {studentGrades[i]}, Result: ");

                if (studentGrades[i] >= 60)
                {
                    Console.WriteLine("Passed");
                }
                else 
                {
                    Console.WriteLine("Failed");
                }
            }
        }
    }
}
