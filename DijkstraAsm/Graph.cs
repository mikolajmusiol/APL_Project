using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DijkstraAsm;

public record Connection(int IdNodeA, int IdNodeB, int Weight);

public class Graph
{
    public int StartNode { get; private set; }
    public int EndNode { get; private set; }
    public List<Connection> Connections { get; private set; } = new List<Connection>();

    public Graph(string inputPath)
    {
        using (var reader = new StreamReader(inputPath))
        {
            StartNode = int.Parse(reader.ReadLine());
            EndNode = int.Parse(reader.ReadLine());
            
            Regex reg = new Regex(@"\d+");

            string line;

            while((line = reader.ReadLine()) != null)
            {
                var match = reg.Matches(line);

                Connections.Add(new Connection(
                    int.Parse(match[0].Value), 
                    int.Parse(match[1].Value), 
                    int.Parse(match[2].Value)));
            }
        };
    }

    public int[] ToAdjacencyMatrix()
    {
        int maxNode = Connections.SelectMany(c => new[] { c.IdNodeA, c.IdNodeB }).Max();

        int[,] matrix = new int[maxNode + 1, maxNode + 1];

        for (int i = 0; i <= maxNode; i++)
            for (int j = 0; j <= maxNode; j++)
                matrix[i, j] = 0;

        foreach (var connection in Connections)
        {
            matrix[connection.IdNodeA, connection.IdNodeB] = connection.Weight;
            matrix[connection.IdNodeB, connection.IdNodeA] = connection.Weight;
        }

        int size = (maxNode + 1) * (maxNode + 1);
        int[] flatArray = new int[size];

        for (int i = 0; i <= maxNode; i++)
            for (int j = 0; j <= maxNode; j++)
                flatArray[i * (maxNode + 1) + j] = matrix[i, j];

        return flatArray;
    }
}
