using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMastery.Day7
{
    public class Student
    {
       
            public string Name;
            public int RollNo;
            public int Marks;

            public void ShowDetails()
            {
                Console.WriteLine($"Roll No: {RollNo} | Name: {Name} | Marks: {Marks}");
            }
            public string GetGrade()
            {
                if (Marks >= 90) return "A+";
                else if (Marks >= 80) return "A";
                else if (Marks >= 70) return "B";
                else if (Marks >= 60) return "C";
                else if (Marks >= 50) return "D";
                else if (Marks >= 40) return "E";
                else return "F";

            }
    }

   
}
