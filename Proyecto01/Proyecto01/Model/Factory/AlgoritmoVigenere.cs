using System;
using System.Text;

namespace Proyecto01
{
    public class AlgoritmoCesar : Algoritmo
    {
     
        private String tiraFinal;                   // Oracion Inicial
        private String tiraInicial;                 //Resultado
        private String clave;                       //Clave
        private String abc;                         //Abecedario
        private int digito1;                        //Primer digito de la clave
        private int digito2;                        //Segundo digito de la clave
        private int y = 0;                          //Contador para el arreglo de palabras
        private StringBuilder sb = new StringBuilder();

//------------------------------------------------------------------------------------------------------------
        public override void codificar(Dto dto)
        {

            abc = dto.Abecedario;
            tiraInicial = dto.TiraInicial;  //Variables.Se les da los valores del dto
            clave = dto.Clave;
            charToint(clave);

            char[] abecedario = abc.ToCharArray(); //el abecedario es convertido en un array de char
            String[] oraciones = tiraInicial.Split(' ');// la oracion se convierte en un array de palabras
       

            while (y < oraciones.Length)
            {
                String oracionActual = oraciones[y];


                for (int i = 0; i < oracionActual.Length; i++)
                {
                    for (int x = 0; x < abecedario.Length; x++)
                    {
                       
                        if (oracionActual[i]==abecedario[x] && i % 2 == 0)
                        {
                            cambiarLetraCodificar(x,abecedario,digito1);   
                        }

                        if (oracionActual[i] == abecedario[x] && i % 2 != 0)
                        {
                            cambiarLetraCodificar(x,abecedario,digito2);
                        }


                    }    tiraFinal = sb.ToString();
                }

                y++;
                sb.Append(' ');
                sb.ToString();

            }

            dto.TiraFinal.Add(tiraFinal);


        }

 //------------------------------------------------------------------------------------------------------------

        public override void decodificar(Dto dto)
        {

            abc = dto.Abecedario;
            tiraInicial = dto.TiraInicial;
            clave = dto.Clave;
            charToint(clave);

            char[] abecedario = abc.ToCharArray();
            String[] oraciones = tiraInicial.Split(' ');

            while (y < oraciones.Length)
            {
                String oracionActual = oraciones[y];


                for (int i = 0; i < oracionActual.Length; i++)
                {
                    for (int x = 0; x < abecedario.Length; x++)
                    {

                        if (oracionActual[i] == abecedario[x] && i % 2 == 0)
                        {

                            cambiarLetraDecodificar(x,abecedario,digito1);


                        }

                        if (oracionActual[i] == abecedario[x] && i % 2 != 0)
                        {
                            cambiarLetraDecodificar(x,abecedario,digito2);
                        }
                    }
                    tiraFinal = sb.ToString();
                }

                y++;

                sb.Append(' ');
                sb.ToString();

            }

            dto.TiraFinal.Add(tiraFinal);

        }

 //---------------------------------------------------------------------------------------------------------------------
        public void charToint(String clave)
        {
            if (clave.Length != 2)
            {
                Console.Write("La clave debe de ser de 2 Dígitos"+Environment.NewLine);
                Environment.Exit(0);
            }
            else
            {
                digito1 = Convert.ToInt32(clave[0].ToString());
                digito2 = Convert.ToInt32(clave[1].ToString());
            }
            
        }

 //--------------------------------------------------------------------------------------------------------------

        public void cambiarLetraCodificar(int posicionActual, char[]abecedario,int digito)
        {
            if (posicionActual + digito >= abecedario.Length)
            {

                sb.Append(abecedario[posicionActual + digito - abecedario.Length]);
            }
            else
            {

                sb.Append(abecedario[(posicionActual + digito)]);
            }
        }
//----------------------------------------------------------------------------------------------------

        public void cambiarLetraDecodificar(int posicionActual,char[]abecedario,int digito)
        {
            if (posicionActual - digito < 0)
            {

                sb.Append(abecedario[posicionActual - digito + abecedario.Length]);
            }
            else
            {

                sb.Append(abecedario[(posicionActual - digito)]);
            }
        }
        
    }
}
