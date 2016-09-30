using System;
using System.Text;

namespace Proyecto01
{
    public class AlgoritmoCesar : Algoritmo
    {
     
        private String tiraFinal;
        private String tiraInicial;
        private String clave;
        private String abc;
        private int digito1;
        private int digito2;
        private int y = 0;
        private StringBuilder sb = new StringBuilder();

//------------------------------------------------------------------------------------------------------------
        public override void codificar(Dto dto)
        {

            abc = dto.Abecedario;
            tiraInicial = dto.TiraInicial;
            clave = dto.Clave;
            charToint(clave);

            char[] abecedario = abc.ToCharArray();
            String[] oraciones = tiraInicial.Split(' ');
//------------------------------------------------------------------------------------------------------------

            while (y < oraciones.Length)
            {
                String oracionActual = oraciones[y];


                for (int i = 0; i < oracionActual.Length; i++)
                {
                    for (int x = 0; x < abecedario.Length; x++)
                    {
                       
                        if (oracionActual[i]==abecedario[x] && i % 2 == 0)
                        {
                            
                            if (x + digito1 >= abecedario.Length)
                            {

                                sb.Append(abecedario[x + digito1 -abecedario.Length]);
                            }
                            else
                            {
                               
                                sb.Append(abecedario[(x + digito1)]);
                            }
                            
                            
                        }

                        if (oracionActual[i] == abecedario[x] && i % 2 != 0)
                        {

                           
                            if (x + digito2 >= abecedario.Length)
                            {

                                sb.Append(abecedario[x + digito2 - abecedario.Length]);
                            }
                            else
                            {
                                sb.Append(abecedario[(x + digito2)]);
                            }
                        }
                    }    tiraFinal = sb.ToString();
                }

                y++;
                sb.Append(' ');
                sb.ToString();

            }

            Console.Write(tiraFinal);


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

                            if (x - digito1 <0)
                            {

                                sb.Append(abecedario[x - digito1 + abecedario.Length]);
                            }
                            else
                            {

                                sb.Append(abecedario[(x - digito1)]);
                            }


                        }

                        if (oracionActual[i] == abecedario[x] && i % 2 != 0)
                        {


                            if (x - digito2 < 0)
                            {

                                sb.Append(abecedario[x - digito2 + abecedario.Length]);
                            }
                            else
                            {
                                sb.Append(abecedario[(x - digito2)]);
                            }
                        }
                    }
                    tiraFinal = sb.ToString();
                }

                y++;

                sb.Append(' ');
                sb.ToString();

            }

            Console.Write(tiraFinal);


        }


        //---------------------------------------------------------------------------------------------------------------------
        public void charToint(String clave)
        {
            
            digito1 = Convert.ToInt32(clave[0].ToString());
            digito2 = Convert.ToInt32(clave[1].ToString());
        }
    }
}
