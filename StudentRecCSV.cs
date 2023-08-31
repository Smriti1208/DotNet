using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace StudentCSV
{
    interface IStudent
    {
        void AddNewStudent(int id, string name, int contact, double marks);
       
        void DeleteStudent(int id);
        DataTable GetAllStudents();
    }

    class Student : IStudent
    {
        private DataTable stdTable;
        public Student()
        {
            stdTable = new DataTable();
            stdTable.Columns.Add("stdId", typeof(int));
            stdTable.Columns.Add("stdName", typeof(string));
            stdTable.Columns.Add("stdContact", typeof(int));
            stdTable.Columns.Add("stdMarks", typeof(double));
            stdTable.AcceptChanges();
        }
        public void AddNewStudent(int id, string name, int contact, double marks)
        {
            //Create a row with the matching schema
            DataRow row = stdTable.NewRow();
            row[0] = id;
            row[1] = name;
            row[2] = contact;
            row[3] = marks;
            stdTable.Rows.Add(row);
            stdTable.AcceptChanges();
        }

        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAllStudents()
        {
            return stdTable;
        }


    }

    class EmpFactory
    {
        public static IStudent GetComponent()
        {
            return new Student();
        }
    }
    class StudentRecCSV
    {
        const string fileName = @"C:\Users\skvantkar\source\repos\StudentCSVRec\StudentCSV\Students.csv";
        static IStudent std = EmpFactory.GetComponent();
        static void Main(string[] args)
        {
            std.AddNewStudent(1, "Smriti", 7890654, 99);
            std.AddNewStudent(2, "Shreyas", 665453424, 80);
            std.AddNewStudent(3, "Shraddha", 564324567, 77);
            std.AddNewStudent(4, "Shiya", 876567876, 85);
            std.AddNewStudent(5, "Aarohi", 6543456, 62);
            std.AddNewStudent(6, "Sejal", 876543456, 90);

            string content = File.ReadAllText(fileName);
            var processing = true;
            do
            {
                string choice = utilities.GetString(content);
                processing = processMenu(choice);

            } while (processing);
        }

        private static bool processMenu(string choice)
        {
            switch (choice)
            {
                case "N":
                    return addingHelper();
                case "U":
                case "F":
                    return findingHelper();
                case "D":
                    return true;
                default:
                    return false;
            }
        }

        private static bool findingHelper()
        {
            var table = std.GetAllStudents();
            int id = utilities.GetInteger("Enter the Id to find");
            foreach (DataRow row in table.Rows)
            {
                if (row[0].ToString() == id.ToString())
                    Console.WriteLine($"{row[0]} with Name {row["name"]}");
            }
            return true;
        }

        private static bool addingHelper()
        {
            int id = utilities.GetInteger("Enter the ID for this Employee");
            string name = utilities.GetString("Enter the Name of this Employee");
            int contact = utilities.GetInteger("Enter the contact of this Employee");
            double marks = utilities.GetDouble("Enter the students marks");
            std.AddNewStudent(id, name, contact, marks);
            Console.WriteLine("Student added successfully");
            return true;
        }
    }

}
    

