using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class TransposicionFactory : IAlgoritmoFactory
    {
        public Algoritmo crearAlgoritmo()
        {
            Console.Write("estoy dentro");
            Transposicion transposicion = new Transposicion();

            return transposicion;
        }
    }
}
