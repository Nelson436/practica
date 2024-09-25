using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minipoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string nombre = "";
        int cantidad = 0;
        decimal precio = 0;
        Console.WriteLine("Ingresa nombre del producto");
        nombre = Console.ReadLine();
        Console.WriteLine("ingresa cantidad");
        cantidad=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingresa precio");
        precio=Convert.ToDecimal(Console.ReadLine());

        }
    }
}
