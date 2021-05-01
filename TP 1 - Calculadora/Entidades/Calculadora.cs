using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {

        #region Metodos

        /// <summary>
        /// Realiza la operacion de dos objetos del tipo Numero segun el operador recibido.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>El resultado de la operacion realiza.</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;

            switch (ValidarOperador(operador[0]))
            {
                case "+":
                    retorno = num1 + num2;
                    break;
                case "-":
                    retorno = num1 - num2;
                    break;
                case "/":
                    retorno = num1 / num2;
                    break;
                case "*":
                    retorno = num1 * num2;
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// Valida que el operador recibido sea + - / * Caso contrario retorna el operador +.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static string ValidarOperador(char operador)
        {
            string retorno;

            if (operador != '+' && operador != '-' && operador != '/' && operador != '*')
            {
                retorno = "+";
            }
            else
            {
                retorno = operador.ToString();
            }

            return retorno;
        }

        #endregion

    }
}
