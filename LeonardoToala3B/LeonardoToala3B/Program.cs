using System;

namespace LeonardoToala3B
{
    class Program
    {
        static void Main(string[] args)
        {
            string repetir = null;
            int seleccion;
            while (repetir==null)
            {
                Console.WriteLine("   \nProgramación Orientada a Objetos\n ");
                Console.WriteLine("*********** Ejercicios 1 ************\n ");
                Console.WriteLine(" 1) ¿Cuál es el mayor?");
                Console.WriteLine(" 2) Cuadrado de Asteriscos");
                Console.WriteLine(" 3) Total de la Factura");
                Console.WriteLine(" 4) Cálculo del Salario Semanal");
                Console.WriteLine(" 5) Piramide de Asteriscos");
                Console.WriteLine(" 6) Rombo de Asteriscos");
                Console.WriteLine(" 7) Contador del 1 al 100 y 100 al 1");
                Console.WriteLine(" 8) Contador de un número de Uno en Uno, Dos en Dos, Tres en Tres");
                Console.WriteLine(" 9) Tabla de Multiplicar del 1 al 15");
                Console.WriteLine("10) Sumatorio o Factorial");
                Console.WriteLine("11) Finalizar Programa");
                Console.Write("Escoja una opción:    ");
                seleccion = Convert.ToInt32(Console.ReadLine());

                if (seleccion == 1)
                {
                    Program.Mayor();
                }
                if (seleccion == 2)
                {
                    Program.cuadrado();
                }
                if (seleccion == 3)
                {
                    Program.factura();
                }
                if (seleccion == 4)
                {
                    Program.salario();
                }
                if (seleccion == 5)
                {
                    Program.piramide();
                }
                if (seleccion == 6)
                {
                    Program.rombo();
                }
                if (seleccion == 7)
                {
                    Program.conteo1al100();
                }
                if (seleccion == 8)
                {
                    Program.conteo();
                }
                if (seleccion == 9)
                {
                    Program.tablaMultiplicar();
                }
                if (seleccion == 10)
                {
                    Program.sumatoriofactorial();
                }
                if (seleccion==11)
                {
                    repetir = "salir";
                }
            }
        }
        static void Mayor()
        {
            int Numero = 0, mayor = 0, cantidad = 0;
            Console.Write("\nIngrese la cantidad de números a digitar:  ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            for (int l = 0; l < cantidad; l++)
            {
                Console.WriteLine("Ingrese su {0} número:", l + 1);
                Numero = Convert.ToInt32(Console.ReadLine());
                if (Numero > mayor)
                {
                    mayor = Numero;
                }
            }
            Console.WriteLine("El número mayor es:  {0}", mayor);
            Console.ReadKey();
        }

        static void cuadrado()
        {
            string espacios = null;
            int medida = 0;

            Console.Write("\nIngrese un número entero para formar el cuadrado:  ");
            medida = Convert.ToInt32(Console.ReadLine());
            espacios = new string(' ', ((medida * 2) - 3));
            Program.Asteriscocuadrado(medida);
            Console.WriteLine();
            for (int i = 0; i < (medida - 2); i++)
            {
                Console.WriteLine("*" + espacios + "*");
            }
            Program.Asteriscocuadrado(medida);
            Console.WriteLine();
            Console.ReadKey();
        }
        static void Asteriscocuadrado(int medida)
        {
            string[] vector;
            vector = new string[(medida * 2)];
            for (int i = 0; i < (medida * 2); i = (i + 2))
            {
                vector[i] = "*";
                i = i + 1;
                vector[i] = " ";
                i = i - 1;
            }
            for (int i = 0; i < (medida * 2); i++)
            {
                Console.Write(vector[i]);
            }
        }

        static void factura()
        {
            int cantidad, salida = 0;
            double precio, multiplicacion, total = 0;
            while (salida == 0)
            {
                Console.WriteLine("Introduzca la cantidad vendida:");
                cantidad = Convert.ToInt32(Console.ReadLine());

                if (cantidad == 0)
                {
                    salida = 1;
                }
                else
                {
                    Console.WriteLine("Introduzca el precio:");
                    precio = Convert.ToDouble(Console.ReadLine());
                    multiplicacion = cantidad * precio;
                    total = total + multiplicacion;
                    Console.WriteLine("\nSi desea ver el total de la venta introduzca el 0");
                }

            }
            Console.WriteLine("El total de la venta es: {0}", total);
            Console.ReadKey();
        }

        static void salario()
        {
            int horas, decision = 0, sueldo;
            while (decision == 0)
            {
                Console.WriteLine("Ingrese las horas trabajadas por el empleado:");
                horas = Convert.ToInt32(Console.ReadLine());
                if (horas <= 35)
                {
                    sueldo = horas * 15;
                }
                else
                {
                    sueldo = (35 * 15) + ((horas - 35) * 22);
                }
                Console.WriteLine("El salario a pagar es: {0} $", sueldo);
                Console.WriteLine("¿Desea calcular otros salario?");
                Console.WriteLine("Ingrese 0 para seguir o cualquier otra tecla para salir");
                decision = Convert.ToInt32(Console.ReadLine());
            }


            Console.ReadKey();
        }

        static void piramide()
        {
            int pisos;
            Console.Write("Ingrese un número para crear la piramide:  ");
            pisos = Convert.ToInt32(Console.ReadLine());
            string asteriscos = null, espacios = null;
            int contador = -1;
            int contador2 = pisos;
            for (int i = 0; i < pisos; i++)
            {
                contador2 = contador2 - 1;
                contador = contador + 2;
                asteriscos = new string('*', contador);
                espacios = new string(' ', contador2);
                Console.WriteLine("{0}{1}", espacios, asteriscos);
            }

            Console.ReadKey();
        }

        static void rombo()
        {
            int pisos;
            Console.Write("Ingrese un número para crear el rombo:  ");
            pisos = Convert.ToInt32(Console.ReadLine());
            Program.partesuperiorrombo(pisos);
            Program.parteinferiorrombo(pisos);
            Console.ReadKey();
        }
        static void partesuperiorrombo(int pisos)
        {
            string asteriscos = null, espacios = null;
            int contador = -1;
            int contador2 = pisos;
            for (int i = 0; i < pisos; i++)
            {
                contador2 = contador2 - 1;
                contador = contador + 2;
                asteriscos = new string('*', contador);
                espacios = new string(' ', contador2);
                Console.WriteLine("{0}{1}", espacios, asteriscos);
            }
        }
        static void parteinferiorrombo(int pisos)
        {
            string asteriscos = null, espacios = null;
            int contador = ((pisos * 2) - 1);
            int contador2 = 0;
            for (int i = 0; i < (pisos - 1); i++)
            {
                contador2 = contador2 + 1;
                contador = contador - 2;
                asteriscos = new string('*', contador);
                espacios = new string(' ', contador2);
                Console.WriteLine("{0}{1}", espacios, asteriscos);
            }
        }
        static void conteo1al100()
        {
            int reversa = 100;
            for (int i = 1; i <= 100; i++)
            {

                Console.WriteLine("{0}       {1}", i, reversa);
                reversa = reversa - 1;

            }
            Console.ReadKey();
        }

        static void conteo()
        {
            int número, dedosendos = 1, detresentres = 1;
            string espacio = null;
            espacio = new string(' ', 4);
            Console.Write("Ingrese un número:    ");
            número = Convert.ToInt32(Console.ReadLine());

            for (int deunoenuno = 1; deunoenuno <= número; deunoenuno++)
            {
                Console.Write(deunoenuno + espacio);
                if (dedosendos < número)
                {
                    Console.Write(dedosendos + espacio);
                    dedosendos = dedosendos + 2;
                }
                if (detresentres < número)
                {
                    Console.Write(detresentres);
                    detresentres = detresentres + 3;
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }

        static void tablaMultiplicar()
        {
            int resultado = 0;
            for (int multiplicando = 1; multiplicando <= 15; multiplicando++)
            {
                Console.WriteLine("\n******Tabla del {0}******\n", multiplicando);
                for (int multiplicador = 0; multiplicador <= 14; multiplicador++)
                {
                    resultado = (multiplicando * multiplicador);
                    Console.WriteLine("{0} x {1} = {2}", multiplicando, multiplicador, resultado);
                }
                if (multiplicando < 15)
                {
                    Console.WriteLine("Presione enter para generar la tabla del {0}", (multiplicando + 1));
                }
                Console.ReadKey();
            }
        }

        static void sumatoriofactorial()
        {
            int opción = 0, número ;
            while (opción != 1)
            {
                Console.WriteLine("\nMenú Principal");
                Console.WriteLine("1) Salir");
                Console.WriteLine("2) Sumatorio");
                Console.WriteLine("3) Factorial");
                Console.WriteLine("Seleccione una opción:   ");
                opción = Convert.ToInt32(Console.ReadLine());
                if (opción == 2)
                {
                    int resultado = 1;
                    Console.WriteLine("Ingrese el número sobre el que se va a calcular el Sumatorio");
                    número = Convert.ToInt32(Console.ReadLine());
                    resultado = ((número * (número + 1)) / 2);
                    Console.WriteLine("El Sumatorio del número {0} es: {1}", número, resultado);
                }
                if (opción == 3)
                {
                    int resultado = 1;
                    Console.WriteLine("Ingrese el número sobre el que se va a calcular el Factorial");
                    número = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= número; i++)
                    {
                        resultado = (resultado * i);
                    }
                    Console.WriteLine("El Factorial del número {0} es: {1}\n", número, resultado);
                }
            }

        }
    }
}