using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
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
