using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D252JP
{
    internal class ExampleMenu
    {
        public void Execute()
        {
            E6();

        }

        private void E1()
        {
            /*Leer 2 número y operar suma, resta, multiplicación*/
            
            int a;
            int b;

            Console.WriteLine("Introduce el primer número");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            b=int.Parse(Console.ReadLine());

            Console.WriteLine($"a+b={a + b}");
            Console.WriteLine($"a-b={a - b}");
            Console.WriteLine($"a*b={a * b}");
            

        }

        private void E2()
        {

            /*Leer 2 números y operar división y módulo*/
            float c;
            float d;

            Console.WriteLine("Introduce el primer número");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            d = int.Parse(Console.ReadLine());

            if (d != 0)
            {
                Console.WriteLine($"c/d={c / d}");
                Console.WriteLine($"c%d={c % d}");
            }
            else
            {
                Console.WriteLine("No se puede dividir entre 0");
            }
        }

        private void E3()
        {
            /*Leer una cantidad de días, convertirlo a años y semanas*/

            float d;

            Console.WriteLine("Introduce la cantidad de días");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine($"{d} en años es: {d / 365}");
            Console.WriteLine($"{d} en semanas es: {d / 7}");
        }

        private void E4()
        {
            /*Leer un año y mostrar si es bisiesto o no*/
            int year;
            Console.WriteLine("Introduce el año");
            year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("Es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("No es bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine("Es bisiesto");
                }
            }
            else
            {
                Console.WriteLine("No es bisiesto");
            }

        }

        private void E5()
        {
            /*Leer un número y mostrar si es negativo, positivo o cero*/
            int n;
            Console.WriteLine("Introduce un número");
            n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("Es positivo");
            }
            else if (n < 0)
            {
                Console.WriteLine("Es negativo");
            }
            else
            {
                Console.WriteLine("Es cero");
            }
        }

        private void E6()
        {
            /*Leer un número y mostrar si es divisible entre 7 y/o 13*/
            int n;
            Console.WriteLine("Introduce un número");
            n = int.Parse(Console.ReadLine());
            if (n % 7 == 0 && n % 13 == 0)
            {
                Console.WriteLine("Es divisible entre 7 y 13");
            }
            else if (n % 7 == 0)
            {
                Console.WriteLine("Es divisible entre 7");
            }
            else if (n % 13 == 0)
            {
                Console.WriteLine("Es divisible entre 13");
            }
            else
            {
                Console.WriteLine("No es divisible entre ninguno");
            }
        }

        private void E7()
        {
            /*Leer un número y mostrar si es par o impar*/

            int n;
            Console.WriteLine("Introduce un número");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }
        }

        private void E8()
        {
            /*Leer 3 notas, determinar su promedio TLS y escribir si aprobó o no*/
            float grade1;
            float grade2;
            float grade3;
            float finalGrade;

            Console.WriteLine("Introduce la primera nota");
            grade1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la segunda nota");
            grade2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la tercera nota");
            grade3 = float.Parse(Console.ReadLine());

            finalGrade = (grade1 + grade2 + 2 * grade3) / 4;

            if (finalGrade >= 12.5f)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Desaprobado");
            }
        }


        private void E9()
        {
            /*Leer 4 notas, 3 de promedio de clase y 1 de jurado, determinar su promedio TLS y escribir si aprobó o no*/
            float grade1;
            float grade2;
            float grade3;
            float grade4;
            float classroomGrade;
            float finalGrade;

            Console.WriteLine("Introduce la primera nota");
            grade1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la segunda nota");
            grade2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la tercera nota");
            grade3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la nota de jurado");
            grade4 = float.Parse(Console.ReadLine());

            classroomGrade = (grade1 + grade2 + 2 * grade3) / 4;

            finalGrade = (2 * classroomGrade + grade4) / 3;

            if (finalGrade >= 12.5f)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Desaprobado");
            }
        }

        private void E10()
        {
            /*Desarrollar una calculadora simple: leer 2 números, luego leer el símbolo de la operación a realizar (suma, resta, multiplicación, división y módulo) y ejecutar la operación.*/
            bool continueFlag = true;

            while (continueFlag)
            {
                float a;
                float b;
                string operation;

                Console.WriteLine("Introduce el primer número");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el segundo número");
                b = float.Parse(Console.ReadLine());

                Console.WriteLine("Introduce el signo de la operación o la palabra salir");
                operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"{a}+{b}={a + b}");
                        break;
                    case "-":
                        Console.WriteLine($"{a}-{b}={a - b}");
                        break;
                    case "*":
                        Console.WriteLine($"{a}*{b}={a * b}");
                        break;
                    case "/":
                        if (b != 0)
                        {
                            Console.WriteLine($"{a}/{b}={a / b}");
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir entre 0");
                        }
                        break;
                    case "%":
                        if (b != 0)
                        {
                            Console.WriteLine($"{a}%{b}={a % b}");
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir entre 0");
                        }
                        break;
                    case "salir":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }

        

        private void InitialExample()
        {

            string name;
            int age = 0;
            bool isCorrect = false;

            Console.WriteLine("Bienvenido, introduce tu nombre:");
            name = Console.ReadLine();
            Console.WriteLine($"Hola {name}");

            while (!isCorrect)
            {
                Console.WriteLine("Introduce tu edad:");
                age = int.Parse(Console.ReadLine());

                if (age >= 0 && age < 18)
                {
                    Console.WriteLine("Eres menor de edad");
                    isCorrect = true;
                }
                else if (age >= 18)
                {
                    Console.WriteLine("Eres mayor de edad");
                    isCorrect = true;
                }
                else
                {
                    Console.WriteLine("Tu edad no es válida");
                }
            }

            string option;
            Console.WriteLine("Introduce la opción:");
            Console.WriteLine("1. Calcular edad a la que te graduarás");
            Console.WriteLine("2. Calcular en cuántos años te vas a jubilar");
            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine($"Te graduarás cuando tengas {age + 4}");
                    break;
                case "2":
                    if (age >= 65)
                    {
                        Console.WriteLine("Ya estás jubilado");
                    }
                    else
                    {
                        Console.WriteLine($"Te jubilarás en {65 - age} años");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}
