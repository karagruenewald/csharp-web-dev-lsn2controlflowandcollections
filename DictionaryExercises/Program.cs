using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            int iD;


            Console.WriteLine("Enter student information. Enter 0 to end.");

            do
            {
                Console.WriteLine("Student ID: ");
                string input = Console.ReadLine();
                iD = int.Parse(input);

                if (!Equals(iD, 0))
                {
                    Console.WriteLine("Enter Student name: ");
                    input = Console.ReadLine();
                    string studentName = input;
                    students.Add(iD, studentName);
                    //Console.ReadLine();
                }


            } while (!Equals(iD, 0));


            Console.WriteLine("Class Roster");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine("ID: " + student.Key + " Name: " + student.Value);
            }

        }


    }
}
