using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Validador
    {
        /*
        * I02. ¿Desea continuar?
        Realizar un programa que sume números enteros hasta que el usuario lo determine por
        medio de un mensaje "¿Desea continuar? (S/N)".
        Crear la clase Validador y el método estático ValidarRespuesta, que validará el
        ingreso de respuestas.

        El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se
        ingresó cualquier otro valor.
        */

        public static bool Validar(int valor, int min, int max)
        {
            return valor > min && valor < max;

        }

        public static bool ValidarRespuesta(string respuesta) 
        {
            bool esValida = false;
            foreach (char letra in respuesta)
            {
                if (letra == 'S')
                {
                    esValida = true;
                }
                else
                {
                    esValida = false;
                }
            }
            return esValida;

        }
    }
}
