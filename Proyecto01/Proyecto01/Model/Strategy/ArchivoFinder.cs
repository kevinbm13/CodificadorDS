using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class ArchivoFinder
    {

        public void escritorFinder(Dto dto)
        {
            String[] tipoArchivo = dto.TipoArchivo;
            int y = 0;

            while (y < tipoArchivo.Length)
            {
                IEscritorStrategy strategy;
                if (tipoArchivo[y].Equals("txt"))
                {
                    strategy = new TXT();
                    strategy.escribirArchivo(dto);
                }
                if (tipoArchivo[y].Equals("xml"))
                {
                    strategy = new XML();
                    strategy.escribirArchivo(dto);
                }
                if (tipoArchivo[y].Equals("excel"))
                {
                    strategy = new Excel();
                    strategy.escribirArchivo(dto);
                }
                y++;
            }
        }
    }
}
