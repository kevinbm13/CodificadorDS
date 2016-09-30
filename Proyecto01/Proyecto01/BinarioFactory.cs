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
            Binario binario = new Binario();

            return binario;
        }
    }
}
