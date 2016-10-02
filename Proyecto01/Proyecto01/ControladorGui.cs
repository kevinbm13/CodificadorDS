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
            dto.Clave = null;
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
            oracionCorrecta(dto);
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

                    claveIncorrecta(dto);
                    Ialgoritmo = new VigenereFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.decodificar(dto);
                    Console.Write("Datos del algoritmo Vigenere" + Environment.NewLine);
                    mostrarResultado(dto);
                }

                if (algoritmoActivo == "Telefónico")
                {

                    Ialgoritmo = new TelefonicoFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.decodificar(dto);
                    mostrarResultado(dto);
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
                    if (dto.Clave.Length != 2 )
                    {
                        claveIncorrecta(dto);
                    }
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

                if (algoritmoActivo == "Telefónico")
                {

                    Ialgoritmo = new TelefonicoFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                    Console.Write("Datos del algoritmo Telefónico" + Environment.NewLine);
                    mostrarResultado(dto);
                }


                y++;
            }

        }
 //--------------------------------------------------------------------------------
        public void oracionCorrecta(Dto dto)
        {
            int y = 0;
            String[] oraciones = dto.TiraInicial.Split(' ');
            char[] abc = dto.Abecedario.ToCharArray();
            String clave = dto.Clave;
            while (y < oraciones.Length)
            {
                String oracionActual = oraciones[y];
                

                for (int i = 0; i < oracionActual.Length; i++)
                {

                    if (dto.Abecedario.Contains(oracionActual[i]) == false)
                    {
                        crearMensajedeErrorPalabra();
                    }

                    if (dto.Abecedario.Contains(clave[i]) == false)
                    {
                        crearMensajedeErrorClaveCaracter();
                    }

                }
                y++;
            }
        }

//-------------------------------------------------------------------------------
        public void claveIncorrecta(Dto dto)
        {
            if (dto.Clave.Length != 2)
            {
                crearMensajedeErrorClave();
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
//-----------------------------------------------------------------------------------------
       public void crearMensajedeErrorPalabra()
        {
            
            MessageBox.Show("Carácter no se encuenta en el diccionario");
            Environment.Exit(0);
        }
//------------------------------------------------------------------------
        public void crearMensajedeErrorClaveCaracter()
        {

            MessageBox.Show("Carácter invalido en la clave");
            Environment.Exit(0);
        }
//-----------------------------------------------------------------------------------------

        public void crearMensajedeErrorClave()
        {

            MessageBox.Show("Clave posee mas de 2 dígitos");
            Environment.Exit(0);
        }



    }
}
