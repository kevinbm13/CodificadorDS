using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class TelefonicoFactory : AlgoritmoFactory
    {
        public Algoritmo crearAlgoritmo()
        {
            Telefonico telefonico = new Telefonico();

            return telefonico;
        }
    }
}
