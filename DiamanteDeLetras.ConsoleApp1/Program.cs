using System;

namespace DiamanteDeLetras2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A = 65
            // Z = 90

            // A = 1
            // B = 2...

            Console.WriteLine("ESCREVA UMA LETRA PARA DELIMITAR O TAMANHO DO DIAMANTE");
            string entrada = Console.ReadLine();
            entrada = entrada.ToUpper();

            int letra = Convert.ToChar(entrada);
            int entradaint = letra - 64;

            string alfabeto = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] chars = alfabeto.ToCharArray();
            int contador = 0;

            if (entradaint == 1)
            {
                Console.WriteLine(chars[1]);
                Console.ReadLine();
            }
            else
            {
                //metade de cima !
                for (int i = 0; i <= entradaint; i++)
                {
                    Console.Write(" ");
                }
                Console.Write(chars[1]);
                Console.WriteLine();

                for (int i = 0; i <= entradaint - 2; i++)
                {
                    for (int j = 0; j < entradaint - i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(chars[i + 2]);
                    contador = (2 * i) + 1;
                    for (int j = 0; j < contador; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(chars[i + 2]);
                    Console.WriteLine();
                    
                }

                //METADE PARA BAIXO !

                for (int i = entradaint - 3; i >= 0; i--)
                {
                    for (int j = 0; j < entradaint - i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(chars[i + 2]);
                    contador = (2 * i) + 1;

                    for (int j = 0; j < contador; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(chars[i + 2]);
                    Console.WriteLine();

                }
                for (int i = 0; i <= entradaint; i++)
                {
                    Console.Write(" ");
                }
                Console.Write(chars[1]);
                Console.WriteLine();
                Console.ReadLine();

            }

        }
    }
}
