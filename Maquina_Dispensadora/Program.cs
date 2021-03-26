using System;

namespace Maquina_Dispensadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa creado por Ramces Batista Peña ");
            Console.WriteLine("Presione enter para continuar ");
            Console.ReadKey();
            Console.Clear();
            Producto Pro = new Producto();
            Pro.LlenarMaquina();
            int p = 0;
            int i = 0;
            int z = 0;

            do
            {
                Console.WriteLine(" ______________________________________________\n");
                Console.WriteLine(" |            Menu de administracion           |\n");
                Console.WriteLine(" |_____________________________________________|\n");
                Console.WriteLine(" | 1 - Ir a la Maquina dispensadora            |\n");
                Console.WriteLine(" | 2 - Revisar las ventas                      |\n");
                Console.WriteLine(" |_____________________________________________|\n");
                z = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (z)
                {
                    case 1:
                        Console.WriteLine("Bienvenido a la maquina dispensadora\n ");
                        Pro.MosProducto();
                        Pro.EscogerPro();
                        Console.Clear();
                        if (Pro.Mer[i].Existencia >= 1)
                        {
                            i = Pro.y - 1;
                            switch (Pro.q)
                            {
                                case "A":

                                    switch (Pro.y)
                                    {

                                        case 1:
                                            Console.WriteLine("[" + Pro.Mer[i].Nombre + "]" + "[Quedan " + Pro.Mer[i].Existencia + "]");
                                            Pro.ComPro(i);
                                            Console.WriteLine("Presione enter para continuar ");
                                            Console.ReadKey();
                                            Console.Clear();

                                            break;
                                        case 2:
                                            Console.WriteLine("[" + Pro.Mer[i].Nombre + "]" + "[Quedan " + Pro.Mer[i].Existencia + "]");
                                            Pro.ComPro(i);
                                            Console.WriteLine("Presione enter para continuar ");
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        default:
                                            Console.WriteLine("Esta opcion no existe");
                                            Console.WriteLine("Presione enter para continuar ");
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                    }

                                    break;
                                case "B":
                                    i += 2;
                                    switch (Pro.y)
                                    {

                                        case 1:
                                            Console.WriteLine("[" + Pro.Mer[i].Nombre + "]" + "[Quedan " + Pro.Mer[i].Existencia + "]");
                                            Pro.ComPro(i);
                                            Console.WriteLine("Presione enter para continuar ");
                                            Console.ReadKey();
                                            Console.Clear();

                                            break;
                                        case 2:
                                            Console.WriteLine("[" + Pro.Mer[i].Nombre + "]" + "[Quedan " + Pro.Mer[i].Existencia + "]");
                                            Pro.ComPro(i);
                                            Console.WriteLine("Presione enter para continuar ");
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        default:
                                            Console.WriteLine("Esta opcion no existe");
                                            Console.WriteLine("Presione enter para continuar ");
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                    }
                                    break;

                                case "C":
                                    i += 4;
                                    switch (Pro.y)
                                    {

                                        case 1:
                                            Console.WriteLine("[" + Pro.Mer[i].Nombre + "]" + "[Quedan " + Pro.Mer[i].Existencia + "]");
                                            Pro.ComPro(i);
                                            Console.WriteLine("Presione enter para continuar ");
                                            Console.ReadKey();
                                            Console.Clear();

                                            break;
                                        case 2:
                                            Console.WriteLine("[" + Pro.Mer[i].Nombre + "]" + "[Quedan " + Pro.Mer[i].Existencia + "]");
                                            Pro.ComPro(i);
                                            Console.WriteLine("Presione enter para continuar ");
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        default:
                                            Console.WriteLine("Esta opcion no existe");
                                            Console.WriteLine("Presione enter para continuar ");
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                    }
                                    break;
                                case "D":
                                    i += 6;
                                    switch (Pro.y)
                                    {
                                        case 1:
                                            Console.WriteLine("[" + Pro.Mer[i].Nombre + "]" + "[Quedan " + Pro.Mer[i].Existencia + "]");
                                            Pro.ComPro(i);
                                            Console.WriteLine("Presione enter para continuar ");
                                            Console.ReadKey();
                                            Console.Clear();

                                            break;
                                        case 2:
                                            Console.WriteLine("[" + Pro.Mer[i].Nombre + "]" + "[Quedan " + Pro.Mer[i].Existencia + "]");
                                            Pro.ComPro(i);
                                            Console.WriteLine("Presione enter para continuar ");
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        default:
                                            Console.WriteLine("Esta opcion no existe");
                                            Console.WriteLine("Presione enter para continuar ");
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;

                                    }
                                    break;


                                case "E":
                                    i += 8;
                                    switch (Pro.y)
                                    {
                                        case 1:
                                            Console.WriteLine("[" + Pro.Mer[i].Nombre + "]" + "[Quedan " + Pro.Mer[i].Existencia + "]");
                                            Pro.ComPro(i);
                                            Console.WriteLine("Presione enter para continuar ");
                                            Console.ReadKey();
                                            Console.Clear();

                                            break;
                                        case 2:
                                            Console.WriteLine("[" + Pro.Mer[i].Nombre + "]" + "[Quedan " + Pro.Mer[i].Existencia + "]");
                                            Pro.ComPro(i);
                                            Console.WriteLine("Presione enter para continuar ");
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        default:
                                            Console.WriteLine("Esta opcion no existe");
                                            Console.WriteLine("Presione enter para continuar ");
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;

                                    }
                                    break;

                                default:
                                    Console.WriteLine("Esta opcion no existe");
                                    Console.WriteLine("Presione enter para continuar ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Esta producto se acabo, por favor escoja otro");

                        }
                        break;
                    case 2:
                        Pro.MosVen();
                        Console.WriteLine("Presione enter para continuar ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }

            } while (p != 1);

        }
    }
}

