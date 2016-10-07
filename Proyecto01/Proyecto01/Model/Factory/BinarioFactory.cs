using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class BinarioFactory : IAlgoritmoFactory
    {
        public Algoritmo crearAlgoritmo()
        {
            Algoritmo binario = new BinarioAdapter();

            return binario;
        }
    }
}
