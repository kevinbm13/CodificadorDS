using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class XML : IEscritorStrategy
    {
        private static int archivo = 1;
        private List<string> tiraFinal;
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
            
            String ruta = AppDomain.CurrentDomain.BaseDirectory + "/" + "archivoXML";
            ruta = ruta + archivo + ".xml";
            System.IO.StreamWriter file = new System.IO.StreamWriter(ruta);

            int indice = 0;
            file.WriteLine("<Entrada>" + Environment.NewLine + "\t" + tiraInicial + Environment.NewLine + "</Entrada>");
            file.WriteLine("<Abecedario> " + Environment.NewLine + "\t" + abc + Environment.NewLine + "</Abecedario>");
            file.WriteLine("<Algoritmos>");
            foreach (String algoritmo in tipoAlgoritmo)
            {
                file.WriteLine("\t<Algoritmo>" + Environment.NewLine + "\t" + algoritmo + "</Algoritmo>");
                file.WriteLine("\t<Modo>" + Environment.NewLine + "\t" + modo + "</Modo>");
                file.WriteLine("\t<Salida>" + Environment.NewLine + "\t" + tiraFinal[indice] + "</Salida>");
                indice++;
            }
            file.WriteLine("</Algoritmos>");
            archivo++;
        }
    }
}
