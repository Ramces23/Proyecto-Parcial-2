using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados
{
    public class Nomina
    {
        public struct Empleados
        {
            public String Nombre;
            public float Salario;
        }
        public Empleados[] Empleado = new Empleados[5];
        public int i;
        public void IntEmp()
        {
            Console.Write("Nombre: ");
            Empleado[i].Nombre = Console.ReadLine();
            Console.Write("\nSueldo: ");
            Empleado[i].Salario = float.Parse(Console.ReadLine());
        }
        public void Cargar() 
        {
            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine("Introdusca el nombre y el sueldo del empleado {0}", i++);
            }
        }
        public void SalarioMayor()
        { 
            for (int i = 0; i <= 4; i++)
            {
                float p = Empleado[i].Salario;
                int z = 0;
                for (int e = 0; e <= 4; e++)
                {
                    if (p - Empleado[e].Salario >= 0)
                    {
                        z++;
                    }
                }

                if (z == 10)
                {
                    Console.WriteLine("El mayor sueldo es: " + Empleado[i].Salario);

                    Console.ReadKey();
                    Console.Clear();

                }
            }   
        }
        public void VerEmpleado() 
        {
            Console.WriteLine("Nombre: {0}", Empleado[i].Nombre);
            Console.WriteLine("Salario: {0}", Empleado[i].Salario);

        }
        public void BusEmpleado() 
        {
            String BusEmple = "";
            Console.WriteLine("Escriba el nombre de su fichero: ");
            BusEmple = Console.ReadLine();
            i = -1;
            do
            {
                i++;
            } while (BusEmple != Empleado[i].Nombre);
            i++;
          
        }
    }
}
