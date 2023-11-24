using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Por teclado se ingresa el valor hora de un empleado. Posteriormente se ingresa el 
nombre del empleado, la antigüedad y la cantidad de horas trabajadas en el mes. 
Se pide calcular el importe a cobrar teniendo en cuenta que al total que resulta 
de multiplicar el valor hora por la cantidad de horas trabajadas, hay que sumarle 
la cantidad de años trabajados multiplicados por 30, y al total de todas esas 
operaciones restarle el 13% en concepto de descuentos. Imprimir el recibo 
correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en 
bruto, el total de descuentos y el valor neto a cobrar. 
*/

namespace EjerciciosSEMANA11
{
    internal class Ejercicio5
    {
        public static void EjercicioCinco()
        {
            Console.Title = "Calculadora de salarios";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n─────▄██▀▀▀▀▀▀▀▀▀▀▀▀▀██▄─────    ");
            Console.WriteLine("────███───────────────███────    ");
            Console.WriteLine("───███─────────────────███───    ");
            Console.WriteLine("──███───▄▀▀▄─────▄▀▀▄───███──    ");
            Console.WriteLine("─████─▄▀────▀▄─▄▀────▀▄─████─    ");
            Console.WriteLine("─████──▄████─────████▄──█████    ");
            Console.WriteLine("█████─██▓▓▓██───██▓▓▓██─█████    ");
            Console.WriteLine("█████─██▓█▓██───██▓█▓██─█████    ");
            Console.WriteLine("█████─██▓▓▓█▀─▄─▀█▓▓▓██─█████    ");
            Console.WriteLine("████▀──▀▀▀▀▀─▄█▄─▀▀▀▀▀──▀████    ");
            Console.WriteLine("███─▄▀▀▀▄────███────▄▀▀▀▄─███    ");
            Console.WriteLine("███──▄▀▄─█──█████──█─▄▀▄──███    ");
            Console.WriteLine("███─█──█─█──█████──█─█──█─███    ");
            Console.WriteLine("███─█─▀──█─▄█████▄─█──▀─█─███    ");
            Console.WriteLine("███▄─▀▀▀▀──█─▀█▀─█──▀▀▀▀─▄███    ");
            Console.WriteLine("████─────────────────────████    ");
            Console.WriteLine("─███───▀█████████████▀───████    ");
            Console.WriteLine("─███───────█─────█───────████    ");
            Console.WriteLine("─████─────█───────█─────█████    ");
            Console.WriteLine("───███▄──█────█────█──▄█████─    ");
            Console.WriteLine("─────▀█████▄▄███▄▄█████▀─────    ");
            Console.WriteLine("──────────█▄─────▄█──────────    ");
            Console.WriteLine("──────────▄█─────█▄──────────    ");
            Console.WriteLine("───────▄████─────████▄───────    ");
            Console.WriteLine("─────▄███████───███████▄─────    ");
            Console.WriteLine("───▄█████████████████████▄───    ");
            Console.WriteLine("─▄███▀───███████████───▀███▄─    ");
            Console.WriteLine("███▀─────███████████─────▀███    ");
            Console.WriteLine("▌▌▌▌▒▒───███████████───▒▒▐▐▐▐    ");
            Console.WriteLine("─────▒▒──███████████──▒▒─────    ");
            Console.WriteLine("──────▒▒─███████████─▒▒──────    ");
            Console.WriteLine("───────▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒───────    ");
            Console.WriteLine("─────────████░░█████─────────    ");
            Console.WriteLine("────────█████░░██████────────    ");
            Console.WriteLine("──────███████░░███████───────    ");
            Console.WriteLine("─────█████──█░░█──█████──────    ");
            Console.WriteLine("─────█████──████──█████──────    ");
            Console.WriteLine("──────████──████──████───────    ");
            Console.WriteLine("──────████──████──████───────    ");
            Console.WriteLine("──────████───██───████───────    ");
            Console.WriteLine("──────████───██───████───────    ");
            Console.WriteLine("──────████──████──████───────    ");
            Console.WriteLine("─██────██───████───██─────██─    ");
            Console.WriteLine("─██───████──████──████────██─    ");
            Console.WriteLine("─███████████████████████████─    ");
            Console.WriteLine("─██─────────████──────────██─    ");
            Console.WriteLine("─██─────────████──────────██─    ");
            Console.WriteLine("────────────████─────────────    ");
            Console.WriteLine("─────────────██──────────────  \n");
            Console.ForegroundColor = ConsoleColor.White;

            // le pedimos al usuario los datos correspondientes
            Console.Write("Ingrese el pago por hora: ");
            double costoPorHora = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.Write("Ingrese el Nombre del empleado: ");
            string nombreDeEmpleado = Console.ReadLine();
            Console.WriteLine("\n");

            Console.Write("Ingrese tiempo trabajando: ");
            double TiempoTrabajando = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.Write("Ingrese el horas trabajadas: ");
            double horasTrabajadasPorMes = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // declaramos el descuento
            const double descuento = 0.13;
            // calculamos el descuento o impuesto
            double calcularDescuento = ((costoPorHora * horasTrabajadasPorMes) + (TiempoTrabajando * 30)) * descuento;
            // restamos al salario bruto el impuesto
            double importeBrutos = ((costoPorHora * horasTrabajadasPorMes) + (TiempoTrabajando * 30)) - calcularDescuento;
            // calculamos el salario neto
            double importNetos = ((costoPorHora * horasTrabajadasPorMes) + (TiempoTrabajando * 30));

            // Moastramos las cabeceras para los datos
            Console.WriteLine("Nombre\t\tTiempo en la empresa\tConsto por hora\t\tSalario bruto\tDescuento\tSalario Neto");
            Console.ForegroundColor = ConsoleColor.Red;
            // mostramos los datos a las columnas correspondientes
            Console.WriteLine(
                $"{nombreDeEmpleado}\t" +
                $"{TiempoTrabajando}\t\t\t3" +
                $"{costoPorHora}\t\t\t" +
                $"{importeBrutos}\t\t" +
                $"{calcularDescuento}\t\t" +
                $"{importNetos}"
            );

            Console.ReadKey();  
        }
    }
}
