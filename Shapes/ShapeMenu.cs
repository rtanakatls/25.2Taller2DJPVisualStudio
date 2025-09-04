using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D252JP.Shapes
{
    internal class ShapeMenu
    {
        public void Execute()
        {
            ShowMenu();
        }

        private void ShowMenu()
        {
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine("Introduce la figura a operar: ");
                Console.WriteLine("1. Rectángulo");
                Console.WriteLine("2. Triángulo");
                Console.WriteLine("3. Círculo");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        OperateRectangle();
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                continueFlag = Continue();
            }

        }

        private bool Continue()
        {
            bool returnValue = true;
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("¿Desea introducir una nueva figura? Introduce S para si y N para no");
                string option = Console.ReadLine();
                if (option == "S")
                {
                    returnValue = true;
                    continueFlag = false;
                }
                else if (option == "N")
                {

                    returnValue = false;
                    continueFlag = false;
                }
                else
                {
                    Console.WriteLine("Opción no válida");
                }
            }
            return returnValue;
        }

        private void OperateRectangle()
        {
            float b;
            float h;
            Console.WriteLine("Introduce la base");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura");
            h = float.Parse(Console.ReadLine());
            Rectangle r = new Rectangle(b, h);
            Console.WriteLine($"El área del rectángulo es: {r.GetArea()}");
        }
    }
}
