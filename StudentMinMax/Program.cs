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
            List<Student> student = GetStudentDataFile();
            Student students = new Student();
            students = CreateNewStudent(line);

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} Min: {student.GetMinimumScore()} Max: {student.GetMaximumScore()}");
            }


            Console.ReadLine();
        }

        private static Student CreateNewStudent(string line)
        {
            Student student = new Student();
            
            string[] properties = line.Split(" ");
            string[] scores = new string[properties.Length - 1];
            for (int i = 0; i < properties.Length; i++)
            {
                if(i == 0)
                {
                    student.Name = properties[0];
                }
                else
                {
                    scores[i-1] = properties[i];
                }
            }
            student.Scores = Array.ConvertAll(scores, int.Parse);
            return student;
            
        }

        private static List<Student> GetStudentDataFile()
        {
            List<Student> students = new List<Student>();
            foreach(string line in File.ReadAllLines(@"c:studentdata.txt"))
                {
                    Student student = new Student();
                    students.Add(student);
                }
            return students;
            //List<string> lines = File.ReadAllLines(@"c:studentdata.txt").ToList();
            //return lines;

        }
    }
}