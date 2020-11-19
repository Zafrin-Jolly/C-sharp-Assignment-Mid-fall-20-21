using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Faculty
    {
        private String fName;

        public String FName
        {
            get { return fName; }
            set { fName = value; }
        }
        private String fId;

        public String FId
        {
            get { return fId; }
            set { fId = value; }
        }
        public Section[] fSection;
        public double teachingHourPerWeek;

        public double TeachingHourPerWeek
        {
            get { return teachingHourPerWeek; }
            set { teachingHourPerWeek = value; }
        }
        private int FacultyTotalSection;

        public int FacultytSection
        {
            get { return FacultyTotalSection; }
            set { FacultyTotalSection = value; }
        }
        public double WeeklyWorkingLoad { get; set; }

        public Faculty() { fSection = new Section[10]; }
        public Faculty (String fName,String fId,double teachingHourPerWeek)
        {
            this.fName = fName;
            this.fId = fId;
            this.teachingHourPerWeek=teachingHourPerWeek;
            fSection = new Section[10];
            WeeklyWorkingLoad = 0;
            FacultyTotalSection = 0;
        }
        public void AddFacultySection(Section section)
        {
            double temp = teachingHourPerWeek + section.c.TeachingHourPerWeek;
            if (temp <= 21)
            {
                fSection[FacultyTotalSection++] = section;
                WeeklyWorkingLoad += section.c.TeachingHourPerWeek;
            }
            else
            Console.WriteLine("We can't assign {0} for any section in this course.\nBecause his weekly load hour cross the maximum limit 21.", section.Teacher.fName);
        }

        public void ShowFacultyInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Faculty Name :" + fName);
            Console.WriteLine("Faculty ID :" + fId);
            Console.WriteLine("Weekly Working Load :" + WeeklyWorkingLoad + " Hour");
            Console.WriteLine();
            Console.WriteLine(" Taken Sections are : ");

            for (int i = 0; i < FacultyTotalSection; i++)
            {
                Console.WriteLine("* Course Name: {0}\n* Section Name : {1}", fSection[i].c.CName, fSection[i].SName);
                Console.WriteLine();
            }
            Console.WriteLine();
        }


    }
}
