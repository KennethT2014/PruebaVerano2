using System;

namespace Prueba2
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            Console.WriteLine("Bienvenido al programa para comparar Libros");
            libro.ingresardatos();
            libro.imprimir();
            Console.WriteLine("Gracias por preferirnos!");

            Empleados empleados = new Empleados();
            Console.WriteLine("Bienvenido al programa de gestión de empleados");
            empleados.IngresarEmpleados();
            empleados.extra();
            Console.WriteLine("Gracias por preferirnos!");
        }
    }
}
