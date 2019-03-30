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
                      
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} Min: {student.GetMinimumScore()} Max: {student.GetMaximumScore()}");
            }


            Console.ReadLine();
        }

        private static List<Student> CreateNewStudent()
        {
            List<string> studentsData = GetStudentDataFile();

            string name = "";
            string[] scores = Array.Empty<string>();
            int[] s = Array.Empty<int>();
            List<Student> students = new List<Student>();
            foreach (string line in studentsData)
            {
                Student student = new Student(name, s);
                string[] properties = line.Split(" ");
                scores = new string[properties.Length - 1];
                name = properties[0];
                    
                for (int i = 0; i < properties.Length; i++)
                {

                    if (i != 0)
                    {
                        scores[i-1] = properties[i];
                    }                   

                }
                        student.Name = name;
                        student.Scores = s;
                        s = new int[scores.Length];
                        s = Array.ConvertAll(scores, int.Parse);
                        students.Add(student);
            }            
            
            return students;
            
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