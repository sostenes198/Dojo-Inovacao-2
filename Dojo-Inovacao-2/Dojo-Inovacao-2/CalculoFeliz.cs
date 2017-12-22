using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo_Inovacao_2
{
    public class CalculoFeliz
    {
        public bool NumeroEhFeliz(int num)
        {
            if (num == 1)
                return true;

            List<int> numerosTestados = new List<int>();

            int resultado = num;
            while (resultado > 1)
            {

                var numeros = resultado.ToString().ToCharArray().Select(o => Convert.ToInt32(o.ToString())).ToArray();

                    resultado = CalculandoPotencias(numeros);
                
                if (numerosTestados.Contains(resultado))
                {
                    return false;
                }
                

                numerosTestados.Add(resultado);
            }

            return resultado == 1;
        }

        private int CalculandoPotencias(params int[] numeros)
        {
            int soma = 0;

            foreach (var item in numeros)
            {
                soma += (item * item);                  
            }

            return soma;
        }
    }
}
