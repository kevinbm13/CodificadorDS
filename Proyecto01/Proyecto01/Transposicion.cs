using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class Transposicion : Algoritmo
    {
        public override string codificar(string abecedario, string tiraEntrada, string tipoAlgoritmo)
        {
            String tiraSalida = "";
            for (int x = tiraEntrada.Length - 1; x >= 0; x--)
            {
                tiraSalida += tiraEntrada[x];
            }
            
            Console.WriteLine(tiraSalida);
            return tiraSalida;
        }

        public override string decodificar(string abecedario, string tiraEntrada, string tipoAlgoritmo)
        {
            String tiraSalida = "";
            for (int x = tiraEntrada.Length - 1; x >= 0; x--)
            {
                tiraSalida += tiraEntrada[x];

            }

            Console.WriteLine(tiraSalida);
            return tiraSalida;
            
        }
    }
}
