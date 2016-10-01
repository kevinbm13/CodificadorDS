using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class Transposicion : Algoritmo
    {
        public override void codificar(Dto dto)
        {
            String tiraSalida = "";
            for (int x = dto.TiraInicial.Length - 1; x >= 0; x--)
            {
                tiraSalida += dto.TiraInicial[x];
            }
            
            Console.WriteLine(tiraSalida);
           // return tiraSalida;
        }

        public override void decodificar(Dto dto)
        {
            String tiraSalida = "";
            for (int x = dto.TiraInicial.Length - 1; x >= 0; x--)
            {
                tiraSalida += dto.TiraInicial[x];

            }

            Console.WriteLine(tiraSalida);
            //return tiraSalida;
            
        }
    }
}
