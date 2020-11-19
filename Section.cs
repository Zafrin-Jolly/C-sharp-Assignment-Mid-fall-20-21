using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Section
    {
        private String sName;

        public String SName
        { 
            get { return sName; }
            set { sName = value; }
        }
        private String sId;

        public String SId
        {
            get { return sId; }
            set { sId = value; }
        }

        public Faculty Teacher;
        public Course c;

        public Section() { }
        public Section(String sName,String sId,Faculty Teacher,Course c)
        {
            this.sName = sName;
            this.sId = sId;
            this.Teacher = Teacher;
            this.c = c;
        }
        public void ShowFacultyInfo()
         {
             Console.WriteLine("Faculty Name :" + this.Teacher.FName);
             Console.WriteLine("Faculty ID :" + this.Teacher.FId);
            Console.WriteLine();
        } 
      


        public void ShowSectionInfo()
        {
            Console.WriteLine("Section Name :" +sName );
            Console.WriteLine("section ID :" +sId);
            Console.WriteLine();

        }

    }
}
