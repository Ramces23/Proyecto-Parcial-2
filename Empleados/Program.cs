using System;

namespace Empleados
{
    class Program
    {
        static void Main(string[] args)
        {
            Nomina Nom = new Nomina();
            int a = 0;
            do
            {
                Console.WriteLine(" ______________________________________________\n");
                Console.WriteLine(" |                Administracion               |\n");
                Console.WriteLine(" |_____________________________________________|\n");
                Console.WriteLine(" | 1 - Introducir empleados                    |\n");
                Console.WriteLine(" | 2 - cambiar los datos del empleado          |\n");
                Console.WriteLine(" | 3 - Ver el empleado con el mayor salario    |\n");
                Console.WriteLine(" | 4 - Salir del programa                      |\n");
                Console.WriteLine(" |_____________________________________________|\n");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Nom.Cargar();
                        break;
                    case 2:
                        Console.Clear();
                        if (Nom.Empleado[0].Salario <= 0)
                        {
                            Console.WriteLine("Actualmente no sean introducido empleados, por favor introduzcalos ");
                            Console.WriteLine("Presione enter para continuar ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Nom.BusEmpleado();
                        }
                        break;
                    case 3:
                        Console.Clear();
                        if (Nom.Empleado[0].Salario <= 0)
                        {
                            Console.WriteLine("Actualmente no sean introducido empleados, por favor introduzcalos ");
                            Console.WriteLine("Presione enter para continuar ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Nom.SalarioMayor();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Gracias por usar este software ");
                        Console.Clear();
                        break;

                }
            } while (a != 4);

        }
    }
}
