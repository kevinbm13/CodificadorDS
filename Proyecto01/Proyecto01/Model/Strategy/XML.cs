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

        public void escribirArchivo(Dto dto)
        {
            String abc = dto.Abecedario;
            String tiraInicial = dto.TiraInicial;
            List<string> tiraFinal = dto.TiraFinal;
            String[] tipoAlgoritmo = dto.TipoAlgoritmo;
            String modo = dto.Modo;
            
            String ruta = AppDomain.CurrentDomain.BaseDirectory + "archivoXML";
            ruta = ruta + archivo + ".xml";
            System.IO.StreamWriter file = new System.IO.StreamWriter(ruta);

            int indice = 0;
            file.WriteLine("<? xml version = \"1.0\" encoding = \"UTF-8\" ?>");
            file.WriteLine("<Entrada>" + Environment.NewLine + "\t" + tiraInicial + Environment.NewLine + "</Entrada>");
            file.WriteLine("<Abecedario> " + Environment.NewLine + "\t" + abc + Environment.NewLine + "</Abecedario>");
            file.WriteLine("<Algoritmos>");
            foreach (String algoritmo in tipoAlgoritmo)
            {
                file.WriteLine("\t<Algoritmo>" + Environment.NewLine + "\t\t" + algoritmo + Environment.NewLine + "\t</Algoritmo>");
                file.WriteLine("\t<Modo>" + Environment.NewLine + "\t\t" + modo + Environment.NewLine + "\t</Modo>");
                file.WriteLine("\t<Salida>" + Environment.NewLine + "\t\t" + tiraFinal[indice] + Environment.NewLine + "\t</Salida>");
                indice++;
            }
            file.WriteLine("</Algoritmos>");
            archivo++;
            file.Close();
        }
    }
}
