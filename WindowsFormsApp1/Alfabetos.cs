using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Alfabetos
    {
        char[] alfabetoingles = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] alfabetoespanol = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Á', 'É', 'Í', 'Ó', 'Ú' };
        char[] alfabetonumerico = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public char[] obtenerAlfabeto(string alfabetoselec)
        {
            if (alfabetoselec == "Inglés")
            {
                return alfabetoingles;
            }
            else if (alfabetoselec == "Español")
            {
                return alfabetoespanol;
            }
            else if (alfabetoselec == "Num")
            {
                return alfabetonumerico;
            }
            else
            {
                return new char[] { 'N', 'A' };
            }
        }
    }
}
