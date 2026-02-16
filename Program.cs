using System;

namespace EXP03
{
    class StudentDetails
    {
        public int rollNo;
        public string name;
        public int mathMarks;
        public int scienceMarks;
        public int englishMarks;

    }

    class CalculateStudentMarks
    {
        public int calculatemarks(StudentDetails s)
        {
            return s.mathMarks + s.scienceMarks + s.englishMarks;
        }

        public float calculatePercentage(StudentDetails s)
        {
            int total = calculatemarks(s);
            return total / 3.0f;
        }
    }


    class StudentDetailsPrinter
    {
        public void displayDetails(StudentDetails s, int total, float percentage)
        {
                Console.WriteLine("Student Name : " + s.name);
                Console.WriteLine("Roll Number  : " + s.rollNo);
                Console.WriteLine("Total Marks  : " + total);
                Console.WriteLine("Percentage   : " + percentage + "%");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("EXPERIMENT NO - 03");

                //OBJECT FOR STUDENT DETAILS CLASS
                StudentDetails student = new StudentDetails();
                student.rollNo = 1;
                student.name = "Neha Patil";
                student.mathMarks = 92;
                student.scienceMarks = 75;
                student.englishMarks = 99;

                // OBJECT FOR CALCULATE MARKS
                CalculateStudentMarks mrk = new CalculateStudentMarks();
                int total = mrk.calculatemarks(student);
                float percentage = mrk.calculatePercentage(student);

                //OBJECT FOR DISPLAY STUDENT DETAILS
                StudentDetailsPrinter detailPrt = new StudentDetailsPrinter();
                detailPrt.displayDetails(student,total, percentage);
        }
    }
}
