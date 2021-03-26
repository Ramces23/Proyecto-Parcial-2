using System;
using System.Collections.Generic;
using System.Text;

namespace Maquina_Dispensadora
{
    public class Producto
    {
        public struct Mercancia
        {
            public String Nombre;
            public int Precio;
            public int Existencia;
        }
        public string q = "";
        public  string Merca = "Bianchi Bar/Agua  500ml/Ruffles Peq/  Doritos  /   Lay's   /  Mas-Mas  / Red--Rock / Coca-Cola / Hershey's /  Snicker  /";
        public string Val = "15/15/20/20/25/25/25/25/50/50/";
        public int y = 0;
        public int i = 0;

        public Mercancia[] Mer = new Mercancia[10];
        public void LlenarMaquina() 
        {
            string[] CodMer = Merca.Split('/');
            string[] ValMer = Val.Split('/');
            for (i = 0; i <= 9; i++)
            {
                Mer[i].Nombre = CodMer[i];
                Mer[i].Precio = int.Parse(ValMer[i]);
                Mer[i].Existencia = 10;
                }          
            }
        public void MosProducto()
        {
            int c = 0;
            char L = 'A';
            Console.WriteLine("                     Menu                        ");
            for (i = 0; i <= 9; i++)
            {
                c++;
                Console.Write(" [{0}-{1}]", L, c);
                Console.Write("[" + Mer[i].Nombre + "]");

                i++;
                if (i % 2 == 0)
                {
                    i--;
                    Console.WriteLine("[RD${0}]", Mer[i].Precio);
                    Console.Write("");
                    i++;
                    c = 0;
                    L++;
                }
                i--;
            }


        }
        public void EscogerPro()
        {

            string CodPro = "";
            char ch = '-';
            bool b;
            Console.WriteLine("Introducir el codigo del producto, por ejemplo 'A-1'");
            do
            {

                CodPro = Console.ReadLine();
                b = CodPro.Contains(ch);
                Console.Clear();
                if (b == false)
                {
                    Console.WriteLine("El codigo del producto no se introdujo de la forma adecuada, por favor introduscalo de nuevo");
                }

            } while (b == false);
            string[] CodDat = CodPro.Split('-');
            q = CodDat[0];
            y = int.Parse(CodDat[1]);

        }
        public void ComPro(int i)
        {
            Console.WriteLine("Esta maquina dispensadora solo acepta monedas de: 5, 10 o 20 y billetes de: 50, 100, 200 ");
            int m = 0;
            int mon = 0;

            Console.WriteLine("Introdusca su dinero: ");
            while (mon < Mer[i].Precio)
            {


                m = 0;
                m = int.Parse(Console.ReadLine());
                Console.Clear();

                if (m == 5 || m == 10 || m == 25 || m == 50 || m == 100 || m == 200)
                {
                    mon += m;
                    if (mon < Mer[i].Precio)
                    {
                        Console.WriteLine(" La cantidad introducida no suficiente, faltan {0} ", Mer[i].Precio - mon);

                    }
                }
                else
                {
                    Console.WriteLine("La maquina no acepta este monto");
                }

            }
            Console.WriteLine("Ha introducido {0}", mon);
            if (mon > Mer[i].Precio)
            {
                Console.WriteLine("Su devuelta es: {0}", mon - Mer[i].Precio);



            }
            Mer[i].Existencia--;

            Console.WriteLine("Gracias por su compra ");
        }
        public void MosVen()
        {
            int c = 0;
            for (i = 0; i <= 9; i++)
            {
                if (Mer[i].Existencia >= 10)
                {
                    c++;
                }
            }
            if (c >= 10)
            {
                Console.WriteLine("Todavia no hay ventas ");
            }
            else
            {
                Console.WriteLine(" [Productos vendidos]\n");
                for (i = 0; i <= 9; i++)
                {
                    if (Mer[i].Existencia < 10)
                    {
                        Console.Write("[" + Mer[i].Nombre + "]");
                        if (10 - Mer[i].Existencia > 1)
                        {
                            Console.Write("[{0} Unidades]\n", 10 - Mer[i].Existencia);
                            Console.Write("");
                        }
                        else
                        {
                            Console.Write("[{0} Unidad]\n", 10 - Mer[i].Existencia);
                        }
                    }

                }

            }
        }

    }
}
