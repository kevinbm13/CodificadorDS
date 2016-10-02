using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class ControladorConsola
    {
        private IAlgoritmoFactory Ialgoritmo;
        private Algoritmo algoritmo;
        private String texto;
        private String[] oraciones;
        private int cnt = 0;
        private int y = 0;
        private Dto dto;

        public ControladorConsola()
        {
            dto = new Dto();
            dto.TiraFinal = new List<string>();  //Incializar...Esperando la lectura para cambiarlo e inicializar el dto por aparte
            
        }

        public void obtenerAlgoritmos()
        {
            Console.WriteLine("Ingrese el algoritmo a utilizar");
            Console.WriteLine("Si desea utilizar mas de un algoritmo separalo por espacios");
            texto = Console.ReadLine();
            oraciones = texto.Split(' ');
            dto.TipoAlgoritmo = oraciones;
        }

        public void obtenerOracion()
        {
            Console.WriteLine("Ingrese oración a utilizar");
            texto = Console.ReadLine();
            dto.TiraInicial = texto;
            oracionCorrecta(dto.TiraInicial);
        }

        public void obtenerModo()
        {
            Console.WriteLine("Ingrese operación a realizar");
            texto = Console.ReadLine();
            dto.Modo = texto;
        }

        public void obtenerClave()
        {
            Console.WriteLine("Ingrese la clave");
            texto = Console.ReadLine();
            dto.Clave = texto;
        }

        public void ejecutar()
        {



            //Ingresa el algoritmo a utilizar
            //----------------------------------------------------------------------------------------------------------
            obtenerAlgoritmos();


            //usuario ingresa la palabra
            //------------------------------------------------------------------------------------------------------------
            obtenerOracion();


            //Usuario elije la operacion
            //------------------------------------------------------------------------------------------------------------
            obtenerModo();
           
            if(dto.Modo != "codificar" && dto.Modo != "decodificar")
            {
                Console.Write("Modo no disponible");
            }

            if (dto.Modo == "codificar")
            {
               
                codificar(dto);

            }

            if (dto.Modo == "decodificar")
            {
                decodificar(dto);

            }



            //-------------------------------------------------------------------------------------------------------------           

            //Aqui iria la opción de archivo, pero no se como se implementa
            //Console.WriteLine("Ingrese tipo de archivo");
            //texto = Console.ReadLine();
            //--------------------------------------------------------------------------------------------------------------
            Console.ReadLine();
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
                    obtenerClave();
                    oracionCorrecta(dto.Clave);

                    Ialgoritmo = new ClaveFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.decodificar(dto);
                }

                if (oracionActual == "vigenere")
                {
                    obtenerClave();
                    
                    Ialgoritmo = new VigenereFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.decodificar(dto);
                    Console.Write("Datos del algoritmo Vigenere" + Environment.NewLine);
                    mostrarResultado(dto);
                }

                if (oracionActual == "telefonico")
                {

                    Ialgoritmo = new TelefonicoFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                }
                if (oracionActual == "transposicion")
                {

                    Ialgoritmo = new TransposicionFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.decodificar(dto);
                    Console.Write("Datos del algoritmo Transposicion" + Environment.NewLine);
                    mostrarResultado(dto);
                }

                y++;


            }


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
                    obtenerClave();
                    oracionCorrecta(dto.Clave);
                    Ialgoritmo = new ClaveFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                    Console.Write("Datos del algoritmo de Clave" + Environment.NewLine);
                    mostrarResultado(dto);
                }

                if (oracionActual == "vigenere")
                {
                    obtenerClave();
                    Ialgoritmo = new VigenereFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                    Console.Write("Datos del algoritmo Vigenere" + Environment.NewLine);
                    mostrarResultado(dto);

                }

                if (oracionActual == "transposicion")
                {

                    Ialgoritmo = new TransposicionFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                    Console.Write("Datos del algoritmo Transposicion" + Environment.NewLine);
                    mostrarResultado(dto);
                }

                if (oracionActual == "telefonico")
                {

                    Ialgoritmo = new TelefonicoFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                }
                

                y++;
            }

        }

        //-----------------------------------------------------------------------------------------------------------------------
        public void mostrarResultado(Dto dto)
        {
            DateTime d = DateTime.Now;
            Console.Write("Fecha de Solicitud : {0}", d + Environment.NewLine);
            Console.Write("Modo : {0}", dto.Modo + Environment.NewLine);
            Console.Write("Palabra original : {0}", dto.TiraInicial + Environment.NewLine);
            Console.Write("Resultado : {0}", dto.TiraFinal[cnt] + Environment.NewLine+Environment.NewLine);

            cnt++;
            
        }
//------------------------------------------------------------------------------------
        public void crearMensajedeErrorPalabra()
        {
            Console.Write("Caracter invalido");
            Environment.Exit(0);
        }
        //--------------------------------------------------------------------
        public void incializarAbecedario()
        {
            string text = System.IO.File.ReadAllText("C:\\Users\\gollo\\Desktop\\abecedario.txt");
            Console.Write(text);
            dto.Abecedario = text;
        }
        //-----------------------------------------------------------------------------------------------------------
        public void oracionCorrecta(String oracion)
        {
            int y = 0;
            String[] oraciones = oracion.Split(' ');
            char[] abc = dto.Abecedario.ToCharArray();

            while (y < oraciones.Length)
            {
                String oracionActual = oraciones[y];


                for (int i = 0; i < oracionActual.Length; i++)
                {

                    if (dto.Abecedario.Contains(oracionActual[i]) == false)
                    {
                        crearMensajedeErrorPalabra();
                    }


                }
                y++;
            }
        }
    }
}
        

