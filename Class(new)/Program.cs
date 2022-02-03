using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program 
{
    class Students
    {
        public string name = "Kate";
        public static string otherName = "Kat";
        public string grade;

        public Students()
        {
            grade = Console.ReadLine();
        }
    }

    static void Main(string[] args)
    {
        Students theStudent = new Students();
        Console.Write(theStudent.name);
        Students theGrade = new Students();
        Console.Write(theGrade.grade);

        Console.Write(Students.otherName);
    }
}
