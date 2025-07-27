using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Alfabetos
    {
        char[] alfabetoingles = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] alfabetoespanol = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Á', 'É', 'Í', 'Ó', 'Ú', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'á', 'é', 'í', 'ó', 'ú' };
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
