using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Course
    {
        private String cName;

        public String CName
        {
            get { return cName; }
            set { cName = value; }
        }
        private String cId;

        public String CId
        {
            get { return cId; }
            set { cId = value; }
        }
        private int credit;

        public int Credit
        {
            get { return credit; }
            set { credit = value; }
        }

        private double teachingHourPerWeek;

        public double TeachingHourPerWeek
        {
            get { return teachingHourPerWeek; }
            set { teachingHourPerWeek = value; }
        }



        private Section[] sections;
        private Faculty[] faculties;

        private int sectionCount;

        public int SectionCount
        {
            get { return sectionCount; }
            set { sectionCount = value; }
        }
        private int facultyCount;

        public int FacultyCount
        {
            get { return facultyCount; }
            set { facultyCount = value; }
        }

        public Course()
        {
            sections = new Section[50];
            faculties = new Faculty[200];
            sectionCount = 0;
            facultyCount = 0;
        }
        public Course(String cName,String cId,int credit,double teachingHourPerWeek)
        {
            this.cName = cName;
            this.cId = cId;
            this.credit = credit;
            this.teachingHourPerWeek = teachingHourPerWeek;
            sections = new Section[50];
           // faculties = new Faculty[200];
            sectionCount = 0;
            facultyCount = 0;
        }
        public void AddSection(params Section[] sections)
        {
            foreach (var section in sections)
            {
                if (sectionCount < 50)
                {
                    this.sections[sectionCount++] = section;
                }
                else
                    Console.WriteLine("Cant add more section");

            }
        }
        public void AddFaculty(params Faculty[] faculties)
        {
            foreach (var faculty in faculties)
            {
                if (facultyCount < 200)
                {
                    faculties[facultyCount++] = faculty;
                }
                else
                    Console.WriteLine("Cant add more faculty");

            }
        }
      
        public void ShowCourseInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Course Name :" + cName);
            Console.WriteLine("Course ID :" + cId);
            Console.WriteLine("course credit " +credit);
            Console.WriteLine("Weekly taken time :"+teachingHourPerWeek+" Hour");
        
       
            for (int i = 0; i < sectionCount; i++)
            {
                Console.WriteLine("Section Name : {0}\nFaculty Name :{1}", sections[i].SName, sections[i].Teacher.FName);

            }
        }
        public void ShowAllSections()
        {
            for (int i = 0; i < SectionCount; i++)
            {
                sections[i].ShowSectionInfo();
                Console.WriteLine();
            }
        }
        public void ShowAllFaculties()
        {
            for (int i = 0; i < facultyCount; i++)
            {
                faculties[i].ShowFacultyInfo();
                Console.WriteLine();
            }
        }

    }
}
