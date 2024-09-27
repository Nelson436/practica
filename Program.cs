using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_primos
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Ingresa un número: ");
            if (int.TryParse(Console.ReadLine(), out int limite) && limite >= 1)
            {
                Console.WriteLine("Números desde 1 hasta " + limite + ":");

                for (int i = 1; i <= limite; i++)
                {
                    if (EsPrimo(i))
                    {
                        Console.WriteLine(i + " es primo.");
                    }
                    else
                    {
                        Console.WriteLine(i + " no es primo.");
                    }
                }

                // Verificar específicamente los números 3, 5 y 7
                MostrarPrimosEspecificos(limite);
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número entero válido mayor o igual a 1.");
            }
        }

        static bool EsPrimo(int numero)
        {
            if (numero < 2) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }

        static void MostrarPrimosEspecificos(int limite)
        {
            int[] primosEspecificos = { 3, 5, 7 };
            foreach (int primo in primosEspecificos)
            {
                // Solo mostrar si el primo es menor que el límite
                if (primo <= limite)
                {
                    Console.WriteLine(primo + " es primo.");
                }
            }
        }
    }
}