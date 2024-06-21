using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tijolo_Teste
{
    public class Parede_Tijolos
    {
        public int Montando_Linha(IList<IList<int>> Linhas)
        {

            Dictionary<int, int> Limite_Bordas = new Dictionary<int, int>();

            foreach (var Coluna in Linhas)
            {
                int Posicoes = 0;
                for (int i = 0; i < Coluna.Count - 1; i++)
                {

                    Posicoes += Coluna[i];

                    if (Limite_Bordas.ContainsKey(Posicoes))
                    {
                        Limite_Bordas[Posicoes]++;
                    }
                    else
                    {
                        Limite_Bordas[Posicoes] = 1;
                    }
                }
            }
            int Maximo_Bordas = 0;
            foreach (var Contador in Limite_Bordas.Values)
            {

                if (Contador > Maximo_Bordas)
                {
                    Maximo_Bordas = Contador;
                }
            }
            return Linhas.Count - Maximo_Bordas;
        }
    }
}
