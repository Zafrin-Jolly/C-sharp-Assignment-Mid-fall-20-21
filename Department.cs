using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Department
    {
        private String depName;

        public String DepName
        {
            get { return depName; }
            set { depName = value; }

        }
        private Course[] courses;
       

        private int courseCount;

        public int CourseCount
        {
            get { return courseCount; }
            set { courseCount = value; }
        }
        public Department()
        {
            courses = new Course[50];
            courseCount = 0;
        }
        public Department(String depName)
        {
            this.depName = depName;
            courses = new Course[50];
            courseCount = 0;
        }
        public void AddCourse(params Course[] courses)
        {
            foreach (var course in courses)
            {
                if (courseCount < 50)
                {
                    this.courses[courseCount++] = course;
                }
                else
                    Console.WriteLine("Course is full");

            }
        }
        public void DeletCourse(Course course)
        {
            for (int i = 0; i < courseCount - 1; i++)
            {
                if (course.CId.Equals(courses[i].CId))
                {
                    for (int j = i; j < courseCount; j++)
                    {
                        courses[i] = courses[i + 1];
                    }

                    courseCount--;
                    break;
                }
            }
        }
        public void ShowDeptInfo()
        {
            Console.WriteLine("Department Name :" + depName);
        }
      
     
        public Course SearchCourse(string cId)
        {
            Course b = null;
            for (int i = 0; i < courseCount; i++)
            {
                if (courses[i].CId.Equals(cId))
                {
                    b = courses[i];
                    break;
                }
            }
            return b;
        }
        public void ShowAllCourses()
        {
            for (int i = 0; i < courseCount; i++)
            {
                courses[i].ShowCourseInfo();
                Console.WriteLine();

            }
        }

    }
}
