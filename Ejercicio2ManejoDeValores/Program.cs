using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2ManejoDeValores
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int num1, num2, suma, resta, producto;
            double potencia, modulo;
            Console.WriteLine("Ejercicio Parte 1");
            Console.WriteLine("Ingrese un numero entero");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
          

            Console.WriteLine("Ingrese un segundo numero entero");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            suma = (num1 + num2);
            Console.WriteLine($"La suma de los dos valores es: {suma}");
            Console.ReadKey();

            resta = (num1 - num2);
            Console.WriteLine($"La resta de los dos valores es: {resta}");
            Console.ReadKey();

            producto = (num1 * num2);
            Console.WriteLine($"El producto de los dos valores es: {producto}");
            Console.ReadKey();

            potencia = Math.Pow(num1, num2);
            Console.WriteLine($"La potencia de los dos valores es: {potencia}");
            Console.ReadKey();

            modulo = (num1 % num2);
            Console.WriteLine($"El módulo o resto de {num1} dividido {num2} es: {modulo}");
            Console.ReadKey();


            Console.WriteLine("Ejercicio Parte 2");


            decimal num3, num4, sumad, restad, productod, modulod, division1, division2; // potenciad;
            Console.WriteLine("Ingrese un numero decimal");
            linea = Console.ReadLine();
            num3 = decimal.Parse(linea);


            Console.WriteLine("Ingrese un segundo numero decimal");
            linea = Console.ReadLine();
            num4 = decimal.Parse(linea);

            sumad = (num3 + num4);
            Console.WriteLine($"La suma de los dos valores es: {sumad}");
            Console.ReadKey();

            restad = (num3 - num4);
            Console.WriteLine($"La resta de los dos valores es: {restad}");
            Console.ReadKey();

            productod = (num3 * num4);
            Console.WriteLine($"El producto de los dos valores es: {productod}");
            Console.ReadKey();



            Console.WriteLine($" Potencia = {Math.Pow(Convert.ToDouble(num3), Convert.ToDouble(num4))}");
            Console.ReadKey();

            modulod = (num3 % num4);
            Console.WriteLine($"El módulo o resto de {num3} dividido {num4} es: {modulod}");
            Console.ReadKey();

            division1 = (num3 / num4);
            Console.WriteLine($"{num3} dividido {num4} es: {division1}");
            Console.ReadKey();

            division2 = (num4 / num3);
            Console.WriteLine($"{num4} dividido {num3} es: {division2}");
            Console.ReadKey();








        }
    }
}
