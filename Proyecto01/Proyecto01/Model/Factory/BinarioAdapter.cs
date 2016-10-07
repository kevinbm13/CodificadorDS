using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class BinarioAdapter : Algoritmo
    {
        Binaria algBinario = new Binaria();
        public override void codificar(Dto dto)
        {
            dto.TiraFinal.Add(algBinario.codificar(dto.TiraInicial,dto.Abecedario));
        }

        public override void decodificar(Dto dto)
        {
            dto.TiraFinal.Add(algBinario.codificar(dto.TiraInicial, dto.Abecedario));
        }
    }
}
