using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchedulerUtils
{
    public static class Conversor
    {
        const string TRUE = "true";
        const string FALSE = "false";

        /// <summary>
        /// Pasándole un string comprueba si está vacío o no y devuelve un float?
        /// </summary>
        /// <param name="parametro">Cadena a comprobar</param>
        /// <returns>Null si la cadena está vacía o no es parseable a float, float si la cadena es parseable</returns>
        public static float? ConvertToFloatNullable(string parametro)
        {
            if (string.IsNullOrEmpty(parametro))
            {
                return null;
            }
            else
            {
                float valor;
                if (!float.TryParse(parametro, out valor))
                {
                    return null;
                }
                else
                {
                    return valor;
                }
            }
        }

        /// <summary>
        /// Pasándole un string comprueba si está vacío o no y devuelve un int?
        /// </summary>
        /// <param name="parametro">Cadena a comprobar</param>
        /// <returns>Null si la cadena está vacía o no es parseable a int, int si la cadena es parseable</returns>
        public static int? ConvertToIntNullable(string parametro)
        {
            if (string.IsNullOrEmpty(parametro))
            {
                return null;
            }
            else
            {
                int valor;
                if (!int.TryParse(parametro, out valor))
                {
                    return null;
                }
                else
                {
                    return valor;
                }
            }
        }

        /// <summary>
        /// Pasándole un string comprueba si está vacío o no y devuelve un float
        /// </summary>
        /// <param name="parametro">Cadena a comprobar</param>
        /// <returns>0 si la cadena está vacía o no es parseable a float, float si la cadena es parseable</returns>
        public static float ConvertToFloat(string parametro)
        {
            if (string.IsNullOrEmpty(parametro))
            {
                return 0;
            }
            else
            {
                float valor;
                if (!float.TryParse(parametro, out valor))
                {
                    return 0;
                }
                else
                {
                    return valor;
                }
            }
        }

        /// <summary>
        /// Pasándole un string comprueba si está vacío o no y devuelve un int
        /// </summary>
        /// <param name="parametro">Cadena a comprobar</param>
        /// <returns>0 si la cadena está vacía o no es parseable a int, int si la cadena es parseable</returns>
        public static int ConvertToInt(string parametro)
        {
            if (string.IsNullOrEmpty(parametro))
            {
                return 0;
            }
            else
            {
                int valor;
                if (!int.TryParse(parametro, out valor))
                {
                    return 0;
                }
                else
                {
                    return valor;
                }
            }
        }

        /// <summary>
        /// Pasándole un string comprueba si es un valor booleano verdadero o falso
        /// </summary>
        /// <param name="parametro">Cadena a comprobar</param>
        /// <returns>True si la cadena contiene TRUE, false si la cadena es igual a FALSE, false en cualquier otro caso</returns>
        public static bool ConvertToBool(string parametro)
        {
            if (parametro != null)
            {
                if (parametro.Contains(TRUE))
                {
                    return true;
                }
                else if (parametro.CompareTo(FALSE) == 0)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Pasándole un string comprueba si está vacío o no y devuelve un DateTime 
        /// </summary>
        /// <param name="parametro">Cadena a comprobar</param>
        /// <returns>null si la cadena está vacía o no es parseable a DateTime, DateTime si la cadena es parseable</returns>
        public static DateTime? ConvertToDateTime(string parametro)
        {
            if (string.IsNullOrEmpty(parametro))
            {
                return null;
            }
            else
            {
                DateTime valor;
                if (!DateTime.TryParse(parametro, out valor))
                {
                    return null;
                }
                else
                {
                    return valor;
                }
            }
        }

        /// <summary>
        /// Pasándole un float? comprueba si es null o no y devuelve un string
        /// </summary>
        /// <param name="parametro">float? a comprobar</param>
        /// <returns>Cadena vacía si el float? es null, cadena con el número en formato español si el float? tiene valor</returns>
        public static string ConvertFloatToString(float? parametro)
        {
            if (!parametro.HasValue)
            {
                return string.Empty;
            }
            else
            {
                return parametro.Value.ToString().Replace('.', ',');
            }
        }

        /// <summary>
        /// Pasándole un string intenta hacer un parse poniendo el resultado dentro del datetime pasado
        /// </summary>
        /// <param name="parametro">String a intentar convertir en DateTime</param>
        /// <param name="resultado">DateTime de destino para la conversión del string</param>
        /// <returns>True si puede convertir el string, False si no lo logra</returns>
        public static bool ConvertToDateTime(string parametro, DateTime resultado)
        {
            return DateTime.TryParse(parametro, out resultado);
        }
    }
}
