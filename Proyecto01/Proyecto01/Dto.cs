namespace Proyecto01
{
    public class Dto
    {
        string abecedario;
        string tiraInicial;
        string tiraFinal;
        string clave;
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

        public string TiraFinal
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
    }
}