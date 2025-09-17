using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D252JP.School
{
    internal class Classroom
    {
        private List<Student> students;
        private string name;

        public string Name { get { return name; } }
        public List<Student> Students { get { return students; } }

        public Classroom(string name)
        {
            this.name = name;
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public int GetPassedAmount()
        {
            int count = 0;
            foreach (Student student in students)
            {
                if (student.GetFinalGrade() >= 12.5f)
                {
                    count++;
                }
            }
            return count;
        }

        public int GetFailedAmount()
        {
            return students.Count - GetPassedAmount();
        }

        public List<Student> GetPassedStudentList()
        {
            List<Student> list = new List<Student>();   
            foreach (Student student in students)
            {
                if (student.GetFinalGrade() >= 12.5f)
                {
                    list.Add(student);
                }
            }
            return list;
        }

        public List<Student> GetFailedStudentList()
        {
            List<Student> list = new List<Student>();
            foreach (Student student in students)
            {
                if (student.GetFinalGrade() < 12.5f)
                {
                    list.Add(student);
                }
            }
            return list;
        }

        public float GetAverage()
        {
            float result = 0;
            foreach (Student student in students)
            {
                result += student.GetFinalGrade();
            }
            return result / students.Count; 
        }


    }
}
