using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Un objeto es la instancia de una clase";
            Console.WriteLine("Texto inicial:");
            Console.WriteLine(cadena);
            Console.WriteLine("\r\nTexto con alteraciones de posición aleatorias:");
            Console.WriteLine(shuffle(cadena));
            Console.Read();
        }

        private static string shuffle(string text)
        {
            int length = text.Length;
            List<char> listaOriginal = new List<char>();
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            List<int> listaLlenado = new List<int>();

            for (int i = 0; i < length; i++)
            {
                listaOriginal.Add(text[i]);
            }                                   
                        
            while(listaOriginal.Count != listaLlenado.Count)
            {
                int elegido = random.Next(0, length);

                while (!listaLlenado.Contains(elegido))
                {
                    listaLlenado.Add(elegido);
                    builder.Append(text[elegido]);
                }
            }            
            return builder.ToString();            
        }
    }
}
