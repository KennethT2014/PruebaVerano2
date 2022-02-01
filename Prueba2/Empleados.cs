using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba2
{
    class Empleados
    {
        private string[] nombre = new string[5];
        private float[] edad = new float[5];
        private float[] salario = new float[5];
        private float[] comision = new float[5];

        public string[] Nombre { get { return nombre; } set { nombre = value; } }
        public float[] Edad { get { return edad; } set { edad = value; } }
        public float[] Salario { get { return salario; } set { salario = value; } }
        public float[] Comision { get { return comision; } set { comision = value; } }

        public void IngresarEmpleados()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el nombre del empleado {i+1}: ");
                nombre[i] = Console.ReadLine();
                Console.WriteLine($"Ingrese la edad del empleado {i+1}: ");
                edad[i] = Console.Read();
                Console.WriteLine($"Ingrese el Salario del empleado {i+1}: ");
                salario[i] = Console.Read();
                Console.WriteLine($"Ingrese la comisión del empleado {i+1}: ");
                comision[i] = Console.Read();
            }
        }

        public void extra()
        {
            float extra;
            extra = 200;
            for(int k = 0; k < 5; k++)
            {
                if(edad[k] < 25 || comision[k] > 349)
                {
                    salario[k] = salario[k] + extra;
                }

                if(edad[k] > 35 || comision[k] > 199)
                {
                    salario[k] = salario[k] + extra;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"El nombre del empleado {i+1} es {nombre[i]} ");
                Console.WriteLine($"La edad del empleado {i+1} es {edad[i]} ");
                Console.WriteLine($"El Salario del empleado {i+1} es {salario[i]} ");
                Console.WriteLine($"La comisión del empleado {i+1} es {comision[i]} ");
            }
        }
    }
}
