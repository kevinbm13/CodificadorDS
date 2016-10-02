using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class TXT : IEscritorStrategy
    {
        private static int archivo = 1;
        private List<String> tiraFinal; 
        private String tiraInicial;
        private String abc;
        private String[] tipoAlgoritmo;
        private String modo;

        public void escribirArchivo(Dto dto)
        {
            abc = dto.Abecedario;
            tiraInicial = dto.TiraInicial;
            tiraFinal = dto.TiraFinal;
            tipoAlgoritmo = dto.TipoAlgoritmo;
            modo = dto.Modo;

            String ruta = AppDomain.CurrentDomain.BaseDirectory + "/" + "archivoTXT";
            ruta = ruta + archivo + ".txt";
            System.IO.StreamWriter file = new System.IO.StreamWriter(ruta);

            int indice = 0;
            file.WriteLine("Entrada: " + tiraInicial);
            file.WriteLine("Abecedario: " + abc);
            foreach (String algoritmo in tipoAlgoritmo)
            {
                file.WriteLine("");
                file.WriteLine("Algoritmo: " + tipoAlgoritmo);
                file.WriteLine("Modo: " + modo);
                file.WriteLine("Salida: " + tiraFinal[indice]);
                indice++;
            }
            archivo++;
        }
    }
}
