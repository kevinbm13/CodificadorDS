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
        private String tiraFinal;
        private String tiraInicial;
        private String abc;
        private String tipoAlgoritmo;
        private String modo;

        public void findEscritor(Dto dto)
        {
            abc = dto.Abecedario;
            tiraInicial = dto.TiraInicial;
            tiraFinal = dto.TiraFinal;
            tipoAlgoritmo = dto.TipoAlgoritmo;
            modo = dto.Modo;
            //Path Kevin: "C:\Users\Flo\Desktop\archivo"
            //Path Juan:
            //Path Daniel:
            String ruta = @"C:\Users\Flo\Desktop\archivo";
            ruta = ruta + archivo + ".txt";
            System.IO.StreamWriter file = new System.IO.StreamWriter(ruta);
            //tiraEscribir = "Entrada: " + tiraInicial + "\nSalida: " + tiraFinal + "\nAbecedario: " + abc + "\nAlgoritmo: " + tipoAlgoritmo;

            file.WriteLine("Entrada: " + tiraInicial);
            file.WriteLine("Salida: " + tiraFinal);
            file.WriteLine("Abecedario: " + abc);
            file.WriteLine("Algoritmo: " + tipoAlgoritmo);
            file.WriteLine("Modo: " + modo);

            archivo++;
        }
    }
}
