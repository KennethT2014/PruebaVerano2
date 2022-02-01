using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba2
{
    class Libro
    {
        private string[] isbn = new string[5];
        private string[] titulo = new string[5];
        private string[] autor = new string[5];
        private float[] numPaginas = new float[5];
        public string[] ISBN { get { return isbn; } set { isbn = value; } }
        public string[] Titulo { get { return titulo; } set { titulo = value; } }
        public string[] Autor { get { return autor; } set {  autor = value; }  }
        public float[] NumPaginas { get { return numPaginas; } set {  numPaginas = value;  }  }

        public void ingresardatos()
        {
            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"\n Ingresar el ISBN {i+1}: ");
                isbn[i] = Console.ReadLine();
                Console.WriteLine($"\n Ingresar el Título del Libro {i+1}: ");
                titulo[i] = Console.ReadLine();
                Console.WriteLine($"\n Ingresar al Autor del Libro {i+1}: ");
                autor[i] = Console.ReadLine();
                Console.WriteLine($"\n Ingrese el número de páginas del Libro {i+1}: ");
                numPaginas[i] = Console.Read();
            }
        }

        public void imprimir()
        {
            int k, l;
            k = 0;
            l = 0;
            for(int f = 0; f < 5; f++)
            {
                if(numPaginas[f] < numPaginas[f+1])
                {
                    k = f + 1;
                }
                else
                {
                    if (numPaginas[f] == numPaginas[f + 1])
                    {
                        k = f;
                        l = f + 1;
                    }
                }
            }
            if(k != l)
            {
                Console.WriteLine($"El Autor del libro con más páginas es {autor[k]} y su Libro {titulo[k]} tiene {numPaginas[k]} páginas");
            }
            else
            {
                if( k == l)
                {
                    Console.WriteLine($"Los Autores con el mayor número de páginas son: \n{autor[k]} & {autor[l]}\n cuyos títulos son: \n {titulo[k]} & {titulo[l]} \n con un número de páginas de {numPaginas[k]}");
                }
            }
        }
    }
}
