using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto01
{
    class AlgoritmoClave : Algoritmo
    {

   //VARIABLES
        private int y = 0;
        private int k = 0;
        private String clave;
        private String tiraFinal;
        private String tiraInicial;
        private String abc;
        private StringBuilder sb = new StringBuilder();

//------------------------------------------------------------------------------------------------------

        public override void codificar(Dto dto)
        {
            abc = dto.Abecedario;
            tiraInicial = dto.TiraInicial;    //Se asiganan los campos DTO a las variables
            clave = dto.Clave;


            char[] abecedario = abc.ToCharArray();
            String[] oraciones = tiraInicial.Split(' ');

            while (y < oraciones.Length)
            {
                
                String oracionActual = oraciones[y];
               

                for (int i = 0; i < oracionActual.Length; i++)
                {

                    if (k >= clave.Length || i==0)
                    {
                        k = 0;
                    }
                    
                        int index = Array.IndexOf(abecedario, oracionActual[i]);
                  
                        int index2 = Array.IndexOf(abecedario, clave[k]);

                    if (index + index2 > abecedario.Length && k < clave.Length)
                        {
                            sb.Append(abecedario[(index + index2 - abecedario.Length)+1]);
                            tiraFinal = sb.ToString();
                            k++;

                        }
                        else 
                        {
                            sb.Append(abecedario[(index + index2)+1]);
                            tiraFinal = sb.ToString();
                            k++;
                        }
                       

                    
                        

                    
                   
                }

                sb.Append(' ');
                sb.ToString();
                y++;
            
            }
            dto.TiraFinal = tiraFinal;
            
        }
//-------------------------------------------------------------------------------------------------------------------

        public override void decodificar(Dto dto)
        {
            abc = dto.Abecedario;
            tiraInicial = dto.TiraInicial;      //SE ASIGNA LOS CAMPOS DTO A LAS VARIABLES
            clave = dto.Clave;

            char[] abecedario = abc.ToCharArray();
            String[] oraciones = tiraInicial.Split(' ');

            while (y < oraciones.Length)
            {

                String oracionActual = oraciones[y];


                for (int i = 0; i < oracionActual.Length; i++)
                {

                    if (k >= clave.Length || i == 0)
                    {
                        k = 0;
                    }

                    int index = Array.IndexOf(abecedario, oracionActual[i]);

                    int index2 = Array.IndexOf(abecedario, clave[k]);

                    if (index - index2 <0 && k < clave.Length)
                    {
                        sb.Append(abecedario[(index - index2 + abecedario.Length) - 1]);
                        tiraFinal = sb.ToString();
                        k++;

                    }
                    else
                    {
                       
                        sb.Append(abecedario[(index - index2) -1]);
                        tiraFinal = sb.ToString();
                        k++;
                    }







                }

                sb.Append(' ');
                sb.ToString();
                y++;

            }
             dto.TiraFinal = tiraFinal;
        }
    }
}
