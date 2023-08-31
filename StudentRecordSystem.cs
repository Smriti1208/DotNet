using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Data;

namespace StudentRecordSystem
{
    interface IStudent
    {
        void AddNewStudent(int StudentId, string StudentName, int StudentContact, double Marks);
        void DisplayStudents();
    }
    class Program:IStudent
    {
        public object StudentName { get; set; }
        public object StudentId { get; set; }
        public object StudentContact { get; set; }
        public object TotalMarks { get; set; }

        public class Student
        {
            public int StudentId;
            public string StudentName;
            public int StudentContact;
            public double TotalMarks;
            public Student(int StudentId, string StudentName, int StudentContact, double Marks)
            {
                this.StudentId = StudentId;
                this.StudentName = StudentName;
                this.StudentContact = StudentContact;
                this.TotalMarks = Marks;
            }
            public void AddNewStudent(int StudentId, string StudentName, int StudentContact, double Marks)
            { 
                DataRow row = Student.NewRow();
                row[0] = StudentId;
                row[1] = StudentName;
                row[2] = StudentContact;
                row[3] = Marks;    
            }

            private static DataRow NewRow()
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
           Student[] students =
            {
                new Student(1, "Smriti K V", 3455677, 99),
                new Student(2, "Shreyas K V", 112323, 98),
                new Student(3, "Shraddha ", 346799000, 70),
                new Student(4, "Siddharth", 3455677, 89),
                new Student(5, "Shiya", 38888677, 88),
            };

            Console.WriteLine("Enter Students ID:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Students Name");
            string name = Console.ReadLine();


            const string file = @"C:\Users\skvantkar\OneDrive - First American Corporation\Documents\DotNet\DotnetTraining\SRS\StudentRecordSystem\Student.txt";

            string separator = ",";
            StringBuilder output = new StringBuilder();

            String[] heading = { "StudentId", "StudentName", "StudentContact", "TotalMarks" };
            output.AppendLine(string.Join(separator, heading));

            foreach (Student student in students)
            {
                String[] newLine = { student.StudentId.ToString(), student.StudentName, student.StudentContact.ToString(), student.TotalMarks.ToString() };
                output.AppendLine(string.Join(separator, newLine));
            }
        }

        public void DisplayStudents()
        {
            
            Console.WriteLine("Student List:");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Id: {StudentName}, Name: {StudentName}, Contact:{StudentContact}, Marks:{TotalMarks}");
            }
        }
        public void AddNewStudent(int StudentId, string StudentName, int StudentContact, double Marks)
        {
            throw new NotImplementedException();
        }
     
    }
}

