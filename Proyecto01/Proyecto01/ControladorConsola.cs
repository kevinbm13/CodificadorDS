using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class ControladorConsola
    {
        IAlgoritmoFactory Ialgoritmo;
        Algoritmo algoritmo;
        String texto;
        String[] oraciones;

        public void ejecutar()
        {
            
            Dto dto = new Dto();
            dto.Abecedario = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine("Ingrese el algoritmo a utilizar");
            Console.WriteLine("Si desea utilizar mas de un algoritmo separalo por espacios");
            texto = Console.ReadLine();
            
            oraciones = texto.Split(' ');
            dto.TipoAlgoritmo = oraciones;
           
            //------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Ingrese oración a utilizar");
            texto = Console.ReadLine();
            dto.TiraInicial = texto;
            //------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Ingrese operación a realizar");
            texto = Console.ReadLine();
            if (texto == "codificar")
            {
                codificar(dto);
                dto.Modo = "codificar";
            }

            if (texto == "decodificar")
            {
                decodificar(dto);
                dto.Modo = "decodificar";
            }
            Console.Write("Operación no disponible");

            //-------------------------------------------------------------------------------------------------------------           

            //Aqui iria la opción de archivo, pero no se como se implementa
            //Console.WriteLine("Ingrese tipo de archivo");
            //texto = Console.ReadLine();
            //--------------------------------------------------------------------------------------------------------------
        }








//----------------------------------------------------------------------------------------------------------------------

        public void decodificar(Dto dto)
        {
            int y = 0;

            while (y < oraciones.Length)
            {
                String oracionActual = dto.TipoAlgoritmo[y];

                if (oracionActual == "clave")
                {
                    Console.WriteLine("Ingrese la clave");
                    texto = Console.ReadLine();
                    dto.Clave = texto;

                    Ialgoritmo = new ClaveFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                }

                if (oracionActual == "vigenere")
                {
                    Console.WriteLine("Ingrese la clave");
                    texto = Console.ReadLine();
                    dto.Clave = texto;

                    Ialgoritmo = new VigenereFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                }

                if (oracionActual == "vigenre")
                {

                    Ialgoritmo = new TelefonicoFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                }
                if (oracionActual == "transposicion")
                {

                    Ialgoritmo = new TransposicionFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                }
                y++;

               
            }

            Console.Write("ALGORITMO NO DISPONIBLE");
        }

//--------------------------------------------------------------------------------------------------------------------
        public void codificar(Dto dto)

        {
            int y = 0;

            while (y < oraciones.Length)
            {
                String oracionActual = dto.TipoAlgoritmo[y];

                if (oracionActual == "clave")
                {
                   Console.WriteLine("Ingrese la clave para el algoritmo de Clave");
                    texto = Console.ReadLine();
                    dto.Clave = texto;
                    Ialgoritmo = new ClaveFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                    Console.Write("Datos del algoritmo de Clave"+Environment.NewLine);
                    mostrarResultadoClave(dto);
                }

                if (oracionActual == "vigenere")
                {
                    Console.WriteLine("Ingrese la clave para el algoritmo Vigenere");
                    texto = Console.ReadLine();
                    dto.Clave = texto;
                    Ialgoritmo = new VigenereFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                    Console.Write("Datos del algoritmo Vigenere"+Environment.NewLine);
                    mostrarResultadoClave(dto);

                }

                if (oracionActual == "vigenre")
                {

                    Ialgoritmo = new TelefonicoFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                }
                if (oracionActual == "transposicion")
                {

                    Ialgoritmo = new TransposicionFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                }
                y++;
            }

            Console.Write("ALGORITMO NO DISPONIBLE");
        }

 //-----------------------------------------------------------------------------------------------------------------------
        private void mostrarResultado(Dto dto)
        {
            Console.Write("Palabra original : {0}", dto.TiraInicial + Environment.NewLine);
            Console.Write("Resultado : {0}", dto.TiraFinal+ Environment.NewLine);
            //Console.Write("Palabra original : {0}", dto.TiraInicial);
        }

        private void mostrarResultadoClave(Dto dto)
        {
            Console.Write("Palabra original : {0}", dto.TiraInicial+Environment.NewLine);
            Console.Write("Resultado : {0}", dto.TiraFinal+Environment.NewLine);
            Console.Write("Clave : {0}", dto.Clave+Environment.NewLine);
            //Console.Write("Palabra original : {0}", dto.TipoArchivo);
        }


    }
}
