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

            /*Leer 2 número y operar suma, resta, multiplicación*/
            /*
            int a;
            int b;

            Console.WriteLine("Introduce el primer número");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            b=int.Parse(Console.ReadLine());

            Console.WriteLine($"a+b={a + b}");
            Console.WriteLine($"a-b={a - b}");
            Console.WriteLine($"a*b={a * b}");
            */

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

            /*
            string name;
            int age = 0;
            bool isCorrect = false;

            Console.WriteLine("Bienvenido, introduce tu nombre:");
            name=Console.ReadLine();
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

            */
        }
    }
}
