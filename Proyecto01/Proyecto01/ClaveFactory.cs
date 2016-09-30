using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class ClaveFactory : AlgoritmoFactory
    {
        public Algoritmo crearAlgoritmo()
        {
            Clave clave = new Clave();

            return clave;
        }
    }
}