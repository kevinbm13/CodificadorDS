using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dto dto = new Dto();
            dto.Abecedario = "abcdefghijklmnopqrstuvwxyz";
            dto.TiraInicial = "vdthc ruqjtdodfd euksvriucikd fh fdvru bbidnvml jhpuan ";
            dto.Clave = "23";
            Algoritmo alg = new AlgoritmoCesar(); 
       
            alg.decodificar(dto);
            
        }
    }
}
