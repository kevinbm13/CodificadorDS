using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class Alfabeto
    {
        private List<char> caracteres; //Almacena los caracteres del alfabeto
        public Alfabeto()
        {
            this.caracteres = new List<char>();
        }

        public Alfabeto(String s)
        {
            this.setCaracteres(s);
        }

        //Separa un string y lo convierte en lista de caracteres, ej: "abc" -> ['a', 'b', 'c']
        private List<char> separateString(String s)
        {
            List<char> stringSeparado = new List<char>();
            int i;
            for (i = 0; i < s.Count(); i++)
            {
                stringSeparado.Add(s[i]);
            }

            return stringSeparado;
        }

        //Verifica la existencia de algún caracter en el alfabeto actual.
        private bool existeCaracter(char caracter)
        {
            int i;
            for (i = 0; i < this.caracteres.Count(); i++)
            {
                if (caracter == caracteres.ElementAt(i))
                {
                    return true;

                }
            }
            return false;
        }

        //Verifica que cada caracter de la frase pasada por parámetro exista en el alfabeto actual.
        public bool analisisLexico(String frase)
        {
            List<char> fraseSeparada = separateString(frase);
            int i;
            for (i = 0; i < fraseSeparada.Count(); i++)
            {
                if (!existeCaracter(fraseSeparada[i]) && fraseSeparada[i] != ' ')
                {
                    return false;
                }
            }
            return this.caracteres.Count() > 0;
        }

        /*Recibe un string, que posteriormente lo pasa por el método de separarString y
        el resultado se lo asigna al atributo caracteres*/
        public void setCaracteres(String s)
        {
            this.caracteres = separateString(s);
        }

        //Retorna el atributo caracteres
        public List<char> getCaracteres()
        {
            return this.caracteres;
        }
    }
}
