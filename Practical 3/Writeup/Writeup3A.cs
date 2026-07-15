using System;

namespace StudentPerformance
{
    class Student
    {
        public string Name;
        public string RollNo;

        public int TotalMarks(int m1, int m2, int m3)
        {
            return m1 + m2 + m3;
        }

        public double Percentage(int total)
        {
            return total / 3.0;
        }

        public void Grade(double percentage)
        {
            if (percentage >= 75)
                Console.WriteLine("Grade : A");
            else if (percentage >= 60)
                Console.WriteLine("Grade : B");
            else if (percentage >= 50)
                Console.WriteLine("Grade : C");
            else
                Console.WriteLine("Grade : Fail");
        }

        public void Result(double percentage)
        {
            if (percentage >= 40)
                Console.WriteLine("Result : PASS");
            else
                Console.WriteLine("Result : FAIL");
        }
    }

    class Program
    {
        // Delegates
        delegate int TotalDelegate(int a, int b, int c);
        delegate double PercentageDelegate(int total);
        delegate void GradeDelegate(double percentage);
        delegate void ResultDelegate(double percentage);

        static void Main(string[] args)
        {
            Student s = new Student();

            Console.Write("Enter Roll Number: ");
            s.RollNo = Console.ReadLine();

            Console.Write("Enter Student Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Enter Marks of Subject 1: ");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks of Subject 2: ");
            int m2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks of Subject 3: ");
            int m3 = Convert.ToInt32(Console.ReadLine());

            // Assign methods to delegates
            TotalDelegate totalDel = s.TotalMarks;
            PercentageDelegate perDel = s.Percentage;
            GradeDelegate gradeDel = s.Grade;
            ResultDelegate resultDel = s.Result;

            // Invoke delegates
            int total = totalDel(m1, m2, m3);
            double percentage = perDel(total);

            Console.WriteLine("\n----- Student Performance -----");
            Console.WriteLine("Roll Number : " + s.RollNo);
            Console.WriteLine("Student Name: " + s.Name);
            Console.WriteLine("Total Marks : " + total);
            Console.WriteLine("Percentage  : " + percentage + "%");

            gradeDel(percentage);
            resultDel(percentage);

            Console.ReadKey();
        }
    }
}
