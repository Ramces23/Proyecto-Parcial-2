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
            Console.Clear();
            Console.Write("Nombre: ");
            Empleado[i].Nombre = Console.ReadLine();
            Console.Write("\nSueldo: ");
            Empleado[i].Salario = float.Parse(Console.ReadLine());
            Console.Clear();
        }
        public void Cargar() 
        {
            for (i = 0; i <= 4; i++)
            {
                i++;
                Console.WriteLine("Introdusca el nombre y el sueldo del empleado {0}", i);
                i--;
                IntEmp();


            }
        }
        public void SalarioMayor()
        {
            int y = 0;
            int c = 0;
            for ( i = 0; i <= 4; i++)
            {
                float p = Empleado[i].Salario;
                int z = 0;
                for (int e = 0; e <= 4; e++)
                {
                    if (p - Empleado[e].Salario >= 0)
                    {
                        z++;
                        if (p - Empleado[e].Salario == 0)
                        {
                            y++;
                        }
                    }

                }
          
                if (y > 1 & c <= 0)
                {
                    if (z == 5 )
                    {
                        Console.WriteLine("Hay {0} empleados con el mismo salario, por lo cual los siguientes empleados tienen el salario mayor: ", y );
 
                        for (int e = 0; e <= 4; e++)
                        {
                            if (p - Empleado[e].Salario == 0)
                            {
                                Console.WriteLine(Empleado[e].Nombre);
                            }

                        }
                        Console.WriteLine("Tienen un salario de: " + Empleado[i].Salario);
                        Console.ReadKey();
                        Console.Clear();
                        c++;
                    }
                }
                else
                {
                    if (z == 5 & y < 1)
                    {
                        Console.WriteLine("El empleado con el salario mayor es " + Empleado[i].Nombre);
                        Console.WriteLine("Tiene un salario de: " + Empleado[i].Salario);
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }   
        }
        public void VerEmpleado() 
        {
            if (i < 5)
            {
                Console.WriteLine("Nombre: {0}", Empleado[i].Nombre);
                Console.WriteLine("Salario: {0}", Empleado[i].Salario);
            }

        }
        public void BusEmpleado() 
        {
            String BusEmple = "";
            int z = 0;

            do
            {
                z = 0;
                Console.WriteLine("Escriba el nombre de su fichero: ");
                BusEmple = Console.ReadLine();
                i = 0;
                bool b;
                int c = 0;


                for (i = 0; i <= 4; i++)
                {
                    b = Empleado[i].Nombre.Contains(BusEmple);
                    if (b = false)
                    {
                        c++;
                    }
                    b = Empleado[i].Nombre.Contains(BusEmple);
                    if (b)
                    {
                        Console.WriteLine("ID de Empleado: {0}", i);
                        VerEmpleado();
                        c--;
                    }
                   else
                    {
                        if (z <= 0 )
                        {
                            if (c >= 5)
                            {
                                Console.WriteLine("No hay coincidencias ");
                                z++;
                            }
                        }
                    }
                }

            } while (z != 0);
            Console.WriteLine("Digite el ID del empleado que quiere editar: ");
            i = int.Parse(Console.ReadLine());
            IntEmp();

          
        }
    }
}
