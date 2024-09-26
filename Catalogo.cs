using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_2
{
    internal class Catalogo
    {

        private static List<Articulo> Inventario { get; set; }

        public static void LlenarCatalogo()

        {
            Inventario = new List<Articulo>
            {
                new Articulo {Nombre="Jabon",Precio=18.9f,ID=1 },
                new Articulo {Nombre="Mayonesa",Precio=20.6f,ID=2 },
                new Articulo {Nombre="Tomate",Precio=10.9f,ID=3 },
                new Articulo {Nombre="Carne",Precio=19.8f,ID=4 },
                new Articulo {Nombre="Huevos",Precio=30f,ID=5 },
            };

        }
        public static void MostrarCatalogo()

        {
            LlenarCatalogo();
            foreach (Articulo art in Inventario)
            {
                Console.WriteLine($"{art.ID} - {art.Nombre} - {art.Precio}\n");
            }

        }
        public static Articulo BuscarArticuloPorID(int artID)
        {
            return Inventario.Find(articulo => articulo.ID.Equals(artID));
        }

    }
}