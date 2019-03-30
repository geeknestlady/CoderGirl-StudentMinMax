using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StudentMinMax
{
    public static class Program
    {
        public static void Main()
        {
            List<Student> students = CreateNewStudent();
            //Student students = new Student();
            //students = CreateNewStudent(line);

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} Min: {student.GetMinimumScore()} Max: {student.GetMaximumScore()}");
            }


            Console.ReadLine();
        }

        private static Student CreateNewStudent()
        {
            List<string> students = GetStudentDataFile();

            string name = "";
            foreach (string line in students)
            {
                string[] properties = line.Split(" ");

                for (int i = 0; i < properties.Length; i++)
                {
                    string[] scores = new string[properties.Length - 1];
                    if (i == 0)
                    {
                        name = properties[0];
                    }
                    else
                    {
                        scores[i - 1] = properties[i];
                    }

                    s = Array.ConvertAll(scores, int.Parse);
                }
            }
             int[] s = new int[scores.Length];
             Student student = new Student(name, s);            
            
            return student;
            
        }

        private static List<string> GetStudentDataFile()
        {
            List<string> students = new List<string>();
            foreach(string line in File.ReadAllLines(@"c:studentdata.txt"))
                {                    
                    students.Add(line);
                }
            return students;
            //List<string> lines = File.ReadAllLines(@"c:studentdata.txt").ToList();
            //return lines;

        }
    }
}