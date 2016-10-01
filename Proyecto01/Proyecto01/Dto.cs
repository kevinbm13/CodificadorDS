using System;

namespace Proyecto01
{
    
    public class Dto
    {
        string abecedario;
        string tiraInicial;
        List<string> tiraFinal;
        string clave;
        string modo;
        string[] tipoAlgoritmo;
        string[] tipoArchivo;
       

        public string Abecedario
        {
            get
            {
                return abecedario;
            }

            set
            {
                abecedario = value;
            }
        }

        public string TiraInicial
        {
            get
            {
                return tiraInicial;
            }

            set
            {
                tiraInicial = value;
            }
        }

        public string[] TiraFinal
        {
            get
            {
                return tiraFinal;
            }

            set
            {
                tiraFinal = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }

        public string[] TipoArchivo
        {
            get
            {
                return tipoArchivo;
            }

            set
            {
                tipoArchivo = value;
            }
        }

        public string[] TipoAlgoritmo
        {
            get
            {
                return tipoAlgoritmo;
            }

            set
            {
                tipoAlgoritmo = value;
            }
        }

        public string Modo
        {
            get
            {
                return modo;
            }

            set
            {
                modo = value;
            }
        }
    }
}