﻿namespace actividad3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            3)	Calcular ab por productos sucesivos.
            */
            Console.Write("Ingrese el valor Base ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de la Potencia ");
            int B = int.Parse(Console.ReadLine());

            int resultado = 1;
            int contador = 0;

            while (contador < B)
            {
                resultado = resultado * A;
                contador++;
            }

            Console.WriteLine("El resultado de "+ A + " elevado a " + B + " es: " + resultado);
        }
    }
}
