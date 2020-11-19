using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------******-----------------------");
            Console.WriteLine("------Welcome to University Management System-----");
            Console.WriteLine();
            Console.WriteLine("    ------KURATOLI SOFTWARE SOLUTION----------");
            //Creating Departments
            Department d1 = new Department("CSE");
            Department d2 = new Department("EEE");
            Department d3 = new Department("BBA");
            //creating courses
            d1.ShowDeptInfo();
            Course c1 = new Course("C", "101", 4, 4);
            Course c2 = new Course("Data structure lab", "102", 1, 3);
            Course c3 = new Course("C#", "103", 3,5);
            Course c4 = new Course("DC", "124", 4, 4);
            Course c5 = new Course("EC", "1045", 2, 3);
            Course c6 = new Course("DLC", "103", 3, 5);
            Course c7 = new Course("Management", "1234", 4, 4);
            Course c8 = new Course("Accounting", "1072", 1, 3);
            Course c9 = new Course("Economics", "1037", 3, 5);
            //adding courses to departments
            d1.AddCourse(c1,c2,c3);
            Console.WriteLine();
          
            d2.AddCourse(c4,c5,c6);
            Console.WriteLine();
           
            d3.AddCourse(c7,c8,c9);
            d1.ShowAllCourses();
            d2.ShowAllCourses();
            d3.ShowAllCourses();
            
            Console.WriteLine("--------------------------------------------");
            Faculty f1 = new Faculty("Zafrin Sultana", "1234", 2.30);
            Faculty f2 = new Faculty("Afrin khan", "4567", 4.00);
            Faculty f3 = new Faculty("Tisha khandokar", "1344", 1.30);
            Faculty f4 = new Faculty("Afrida Islam", "4232", 4.00);
            //creating sections
            Section s1 = new Section("jupiter", "001",f1,c1);
            Section s2 = new Section("Moon", "010",f2,c6);
            Section s3 = new Section("Sun", "100",f4,c9);
            Section s4 = new Section("jupiter", "001", f3, c6);
            Section s5 = new Section("jupiter", "001", f4, c3);
            Section s6 = new Section("jupiter", "001", f2, c5);
            Console.WriteLine("---------------------------------------------");
            //Adding them to course
            c1.AddSection(s1,s2,s3);
            c2.AddSection(s1, s2, s3);
            c3.AddSection(s5, s1, s2);
            c4.AddSection(s3, s4, s1);
            c5.AddSection(s1, s2, s3);
            c6.AddSection(s1, s2, s5);
            c7.AddSection(s5, s2, s3);
            c8.AddSection(s1, s2, s4);
            //Creating faculty 
            // c1.ShowAllFaculties();
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            //c1.ShowAllSections();
            Console.WriteLine();

           

            f1.AddFacultySection(s1);
            f2.AddFacultySection(s2);
            f1.AddFacultySection(s6);
            f2.AddFacultySection(s3);
            f3.AddFacultySection(s2);
            f3.AddFacultySection(s3);
            f4.AddFacultySection(s5);
           
            Console.WriteLine();
            f1.ShowFacultyInfo();
            Console.WriteLine();
            f2.ShowFacultyInfo();
            Console.WriteLine();
            f3.ShowFacultyInfo();
            Console.WriteLine();
            f4.ShowFacultyInfo();




        }
    }
}