using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Tijolos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exemplo de uso
            var wall = new List<IList<int>> {
            new List<int> {1, 2, 2, 1},
            new List<int> {3, 1, 2},
            new List<int> {1, 3, 2},
            new List<int> {2, 4},
            new List<int> {3, 1, 2},
            new List<int> {1, 3, 1, 1}
        };

            int linhas = LeastBricks(wall);

            Console.WriteLine(LeastBricks(wall)); // Saída esperada: 2


        }



        public static int LeastBricks(IList<IList<int>> wall)
        {
            // Dicionário para armazenar a frequência das bordas
            Dictionary<int, int> edgeFrequency = new Dictionary<int, int>();

            // Percorre cada linha da parede
            foreach (var row in wall)
            {
                int edgePosition = 0;

                // Percorre cada tijolo na linha, exceto o último tijolo
                for (int i = 0; i < row.Count - 1; i++)
                {
                    edgePosition += row[i];

                    // Aumenta a contagem de frequência da borda
                    if (edgeFrequency.ContainsKey(edgePosition))
                    {
                        edgeFrequency[edgePosition]++;
                    }
                    else
                    {
                        edgeFrequency[edgePosition] = 1;
                    }
                }
            }

            // Encontra a borda com a frequência máxima
            int maxEdges = 0;
            foreach (var count in edgeFrequency.Values)
            {
                if (count > maxEdges)
                {
                    maxEdges = count;
                }
            }

            // O menor número de tijolos cortados é a altura da parede menos o número máximo de bordas encontradas
            return wall.Count - maxEdges;
        }
    }
}
