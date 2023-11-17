using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reactangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] cc = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));

            Console.WriteLine("\nPerimetro, Area y diagonal de un Rectangulo\n");
            // pedimos una altura del rectangulo
            Console.WriteLine("Indica una altura");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            // pedimos el ancho del rectangulo
            Console.WriteLine("Indica un ancho");
            double width = double.Parse(Console.ReadLine());
            // sumamos el ancho de las bases y la altura de ambos lados izquierdo y derecho
            double perimetro = width + width + height + height;
            // calculamos el area del rectangulo
            double area = width * height;
            // calculamos la diagonal
            double diagonal = Math.Sqrt(Math.Pow(width,2) + Math.Pow(height,2));
            Console.WriteLine("\n");
            // cambiamos el color del texto a un color mas agradable
            Console.ForegroundColor = cc[12];
            // mostramos los valores
            Console.WriteLine($"Altura: {height}cm, Ancho: {width}cm, Perimetro: {perimetro}, Area: {area}, Diagonal: {diagonal}");
            Console.ReadKey();
        }
    }
}
