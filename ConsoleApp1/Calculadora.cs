using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculadora
    {
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

        public static int Calcular(int primerOperando, int segundoOperando, string operacionMatematica)
        {
            int resultado = 0;

            switch (operacionMatematica)
            {
                case "suma":
                    resultado = primerOperando + segundoOperando;
                    break;
                case "resta":
                    resultado = primerOperando - segundoOperando;
                    break;
                case "multiplicacion":
                    resultado = primerOperando * segundoOperando;
                    break;
                case "division":
                    resultado = primerOperando / segundoOperando;
                    break;
                default:
                    break;
            }
            return resultado;
        }

    }
}
