using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto01
{
    class AlgoritmoClave : Algoritmo
    {

        private int y = 0;
        private int k = 0;
        private String clave = "tango";
        private String tiraFinal;
        private StringBuilder sb = new StringBuilder();
        public override void codificar(string abc, string tiraInicial)
        {
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
            Console.Write(tiraFinal);
        }

        public override void decodificar(string abecedario, string tiraInicial)
        {
            
        }
    }
}
