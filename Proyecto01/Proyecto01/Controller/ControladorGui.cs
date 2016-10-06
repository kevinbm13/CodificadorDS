using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        String textoArch;
        String[] oraciones;
        private String[] formatos;
        private Algoritmo[] arrayAlgoritmos;
        private IAlgoritmoFactory[] arrayAlgoritmosFactory;

        public ControladorGui()
        {
            texto = null;
            dto = new Dto();
            dto.TiraFinal = new List<string>();
            dto.Clave = null;
           

        }
//-------------------------------------------------------------------------------

        public void obtenerAlgoritmos(String objeto)
        {
            texto = objeto;
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

//-------------------------------------------------------------------
        public void obtenerArchivos(String objeto)
        {
            textoArch = objeto;
            formatos = textoArch.Split(' ');
            dto.TipoArchivo = formatos;
            //while()
            //Console.WriteLine(formatos[0]);
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
            incializarAbecedario();
          
            
           
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
        public void archivar()
        {
            ArchivoFinder buscadorTipoArchivo = new ArchivoFinder();
            buscadorTipoArchivo.escritorFinder(dto);
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


        //-------------------------------------------------------------------------------------------
        public static IEnumerable<T> GetEnumerableOfType<T>(params object[] constructorArgs) where T : class
        {
            List<T> objects = new List<T>();
            foreach (Type type in
            Assembly.GetAssembly(typeof(T)).GetTypes()
            .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T))))
            {
                objects.Add((T)Activator.CreateInstance(type, constructorArgs));
            }
            
            return objects;
        }


        //--------------------------------------------------------------------------------------------------------------------
        public void codificar(Dto dto)

        {
            IEnumerable<Algoritmo> s = GetEnumerableOfType<Algoritmo>();
            arrayAlgoritmos = s.ToArray();
           
            for (int i=0; i < arrayAlgoritmos.Length; i++)
            {
              
                if (algoritmoActivo == arrayAlgoritmos[i].ToString())
                {

                    arrayAlgoritmos[i].codificar(dto);
                    mostrarResultado(dto);
                }
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

//-----------------------------------------------------------------------------------
        public List<String> agregarOpciones()
        {
            List<String> nombre = new List<string>();
            IEnumerable<Algoritmo> s = GetEnumerableOfType<Algoritmo>();
            arrayAlgoritmos = s.ToArray();
           
            foreach (Algoritmo m in arrayAlgoritmos)
            {
              
                Console.Write(m.ToString());
                nombre.Add(m.ToString());
            }
            return nombre;
        }
//-----------------------------------------------------------------------------------------

        public void crearMensajedeErrorClave()
        {

            MessageBox.Show("Clave posee mas de 2 dígitos");
            Environment.Exit(0);
        }
        public void incializarAbecedario()
        {
            String ruta = AppDomain.CurrentDomain.BaseDirectory + "abecedario.txt";
            string text = System.IO.File.ReadAllText(ruta);
            Console.Write(text);
            dto.Abecedario = text;
        }
        


    }
}
