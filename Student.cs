using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D252JP
{
    internal class Student
    {
        private string code;
        private string name;
        private float grade1;
        private float grade2;
        private float grade3;

        public Student(string code, string name, float grade1, float grade2, float grade3)
        {
            this.code = code;
            this.name = name;
            this.grade1 = grade1;
            this.grade2 = grade2;
            this.grade3 = grade3;
        }

        public string GetData()
        {
            return $"{code} - {name} - {grade1} - {grade2} - {grade3}";
        }
        
        public float GetFinalGrade()
        {
            return (grade1 + grade2 + grade3 * 2) / 4;
        }
    }
}
