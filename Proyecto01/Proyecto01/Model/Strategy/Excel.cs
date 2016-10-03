using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class Excel : IEscritorStrategy
    {
        private static int archivo = 1;

        public void escribirArchivo(Dto dto)
        {
            String abc = dto.Abecedario;
            String tiraInicial = dto.TiraInicial;
            List<String> tiraFinal = dto.TiraFinal;
            String[] tipoAlgoritmo = dto.TipoAlgoritmo;
            String modo = dto.Modo;
            
            String ruta = AppDomain.CurrentDomain.BaseDirectory + "archivoExcel";
            ruta = ruta + archivo + ".csv";
            System.IO.StreamWriter file = new System.IO.StreamWriter(ruta);

            int indice = 0;
            file.WriteLine("Entrada, " + tiraInicial);
            file.WriteLine("Abecedario, " + abc);
            
            foreach (String algoritmo in tipoAlgoritmo)
            {
                file.WriteLine("");
                file.WriteLine("Algoritmo, "+ algoritmo);
                file.WriteLine("Modo, " + modo );
                file.WriteLine("Salida, " + tiraFinal[indice]);
                indice++;
            }
            archivo++;
            file.Close();
        }
    }
}
