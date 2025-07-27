using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("=== CALCULADORA ===");

                Console.Write("Ingrese el primer número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la operación (+, -, *, /): ");
                string operacion = Console.ReadLine();

                double resultado = 0;
                bool operacionValida = true;

                switch (operacion)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "*":
                        resultado = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            resultado = num1 / num2;
                        else
                        {
                            Console.WriteLine(" No se puede dividir por cero.");
                            operacionValida = false;
                        }
                        break;
                    default:
                        Console.WriteLine(" Operación no válida.");
                        operacionValida = false;
                        break;
                }

                if (operacionValida)
                    Console.WriteLine($" Resultado: {resultado}");

                Console.Write("\n¿Deseás realizar otra operación? (s/n): ");
                opcion = Console.ReadLine();

            } while (opcion.ToLower() == "s");

            Console.WriteLine("¡Gracias por usar la calculadora!");
        }
    }
}
