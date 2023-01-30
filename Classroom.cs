using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal class Classroom
    {
        public List<Student> StudentList = new List<Student>();
        public List<int> YearList = new List<int>();
        public List<double> GradeList = new List<double>();
        public List<string> NameList = new List<string>();

        public void addStudent(Student students)
        {
            StudentList.Add(students);

        }
        public string ShowStudent()
        {
            string results = "";
            foreach (var student in StudentList)
            {
                results += student.Name+"\n";
            }
            return results;
        }
        public int ShowAllAge()
        {
            foreach (var student in StudentList)
            {
                YearList.Add(student.Year);
            }
            return YearList.Sum();
        }

        public void SetGrade()
        {
            foreach (var student in StudentList)
            {
                GradeList.Add(student.Grade);
                NameList.Add(student.Name);
            }
        }
        public double ShowMaxGrade()
        {
            return GradeList.Max();
        }
        public double ShowMinGrade()
        {
            return GradeList.Min();
        }

        public string ShowMaxGradeName() {
            return NameList[GradeList.IndexOf(GradeList.Max())];
        }
        public string ShowMinGradeName()
        {
            return NameList[GradeList.IndexOf(GradeList.Min())];
        }
    }
}
