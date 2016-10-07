using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class Binaria
    {

        /*Codifica una frase y retorna la frase codificada.*/
        public string codificar(string pString, Alfabeto alfabeto)
        {
            string stringCodificado = "";
            for (int i = 0; i < pString.Length; i++)
            {
                for (int j = 0; j < alfabeto.getCaracteres().Count(); j++)
                {
                    if (pString[i] == alfabeto.getCaracteres()[j])
                    {
                        stringCodificado += Convert.ToString(j, 2).PadLeft(5, '0');
                    }
                }
                if (pString[i] == ' ')
                {
                    stringCodificado += "*";
                }
                if (pString.Length - 1 != i)
                {
                    stringCodificado += " ";
                }

            }
            return stringCodificado;
        }

        /*Decodifica una frase y retorna la clase decodificada*/
        public string decodificar(string pString, Alfabeto alfabeto)
        {
            for (int i = 0; i < pString.Count(); i++)
            {
                if (pString[i] != ' ' | pString[i] != '*' | pString[i] != '1' || pString[i] != '0')
                {
                    throw new Exception("Para decodificar el algoritmo binario debe de recibir una hilera con solo 1's, 0's o *");
                }

            }
            string stringDecodificado = "";
            string num;
            string[] stringSplit = pString.Split(' ');
            for (int i = 0; i < stringSplit.Length; i++)
            {
                if (stringSplit[i] != "*")
                {
                    num = Convert.ToInt32(stringSplit[i], 2).ToString(); //convierte de binario a decimal, devuelve un string
                    stringDecodificado += alfabeto.getCaracteres()[Int32.Parse(num)];  //toma el caracter en la posicion de num, del alfabeto
                }
                else
                {
                    stringDecodificado += " ";
                }
            }

            return stringDecodificado;
        }

        /*Retorna el nombre de la clase.*/
        public override string toString()
        {
            return "Binaria";
        }
    }
}
