using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicialización de los números
            double num1 = 20;
            double num2 = 8;

            // Instancia de la clase operaciones
            Operaciones op = new Operaciones();
            double suma = op.Suma(num1, num2);
            double resta = op.Resta(num1, num2);
            double multiplicacion = op.Multp(num1, num2);
            double division = op.Div(num1, num2);

            // Mostrar los resultados en la consola
            Console.WriteLine("Resultados de las operaciones:");
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Resta: {resta}");
            Console.WriteLine($"Multiplicación: {multiplicacion}");
            Console.WriteLine($"División: {division}");

            // Pausa para que el usuario pueda ver los resultados
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }

    // Clase para realizar operaciones matemáticas básicas.
    class Operaciones
    {
        // Método para sumar dos números.
        public double Suma(double x, double y)
        {
            return x + y;
        }

        // Método para restar dos números.
        public double Resta(double x, double y)
        {
            return x - y;
        }

        // Método para multiplicar dos números.
        public double Multp(double x, double y)
        {
            if (x != 0 && y != 0)
            {
                return x * y;
            }
            else
            {
                Console.WriteLine("Uno de las variables es 0, por lo que el resultado será 0.");
                return 0;
            }
        }

        // Método para dividir dos números.
        public double Div(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                Console.WriteLine("El denominador es 0, no se puede dividir entre 0.");
                return 0;
            }
        }
    }
}