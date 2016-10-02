using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto01
{
    class ControladorGui
    {
        Dto dto;
        private IAlgoritmoFactory Ialgoritmo;
        private Algoritmo algoritmo;
        private String[] algoritmos;
        int cnt = 0;
        String algoritmoActivo;

        public ControladorGui()
        {
            dto = new Dto();
            dto.TiraFinal = new List<string>();
            dto.Abecedario = "abcdefghijklmnopqrstuvwxyz";
        }
//-------------------------------------------------------------------------------

        public void obtenerAlgoritmos(String objeto)
        {
            String texto=objeto.ToString(); 
            algoritmos = texto.Split();
            dto.TipoAlgoritmo = algoritmos;
           
        }
 //------------------------------------------------------------------------------------

        public void obtenerModo(String modo)
        {
            dto.Modo = modo;
        }
//---------------------------------------------------------------------------------------
        public void obtenerClave(String clave)
        {
            dto.Clave = clave;
        }
//---------------------------------------------------------------------------------------
        public void obtenerOracion(String tiraInicial)
        {
            dto.TiraInicial = tiraInicial;
        }
//------------------------------------------------------------------------------------------
        public void ejecutar(String algoritmoActual)
        {

            algoritmoActivo = algoritmoActual;
            
           
            if (dto.Modo == "Codificar")
            {

                codificar(dto);
            }
            else
            {
                decodificar(dto);
            }
        }

//---------------------------------------------------------------------------------
        public void decodificar(Dto dto)
        {
            int y = 0;

            while (y < dto.TipoAlgoritmo.Length)
            {

                if (algoritmoActivo == "Clave")
                {
                    Ialgoritmo = new ClaveFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.decodificar(dto);
                }

                if (algoritmoActivo == "Vigenere")
                {
                   

                    Ialgoritmo = new VigenereFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.decodificar(dto);
                    Console.Write("Datos del algoritmo Vigenere" + Environment.NewLine);
                    mostrarResultado(dto);
                }

                if (algoritmoActivo == "Telefonico")
                {

                    Ialgoritmo = new TelefonicoFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                }
                if (algoritmoActivo == "Transposición")
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
            
            while (y < dto.TipoAlgoritmo.Length)
            {
                
                
                if (algoritmoActivo == "Clave")
                {
                    
                    Ialgoritmo = new ClaveFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                    Console.Write("Datos del algoritmo de Clave" + Environment.NewLine);
                    mostrarResultado(dto);
                }

                if (algoritmoActivo == "Vigenere")
                {
                   
                    Ialgoritmo = new VigenereFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                 
                    algoritmo.codificar(dto);
                    Console.Write("Datos del algoritmo Vigenere" + Environment.NewLine);
                    mostrarResultado(dto);

                }

                if (algoritmoActivo == "Transposición")
                {

                    Ialgoritmo = new TransposicionFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                   
                    Console.Write("Datos del algoritmo Transposicion" + Environment.NewLine);
                    mostrarResultado(dto);
                }

                if (algoritmoActivo == "Telefonico")
                {

                    Ialgoritmo = new TelefonicoFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                }


                y++;
            }

        }
//--------------------------------------------------------------------------------
//Cambiar para mostrar en pantalla
        public void mostrarResultado(Dto dto)
        {
            DateTime d = DateTime.Now;
            Console.Write("Fecha de Solicitud : {0}", d + Environment.NewLine);
            Console.Write("Modo : {0}", dto.Modo + Environment.NewLine);
            Console.Write("Palabra original : {0}", dto.TiraInicial + Environment.NewLine);
            Console.Write("Resultado : {0}", dto.TiraFinal[cnt] + Environment.NewLine + Environment.NewLine);

            cnt++;
            //Console.Write("Palabra original : {0}", dto.TiraInicial);
        }



    }
}
