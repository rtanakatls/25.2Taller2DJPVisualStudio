using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D252JP
{
    internal class Menu
    {
        private List<Student> students;

        public Menu()
        {
            students = new List<Student>();
        }

        public void Execute()
        {
            ShowMenu();
        }

        private void ShowMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Selecciona una opción: ");
                Console.WriteLine("1. Añadir un alumno");
                Console.WriteLine("2. Mostrar todos los alumnos");
                Console.WriteLine("3. Remover alumno");
                Console.WriteLine("0. Salir");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        ShowAllStudents();
                        break;
                    case "3":
                        RemoveStudent();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                }
            }
        }

        private void AddStudent()
        {
            string code;
            string name;
            float grade1;
            float grade2;
            float grade3;

            Console.WriteLine("Introduce el nombre");
            name = Console.ReadLine();
            Console.WriteLine("Introduce el código");
            code = Console.ReadLine();
            Console.WriteLine("Introduce la primera nota");
            grade1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la segunda nota");
            grade2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la tercera nota");
            grade3 = float.Parse(Console.ReadLine());
            Student student = new Student(code, name, grade1, grade2, grade3);
            students.Add(student);
        }

        private void ShowAllStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.GetData()} - Promedio final: {student.GetFinalGrade()}");
            }
        }

        private void RemoveStudent()
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i}. - {students[i].GetData()}");
            }

            Console.WriteLine("Introduce el índice del alumno a eliminar");
            int index = int.Parse(Console.ReadLine());
            if (index >= 0 && index < students.Count)
            {
                Student s=students[index];
                students.RemoveAt(index);
                Console.WriteLine($"Se eliminó a: {s.GetData()}");
            }
            else
            {
                Console.WriteLine("El índice no es válido");
            }
        } 
    }
}
