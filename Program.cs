﻿using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionElegida = 0;
            try
            {
                menu(opcionElegida);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                menu(opcionElegida);
            }

        }

        static void menu(int opcion)
        {
            while (opcion != 10)
            {
                Console.Clear();
                Console.WriteLine("Elija la figura a calcular.");
                Console.WriteLine("1-Cuadrado");
                Console.WriteLine("2-Triangulo");
                Console.WriteLine("3-Rectangulo");
                Console.WriteLine("10-Salir del programa");
                opcion = Convert.ToInt32(Console.ReadLine());
                if (validarOpcion(opcion) == true)
                {
                    if (opcion == 1)
                    {
                        cuadrado();
                    }
                    else if (opcion == 2)
                    {
                        triangulo();
                    }
                    else if (opcion == 3)
                    {
                        rectangulo();
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese una opcion valida");
                    Console.ReadKey();
                }

            }
        }

        static void cuadrado()
        {
            Console.WriteLine("Ingrese la medida del lado: ");
            double lado = Convert.ToDouble(Console.ReadLine());
            double superficie = lado * lado;

            Console.WriteLine($"La superficie del cuadrado de lado {lado}, es de {superficie} metros cuadrados.");
            Console.ReadKey();
            Console.WriteLine("Presione enter para volver al menu.");
        }
      
        static void triangulo()
        {
            Console.WriteLine(" Ingrese la medida de la altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Ingrese la medida de la base: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double superficie = (altura * b) / 2;
            Console.WriteLine($"La altura del triangulo es de {altura}, la base del triangulo es de {b} y su superficie es de {superficie} metros cuadrados.");
            Console.ReadKey();
            Console.WriteLine("Presione enter para volver al menu.");
        }

        static void rectangulo()
        {
            Console.WriteLine(" Ingrese la medida de la altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Ingrese la medida de la base: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double superficie = (altura * b) ;
            Console.WriteLine($"La altura del rectangulo es de {altura}, la base del rectangulo es de {b} y su superficie es de {superficie} metros cuadrados.");
            Console.ReadKey();
            Console.WriteLine("Presione enter para volver al menu.");
        }

        static bool validarOpcion(int o)
        {

            if (o >= 1 && o <= 3)
            {
                return true;
            }


            return false;
        }
    }
}


