using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EJERCICIO 01
            /*
             * I01. Validador de rangos
                Realizar una clase llamada Validador que posea un método estático llamado Validar con la
                siguiente firma:
                bool Validar(int valor, int min, int max)
                ● valor: dato a validar.
                ● min: mínimo valor incluido.
                ● max: máximo valor incluido.
                Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
                anteriormente que estén dentro del rango -100 y 100.
                Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el
                promedio.
                Nota: Utilizar variables escalares, NO utilizar vectores/arrays.
            */

            //int maximo = 0;
            //int minimo = 0;
            //double promedio = 0;
            //int acumulador = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Ingrese un numero mayor a -100 y menor a 100");
            //    int numero = int.Parse(Console.ReadLine());
            //    Console.WriteLine(i);

            //    if (Validador.Validar(numero, -100, 100))
            //    {
            //        if (i == 0)
            //        {

            //            maximo = numero;
            //            minimo = numero;
            //        }

            //        if (numero < minimo)
            //        {
            //            minimo = numero;
            //        }
            //        if (numero > maximo)
            //        {
            //            maximo = numero;
            //        }
            //        acumulador += numero;
            //    }
            //    else
            //    {
            //        i--;
            //    }
            //}
            //promedio = (double)acumulador / 10;

            //Console.WriteLine($"Maximo {maximo}");
            //Console.WriteLine($"Minimo {minimo}");
            //Console.WriteLine($"Promedio {promedio}");
            #endregion

            #region EJERCICIO 02
            /*
             * I02. ¿Desea continuar?
            Realizar un programa que sume números enteros hasta que el usuario lo determine por
            medio de un mensaje "¿Desea continuar? (S/N)".
            Crear la clase Validador y el método estático ValidarRespuesta, que validará el
            ingreso de respuestas.

            El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se
            ingresó cualquier otro valor.
            */

            //int acumulador = 0;

            //do
            //{
            //    Console.WriteLine("Ingrese un numero entero: ");
            //    if(int.TryParse(Console.ReadLine(), out int numero))
            //    {
            //        acumulador += numero;
            //    }


            //    Console.WriteLine("¿Desea continuar? (S/N)");
            //    string respuesta = Console.ReadLine().ToUpper();

            //    if (!Validador.ValidarRespuesta(respuesta))
            //    {
            //        break;
            //    }

            //} while (true);

            //Console.WriteLine(acumulador);



            #endregion

            #region EJERCICIO 03 INCOMPLETO
            /*
             * I03. Conversor binario
            Desarrollar una clase llamada Conversor que posea dos métodos de clase (estáticos):
            El método ConvertirDecimalABinario que convierte un número entero del
            sistema decimal al sistema binario.
            public string ConvertirDecimalABinario(int numeroEntero) {}
            El método ConvertirBinarioADecimal que convierte un número entero del
            sistema binario al sistema decimal.
            public int ConvertirBinarioADecimal(int numeroEntero) {}
            Nota: NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y
            selección.
            */





            #endregion

            #region EJERCICIO 04
            /*
             * I04. La calculadora
            Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
            multiplicación y división).
            Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
            Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando
            y la operación matemática. El método devolverá el resultado de la operación.
            Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe
            utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el
            operando es distinto de cero.
            Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar
            (ingresando el caracter +, -, * o /).
            El usuario decidirá cuándo finalizar el programa.
            */


            #endregion

            Console.ReadKey();
        }
    }
}
