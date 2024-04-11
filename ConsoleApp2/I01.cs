using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    internal class I01
    {

        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO 1, 2 y 3";

            #region EJERCICIO 01
            /*
             * I01. Máximo, mínimo y promedio
                Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y
                mostrar: el valor máximo, el valor mínimo y el promedio.
                Nota: Un escalar es una constante o variable que contiene un dato atómico y
                unidimensional. En contraposición al concepto de escalar, están los conceptos de array, lista
                y objeto, que pueden tener almacenado en su estructura más de un valor.
            */

            //int maximo = 0;
            //int minimo = 0;
            //float promedio = 0;
            //int acumulado = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Ingrese un numero: ");
            //    int numero = int.Parse(Console.ReadLine());

            //    acumulado += numero;

            //    if (i == 0)
            //    {
            //        maximo = numero;
            //        minimo = numero;
            //        promedio = numero;
            //    }
            //    else 
            //    { 
            //        if (numero > maximo)
            //        {
            //            maximo = numero;

            //        }
            //        if (numero < minimo)
            //        {
            //            minimo = numero;
            //        }

            //    }

            //}
            //promedio = (float)acumulado / 5;

            //Console.WriteLine(maximo);
            //Console.WriteLine(minimo);
            //Console.WriteLine(acumulado);
            //Console.WriteLine(promedio);

            //Console.ReadKey();
            #endregion

            #region EJERCICIO 02
            /*I02. Error al cubo
                Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el
                número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar
                número!".
                Nota: Utilizar el método Pow de la clase Math para calcular las potencias.
            */

            //int numero;
            //do
            //{
            //    Console.WriteLine("Ingrese un numero: ");
            //    numero = int.Parse(Console.ReadLine());

            //    if (numero == 0)
            //    {
            //        Console.WriteLine("ERROR. ¡Reingresar número!");
            //    }
            //    else
            //    {
            //        float numeroAlCuadrado = numero * numero;
            //        float numeroAlCubo = numeroAlCuadrado * numero;

            //        Console.WriteLine(numeroAlCuadrado);
            //        Console.WriteLine(numeroAlCubo);
            //    }

            //} while (numero  == 0);

            //Console.ReadLine();

            #endregion

            #region EJERCICIO 03

            /*
             * I03. Los primos
            Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el
            usuario por consola.
            Validar que el dato ingresado por el usuario sea un número.
            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            Si ingresa "salir", cierra la consola.
            Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa,
            iterar. De lo contrario, cerrar la consola.

            Nota: Utilizar sentencias de iteración, selectivas y el operador módulo (%).
            */

            //int numero;
            //bool numeroEsValido;
            //string input;
            //bool esPrimo = true;

            //do
            //{

            //    Console.WriteLine("Ingrese un numero: ");
            //    input = Console.ReadLine();
            //    numeroEsValido = int.TryParse(input, out numero);

            //    List<int> numerosPrimosEncontrados = new List<int>(); ;

            //    if (numeroEsValido)
            //    {
            //        if (numero <= 1)
            //        {
            //            esPrimo = false;
            //        }
            //        else
            //        {
            //            for (int i = 2; i <= numero; i++)
            //            {
            //                esPrimo = true;

            //                for (int divisor = 2; divisor < i; divisor++)
            //                {

            //                    if (i % divisor == 0)
            //                    {
            //                        esPrimo = false;
            //                        break;

            //                    }
            //                }

            //                if(esPrimo)
            //                {
            //                    numerosPrimosEncontrados.Add(i);
            //                }
            //            }

            //        }

            //        foreach (int numeroP in numerosPrimosEncontrados)
            //        {
            //            Console.WriteLine(numeroP);
            //        }


            //        Console.WriteLine("\nDesea volver a operar? (s|n): ");
            //        if (Console.ReadLine().ToLower() == "n")
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            numeroEsValido = false;
            //        }

            //    }


            //} while (numeroEsValido != true && input != "salir");

            //Console.WriteLine("Presione una tecla para finalizar...");
            //Console.ReadKey();

            #endregion

            #region EJERCICIO 04
            /*
             * I04. Un número perfecto
            Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros
            positivos (excluido el mismo) que son divisores del número.
            El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            Escribir una aplicación que encuentre los 4 primeros números perfectos.
            Nota: Utilizar sentencias de iteración y selectivas.
            */

            //int cantidadNumerosPerfectos = 0;
            //int numeroPerfecto = 1;
            //int sumaDivisores;
            //List<int> numerosPerfectos = new List<int>();

            //while (cantidadNumerosPerfectos < 4)
            //{
            //    sumaDivisores = 0;

            //    for (int i = 1; i < numeroPerfecto; i++)
            //    {
            //        if (numeroPerfecto % i == 0) //error de division por cero
            //        {
            //            sumaDivisores += i;
            //        }

            //    }

            //    if (numeroPerfecto == sumaDivisores)
            //    {
            //        Console.WriteLine($"el numero perfecto evaluado: {numeroPerfecto} ");
            //        Console.WriteLine($"la suma de los divisores: {sumaDivisores} ");
            //        cantidadNumerosPerfectos++;
            //        numerosPerfectos.Add(numeroPerfecto);
            //    }

            //    numeroPerfecto++;

            //}

            //foreach (int i in numerosPerfectos)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadKey();

            #endregion

            #region EJERCICIO 06
            /*
             * I06. Años bisiestos
            Escribir un programa que determine si un año es bisiesto.
            Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si
            ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto, pero 1900 no.
            Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese
            rango.
            Nota: Utilizar sentencias de iteración, selectivas y el operador módulo (%).
            */

            //int anioDeInicio = 0;
            //int anioDeFin = 0;

            //bool esBisiesto;

            //List<int> aniosBisiestos = new List<int>();

            //Console.WriteLine("Ingrese un año de inicio: ");
            //anioDeInicio = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese un año de fin: ");
            //anioDeFin = int.Parse(Console.ReadLine());


            //for (int i = anioDeInicio; i <= anioDeFin; i++)
            //{
            //    esBisiesto = false;

            //    if (i % 4 == 0 && i % 100 != 0)
            //    {
            //        esBisiesto = true;
            //    }
            //    if (i % 100 == 0 && i % 400 != 0)
            //    {
            //        esBisiesto = false;
            //    }
            //    if (i % 400 == 0)
            //    {
            //        esBisiesto = true;
            //    }

            //    if (esBisiesto)
            //    {
            //        aniosBisiestos.Add(i);
            //    }
            //}

            //foreach (int anio in aniosBisiestos)
            //{
            //    Console.WriteLine(anio);
            //}

            //Console.ReadKey();



            #endregion

            #region EJERCICIO 07
            /*I07. Recibo de sueldo
                Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la
                cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.
                Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de
                multiplicar el valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad
                de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el
                13% en concepto de descuentos.
                Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a
                cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.
                Nota: Utilizar sentencias de iteración y selectivas. No es necesario ni se deben utilizar
                vectores/arrays.
            */

            //double valorPorHora = 0;
            //string nombreEmpleado = string.Empty;
            //int antiguedad = 0;
            //int cantidadHorasTrabajadas = 0;

            //int cantidadDeEmpleados = 0;

            //double importeFinal = 0;
            //double importeTotal;

            //Console.WriteLine("Ingrese la cantidad de empleados en la fabrica: ");
            //cantidadDeEmpleados = int.Parse(Console.ReadLine());


            //for (int empleado = 0; empleado < cantidadDeEmpleados; empleado++)
            //{
            //    Console.WriteLine("Ingrese el valor por hora de trabajo: ");
            //    valorPorHora = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Ingrese el nombre del empleado: ");
            //    nombreEmpleado = Console.ReadLine();
            //    Console.WriteLine("Ingrese la antiguedad del empleado: ");
            //    antiguedad = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Ingrese la cantidad de horas trabajadas en el mes: ");
            //    cantidadHorasTrabajadas = int.Parse(Console.ReadLine());


            //    importeTotal = (valorPorHora * cantidadHorasTrabajadas) + (antiguedad * 150);
            //    importeFinal = importeTotal - importeTotal * 0.13;

            //    Console.WriteLine($"RECIBO DE SUELDO\n" +
            //        $"Nombre del empleado: {nombreEmpleado}\n" +
            //        $"Antiguedad {antiguedad}\n" +
            //        $"Valor por hora {valorPorHora}\n" +
            //        $"Ganancias brutas {importeTotal} \n" +
            //        $"Ganancias netas {importeFinal} \n");
            //}


            #endregion

            #region EJERCICIO 08
            /*
             * I08. Dibujando un triángulo rectángulo
            Escribir un programa que imprima por consola un triángulo como el siguiente:

            *
            ***
            *****
            *******
            *********
            El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo.
            Para el ejemplo anterior, la altura ingresada fue de 5.
            Nota: Utilizar sentencias de iteración y selectivas.
            */

            Console.WriteLine("Ingrese un numero entero positivo: ");
            int alturaDelTriangulo = int.Parse(Console.ReadLine());

            for (int i = 0; i < alturaDelTriangulo; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write("i");
                }
                Console.WriteLine("e");
            }

            Console.ReadKey();

            #endregion

            #region EJERCICIO 09
            /*
             * I09. Dibujando un triángulo equilátero
            Escribir un programa que imprima por consola un triángulo como el siguiente:
            *
            ***
            *****
            *******
            *********
            El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo.
            Para el ejemplo anterior, la altura ingresada fue de 5.
            Nota: Utilizar sentencias de iteración y selectivas.
            */
            #endregion
        }
    }
}
