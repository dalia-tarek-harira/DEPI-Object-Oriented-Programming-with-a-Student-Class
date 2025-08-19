using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheetTwo
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public Student(string name, int age, double grade) 
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student Name Is: {Name}\nStudent Age Is: {Age}\nStudent Grade Is: {Grade}\n\n\n");
        }
    }
}
