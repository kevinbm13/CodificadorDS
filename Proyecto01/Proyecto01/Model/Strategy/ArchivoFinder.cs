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
        String[] tipoArchivo;
        IEnumerable<IEscritorStrategy> escritores;

        public void escritorFinder(Dto dto)
        {
            tipoArchivo = dto.TipoArchivo;
            escritores = GetEnumerableOfType<IEscritorStrategy>();
            foreach (IEscritorStrategy p in escritores)
            {
                Console.WriteLine(p.GetType().ToString() + " 1");
            }
                

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

        public static IEnumerable<IEscritorStrategy> GetEnumerableOfType<IEscritorStrategy>(params object[] constructorArgs) where IEscritorStrategy : class
        {
            List<IEscritorStrategy> objects = new List<IEscritorStrategy>();
            foreach (Type type in Assembly.GetAssembly(typeof(IEscritorStrategy)).GetTypes()
            .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(IEscritorStrategy))))
            {
                objects.Add((IEscritorStrategy)Activator.CreateInstance(type, constructorArgs));
            }
            return objects;
        }
    }
}
