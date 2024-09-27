using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_de_mayor_a_menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            // Pedir al usuario que ingrese tres números
            Console.WriteLine("Dame el primer número");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dame el segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dame el tercer número");
            num3 = Convert.ToInt32(Console.ReadLine());

            // Llamar a los métodos para determinar el mayor y menor número
            NumeroMayor(num1, num2, num3);
            NumeroMenor(num1, num2, num3);

            // Pausar la consola para que el usuario vea los resultados antes de cerrar
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadLine();
        }

        private static void NumeroMayor(int num1, int num2, int num3)
        {
            // Determinar cuál es el mayor de los tres números
            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("El primer número es el mayor.");
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("El segundo número es el mayor.");
            }
            else
            {
                Console.WriteLine("El tercer número es el mayor.");
            }
        }

        private static void NumeroMenor(int num1, int num2, int num3)
        {
            // Determinar cuál es el menor de los tres números
            if (num1 <= num2 && num1 <= num3)
            {
                Console.WriteLine("El primer número es el menor.");
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                Console.WriteLine("El segundo número es el menor.");
            }
            else
            {
                Console.WriteLine("El tercer número es el menor.");
            }
        }
    }
}