using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class TransposicionFactory : AlgoritmoFactory
    {
        public Algoritmo crearAlgoritmo()
        {
            Transposicion transposicion = new Transposicion();

            return transposicion;
        }
    }
}
