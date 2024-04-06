using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Declara una lista de enteros y agrega 10 elementos a ella, por consola.
    Luego, encuentra el valor máximo y mínimo en la lista y muestra el
    resultado en consola
*/

namespace EjerciciosProgramacionllDespuesDeSemanaSanta.ejercicios
{
    internal class IngrearDiezNumerosAndMostrarElMayorAndMinimo
    {
        public static void MainIngrearDiezNumerosAndMostrarElMayorAndMinimo()
        {
            Console.Title = "Ingrese 10 numeros para mostrar el mayor y el menor";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
                :::::::::  :::    ::: :::::::::       ::::::::::: ::::::::       :::::::::  ::::::::::     ::: ::::::::::: :::    :::  :::::::::  
                :+:    :+: :+:    :+: :+:    :+:          :+:    :+:    :+:      :+:    :+: :+:          :+: :+:   :+:     :+:    :+: :+:     :+: 
                +:+    +:+ +:+    +:+ +:+    +:+          +:+    +:+             +:+    +:+ +:+         +:+   +:+  +:+     +:+    +:+        +:+  
                +#++:++#+  +#++:++#++ +#++:++#+           +#+    +#++:++#++      +#+    +:+ +#++:++#   +#++:++#++: +#+     +#++:++#++       +#+   
                +#+        +#+    +#+ +#+                 +#+           +#+      +#+    +#+ +#+        +#+     +#+ +#+     +#+    +#+     +#+     
                #+#        #+#    #+# #+#                 #+#    #+#    #+#      #+#    #+# #+#        #+#     #+# #+#     #+#    #+#             
                ###        ###    ### ###             ########### ########       #########  ########## ###     ### ###     ###    ###     ### 
            ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n");
            List<int> list = new List<int>();

            for (int i = 0; i < 10; i++) 
            {
                Console.Write("Ingrese un numero: ");
                int numero = int.Parse(Console.ReadLine());

                list.Add(numero);   
            }

            Console.WriteLine($"\nEl valor minimo es: {list.Min()} y el valor maximo es {list.Max()}");
        }
    }
}
