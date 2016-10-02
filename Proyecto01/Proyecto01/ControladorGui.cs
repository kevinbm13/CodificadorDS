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
        String texto;
        String[] oraciones;

        public ControladorGui()
        {
            texto = null;
            dto = new Dto();
            dto.TiraFinal = new List<string>();
            dto.Abecedario = "abcdefghijklmnopqrstuvwxyz";
            dto.Clave = null;
        }
//-------------------------------------------------------------------------------

        public void obtenerAlgoritmos(String objeto)
        {

            texto += objeto;
            algoritmos = texto.Split(' ');
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
 //-----------------------------------------------------------

          public void estaVacio(String oracion)
        {
            if (oracion == null)
            {
                Console.Write("f");
            }
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
           

                if (algoritmoActivo == "Clave")
                {
                    oracionCorrecta(dto.TiraInicial);
                    oracionCorrecta(dto.Clave);
                    Ialgoritmo = new ClaveFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.decodificar(dto);
                    mostrarResultado(dto);
                }

                if (algoritmoActivo == "Vigenere")
                {
                    oracionCorrecta(dto.TiraInicial);
                    claveIncorrecta(dto);
                    Ialgoritmo = new VigenereFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.decodificar(dto);
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
                    oracionCorrecta(dto.TiraInicial);
                    Ialgoritmo = new TransposicionFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.decodificar(dto);
                 
                    mostrarResultado(dto);
                }

             


        }

 //--------------------------------------------------------------------------------------------------------------------
        public void codificar(Dto dto)

        {

           

           

                if (algoritmoActivo == "Clave")
                {
                   
                    oracionCorrecta(dto.TiraInicial);
                    oracionCorrecta(dto.Clave);
                    Ialgoritmo = new ClaveFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                    mostrarResultado(dto);
                }

                if (algoritmoActivo == "Vigenere")
                {
                    oracionCorrecta(dto.TiraInicial);
                    claveIncorrecta(dto);
                    
                    Ialgoritmo = new VigenereFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                 
                    algoritmo.codificar(dto);
                    mostrarResultado(dto);

                }

                if (algoritmoActivo == "Transposición")
                {
               
                oracionCorrecta(dto.TiraInicial);
                    Ialgoritmo = new TransposicionFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                 
                    algoritmo.codificar(dto);
                    mostrarResultado(dto);
                }

                if (algoritmoActivo == "Telefónico")
                {

                    Ialgoritmo = new TelefonicoFactory();
                    algoritmo = Ialgoritmo.crearAlgoritmo();
                    algoritmo.codificar(dto);
                    mostrarResultado(dto);
                }


             

        }
 //--------------------------------------------------------------------------------
        public void oracionCorrecta(String oracion)
        {
            int y = 0;
           
                oraciones = oracion.Split(' ');
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
 public void escrituraClaveCorrecta(Dto dto)
        {

        }

//-------------------------------------------------------------------------------
        public void claveIncorrecta(Dto dto)
        {
            if (dto.Clave.Length != 2)
            {
                Console.Write(dto.Clave);
                crearMensajedeErrorClave();
            }
        }
 //--------------------------------------------------------------------------------
        //Cambiar para mostrar en pantalla
        public void mostrarResultado(Dto dto)
        {
            foreach (String f in dto.TipoAlgoritmo)
            {
                Console.Write(f);
            }

            DateTime d = DateTime.Now;
            String algoritmo = "Resultado :" + algoritmoActivo+Environment.NewLine;
            String fecha="Fecha de Solicitud :"+d+Environment.NewLine;
            String modo="Modo :"+dto.Modo+Environment.NewLine;
            String original="Palabra original :"+ dto.TiraInicial+Environment.NewLine;
            String final="Resultado :"+dto.TiraFinal[cnt];
            String resultado =algoritmo+ fecha + modo + original + final;
            MessageBox.Show(resultado);
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
