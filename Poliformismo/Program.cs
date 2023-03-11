using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mujer Empleada = new Mujer();
            Empleada.nombre = "Angela Campos";
            Empleada.direccion = "Calle Hinojosa 125";
            Empleada.telefono = "84423575";
            Console.WriteLine("El nombre del cliente es: " + Empleada.nombre);
            Console.WriteLine("La direccion  del cliente es: " + Empleada.direccion);
            Console.WriteLine("El numero de telefono  del cliente es: " + Empleada.telefono);
            Console.WriteLine("Saludo-------------- ");
            Empleada.Saludar();
            Console.WriteLine("****************************");

            Hombre Cliente = new Hombre();
            Cliente.nombre = "Juan Robledo Castro";
            Cliente.direccion = "Calle Hinojosa 115";
            Cliente.telefono = "844235654";
            Console.WriteLine("El nombre del cliente es: "+ Cliente.nombre);
            Console.WriteLine("La direccion  del cliente es: " + Cliente.direccion);
            Console.WriteLine("El numero de telefono  del cliente es: " + Cliente.telefono);
            Console.WriteLine("Saludo-------------- ");


            Cliente.Saludar();
            Console.ReadKey();
        }
    }
}
