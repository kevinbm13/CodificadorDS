using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class VigenereFactory : IAlgoritmoFactory
    {
        public Algoritmo crearAlgoritmo()
        {
           Algoritmo vigenere = new AlgoritmoCesar();

            return vigenere;
        }
    }
}
