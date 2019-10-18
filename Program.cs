using System;

namespace AndresMendoza3B
{
    class Program
    {
        static void Main(string[] args)
        {
            int selec;
            Boolean next = true;
            Console.WriteLine("*******Si desea ir a otro ejercicio una ves ya terminado uno precione enter*******");
            do
            {
                Console.WriteLine("Porfavor seleccione un ejercicio del 1 al 10");
                Console.WriteLine("Si desea salir digite el numero 0");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("Ejercicio {0}:", j);
                }
                selec = Convert.ToInt32(Console.ReadLine());
                switch (selec)
                {
                    case 1:
                        new Program().ejer1();
                        break;
                    case 2:
                        new Program().ejer2();
                        break;
                    case 3:
                        new Program().ejer3();
                        break;
                    case 4:
                        new Program().ejer4();
                        break;
                    case 5:
                        new Program().ejer5();
                        break;
                    case 6:
                        new Program().ejer6();
                        break;
                    case 7:
                        new Program().ejer7();
                        break;
                    case 8:
                        new Program().ejer8();
                        break;
                    case 9:
                        new Program().ejer9();
                        break;
                    case 10:
                        new Program().ejer10();
                        break;
                    case 0:
                        next = false;
                        break;
                }
            } while (next);
        }
        public void ejer1()
        {
            int num = 0, may = 0, n = 0;
            Console.Write("Ingrese la cantidad de numero que desea ingresar ->"); n = Convert.ToInt32(Console.ReadLine());
            for (int c = 0; c < n; c++)
            {
                Console.Write("Ingresa {0} numero", c + 1); num = Convert.ToInt32(Console.ReadLine());
                if (num > may)
                {
                    may = num;
                }
            }
            Console.WriteLine("El numero mayor es {0}:", may);
            Console.ReadKey();
        }

        public void ejer2()
        {
            int ta;
            Console.Write("Ingrese el tamaño del cuadraro -> "); ta = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ta - 1; i++)
            {
                Console.Write("* ");
            }
            for (int c = 0; c < ta - 1; c++)
            {
                Console.Write("* ");
                for (int l = 0; l < ta - 2; l++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine("*");
            }
            for (int h = 0; h < ta; h++)
            {
                Console.Write("* ");
            }
            Console.ReadKey();
        }


        public void ejer3()
        {
            int venta;
            double precio = 0, total = 0;
            Console.WriteLine("Si desea salir de la factura porfavor digite el numero cero");
            do
            {
                Console.Write("Intruduzca la cantidad de productos que se venderan->"); venta = Convert.ToInt32(Console.ReadLine());
                if (venta != 0)
                {
                    Console.Write("Introduzca el precio del producto->"); precio = Convert.ToDouble(Console.ReadLine());
                    total = total + (venta * precio);
                }
            } while (venta != 0);
            Console.WriteLine("el total es->" + total);
            Console.ReadKey();
        }

        public void ejer4()
        {
            int Hours = 0, paga = 0, ext = 0;
            int yes = 0;
            do
            {
                Console.Write("Ingrese las horas del trabajador ->"); Hours = Convert.ToInt32(Console.ReadLine());
                if (Hours <= 35)
                {
                    paga = Hours * 15;
                }
                else
                {
                    ext = Hours - 35;
                    paga = (35 * 15) + (ext * 22);
                }
                Console.WriteLine("El total a pagar al trabajador es ->" + paga);
                Console.WriteLine("Si desea repetir digite 1....Si desea salir digite cualquier numero"); yes = Convert.ToInt32(Console.ReadLine());
            } while (yes == 1);
            Console.ReadKey();
        }

        public void ejer5()
        {
            int ta = 0;
            Console.WriteLine("Ingrese el tamaño de la piramide"); ta = Convert.ToInt32(Console.ReadLine());
            for (int c = 1; c <= ta; c++)
            {
                for (int a = 0; a < (ta - c); a++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < (c * 2) - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }

        public void ejer6()
        {
            int ta = 0;
            Console.WriteLine("Digite un numero para realizar un rombo donde su tamaño consta la mitad superior"); ta = Convert.ToInt32(Console.ReadLine());
            for (int c = 1; c <= ta; c++)
            {
                for (int a = 0; a < (ta - c); a++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < (c * 2) - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int c = (ta - 1); c >= 0; c--)
            {

                for (int a = 0; a < (ta - c); a++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < (c * 2) - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }

        public void ejer7()
        {
            int dere = 101;
            int izqui = 0;
            do
            {
                dere = dere - 1;
                izqui = izqui + 1;
                Console.WriteLine(izqui + " " + dere);
            } while (izqui != 100);
            Console.ReadKey();
        }

        public void ejer8()
        {
            int num, b = 0, c = 0;
            Console.Write("Escriba un numero para realizar un conteo de uno en uno, de dos en dos y de tres en tres ->");
            num = Convert.ToInt32(Console.ReadLine());
            for (int a = 1; a <= num; a++)
            {
                Console.Write(a);
                if (b < num)
                {
                    b = b + 2;
                    if (b < num)
                    {
                        Console.Write(" -- " + b);
                    }
                }
                if (c < num)
                {
                    c = c + 3;
                    if (c < num)
                    {
                        Console.Write(" -- " + c);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void ejer9()
        {
            int conta = 0, mult = 0; ;
            do
            {
                conta++;
                for (int c = 0; c <= 15; c++)
                {
                    mult = conta * c;
                    Console.WriteLine(conta + " " + " x " + c + " " + "=" + " " + mult);
                }
                Console.WriteLine("-----------------");
            } while (conta < 15);
            Console.ReadKey();
        }

        public void ejer10()
        {
            int selection;
            Boolean sigui = true;
            do
            {
                Console.WriteLine("Si desea salir del menu porfavor ingrese 1");
                Console.WriteLine("Si desea realizar un sumatorio de un numero porfavor ingrese 2");
                Console.WriteLine("Si desea realizar un factorial de un numero porfavor ingrese 3");
                selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 2:
                        new Program().Sumatorio();
                        break;
                    case 3:
                        new Program().Facto();
                        break;
                    case 1:
                        sigui = false;
                        break;
                }
            } while (sigui);
        }

        public void Sumatorio()
        {
            int num;
            int result = 0;
            Console.Write("Digite el numero al que desea realizarle un sumatorio ->"); num = Convert.ToInt32(Console.ReadLine());
            for(int c=1; c<=num; c++)
            {
                result = result + c;
            }
            Console.Write("La suma es ->"+result); 
            Console.ReadKey();
        }

        public void Facto()
        {
            int num, fact = 1;
            Console.Write("Ingrese un numero para realizar un factorial -> "); num = Convert.ToInt32(Console.ReadLine());
            for (int c = 1; c <= num; c++)
            {
                fact = fact * c;

            }
            Console.WriteLine("El factorial de " + num + "!" + " " + "=" + " " + fact);
            Console.ReadKey();
        }
    }
}