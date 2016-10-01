using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class TXT : IEscritorStrategy
    {
        private String tiraFinal;
        private String tiraInicial;
        private String clave;
        private String abc;
        private String tipoAlgoritmo;
        private String modo;
        private String tiraEscribir;

        public void findEscritor(Dto dto)
        {
            //Path Kevin:
            //Path Juan:
            //Path Daniel:
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:C:\Users\Flo\Desktop\WriteLines2.txt");
            tiraEscribir = "Entrada: " + tiraInicial + "\nSalida: " + tiraFinal + "\nAbecedario: " + abc + "\nAlgoritmo: " + tipoAlgoritmo;
            System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", tiraEscribir);
        }
    }
}
