using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D252JP.School
{
    internal class SchoolMenu
    {
        private List<Classroom> classrooms;

        public SchoolMenu()
        {
            classrooms = new List<Classroom>();
        }
        public void Execute()
        {
            ShowSchoolMenu();
        }

        private void ShowSchoolMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Seleccionar una opción");
                Console.WriteLine("1. Crear un salón");
                Console.WriteLine("2. Seleccionar un salón");
                Console.WriteLine("0. Salir");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        CreateClassroom();
                        break;
                    case "2":
                        SelectClassroom();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }

        private void CreateClassroom()
        {
            Console.WriteLine("Introduce el nombre del salón");
            string name= Console.ReadLine();
            classrooms.Add(new Classroom(name));
        }

        private void SelectClassroom()
        {
            Console.WriteLine("Introduce el número del salón que quiere seleccionar:");
            for(int i = 0; i < classrooms.Count; i++)
            {
                Console.WriteLine($"{i}. {classrooms[i].Name}");
            }
            int option= int.Parse(Console.ReadLine());
            if (option >= 0 && option < classrooms.Count)
            {
                ShowClassroomMenu(classrooms[option]);
            }
            else
            {
                Console.WriteLine("El salón es inválido");
            }
        }

        private void ShowClassroomMenu(Classroom classroom)
        {
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine($"Salón: {classroom.Name}");
                Console.WriteLine("Seleccionar una opción");
                Console.WriteLine("1. Añadir alumno al salón");
                Console.WriteLine("2. Remover alumno del salón");
                Console.WriteLine("3. Obtener la cantidad de aprobados");
                Console.WriteLine("4. Obtener la cantidad de desaprobados");
                Console.WriteLine("5. Obtener la lista de aprobados");
                Console.WriteLine("6. Obtener la lista de desaprobados");
                Console.WriteLine("7. Obtener el promedio del salón");
                Console.WriteLine("0. Salir");

                string option = Console.ReadLine();
                switch(option) 
                {
                    case "1":
                        AddStudent(classroom);
                        break;
                    case "2":
                        RemoveStudent(classroom);
                        break;
                    case "3":
                        ShowPassedAmount(classroom);
                        break;
                    case "4":
                        ShowFailedAmount(classroom);
                        break;
                    case "5":
                        ShowPassedList(classroom);
                        break;
                    case "6":
                        ShowFailedList(classroom);
                        break;
                    case "7":
                        ShowAverage(classroom);
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;

                }
            }
        }

        private void AddStudent(Classroom classroom)
        {
            Console.WriteLine("Introduce el nombre del alumno");
            string name = Console.ReadLine();
            Console.WriteLine("Introduce la nota 1");
            float grade1=float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la nota 2");
            float grade2=float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la nota 3");
            float grade3=float.Parse(Console.ReadLine());

            classroom.AddStudent(new Student(name, grade1, grade2, grade3));    
        }

        private void RemoveStudent(Classroom classroom)
        {
            Console.WriteLine("Selecciona el alumno a eliminar");
            for (int i = 0; i < classroom.Students.Count; i++)
            {
                Console.WriteLine($"{i}. {classroom.Students[i].GetData()}");
            }
            int option = int.Parse(Console.ReadLine());
            if (option >= 0 && option < classroom.Students.Count)
            {
                Student student = classroom.Students[option];
                classroom.RemoveStudent(student);
                Console.WriteLine($"Se eliminó a: {student.GetData()}");
            }
            else
            {
                Console.WriteLine("La opción no es válida");
            }
        }

        private void ShowPassedAmount(Classroom classroom)
        {
            Console.WriteLine($"Aprobaron: {classroom.GetPassedAmount()}");
        }
        private void ShowFailedAmount(Classroom classroom)
        {
            Console.WriteLine($"Desaprobaron: {classroom.GetFailedAmount()}");
        }
        private void ShowPassedList(Classroom classroom)
        {
            Console.WriteLine($"Aprobaron:");
            foreach(Student student in classroom.GetPassedStudentList())
            {
                Console.WriteLine(student.GetData());
            }
        }
        private void ShowFailedList(Classroom classroom)
        {
            Console.WriteLine($"Desaprobaron:");
            foreach (Student student in classroom.GetFailedStudentList())
            {
                Console.WriteLine(student.GetData());
            }
        }
        private void ShowAverage(Classroom classroom)
        {
            Console.WriteLine($"Promedio: {classroom.GetAverage()}");
        }
    }
}
