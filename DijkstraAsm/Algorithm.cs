using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAsm;

public static class Algorithm
{
    public static Dictionary<int, int> ComputeShortestDistances(Graph graph)
    {
        var distances = new Dictionary<int, int>();
        var visited = new HashSet<int>();
        var nodes = graph.Connections.SelectMany(c => new[] { c.IdNodeA, c.IdNodeB }).Distinct().ToList();

        foreach (var node in nodes)
        {
            distances[node] = int.MaxValue;
        }
        distances[graph.StartNode] = 0;

        while (visited.Count < nodes.Count)
        {
            var currentNode = nodes
                .Where(n => !visited.Contains(n))
                .OrderBy(n => distances[n])
                .FirstOrDefault();

            if (distances[currentNode] == int.MaxValue)
                break; 

            visited.Add(currentNode);

            var neighbors = graph.Connections
                .Where(c => c.IdNodeA == currentNode || c.IdNodeB == currentNode)
                .Select(c => (Neighbor: c.IdNodeA == currentNode ? c.IdNodeB : c.IdNodeA, Weight: c.Weight));

            foreach (var (neighbor, weight) in neighbors)
            {
                if (visited.Contains(neighbor))
                    continue;

                int newDistance = distances[currentNode] + weight;
                if (newDistance < distances[neighbor])
                {
                    distances[neighbor] = newDistance;
                }
            }
        }

        return distances;
    }

    public static List<int> GetShortestPath(Graph graph)
    {
        var distances = ComputeShortestDistances(graph);
        if (distances[graph.EndNode] == int.MaxValue)
            return new List<int>(); 

        var path = new List<int>();
        var currentNode = graph.EndNode;

        while (currentNode != graph.StartNode)
        {
            path.Add(currentNode);

            int? nextNode = null;
            foreach (var connection in graph.Connections)
            {
                if (connection.IdNodeA == currentNode || connection.IdNodeB == currentNode)
                {
                    var neighbor = connection.IdNodeA == currentNode ? connection.IdNodeB : connection.IdNodeA;
                    if (distances[neighbor] + connection.Weight == distances[currentNode])
                    {
                        nextNode = neighbor;
                        break;
                    }
                }
            }

            if (nextNode == null)
                return new List<int>();

            currentNode = nextNode.Value;
        }

        path.Add(graph.StartNode);
        path.Reverse();
        return path;
    }
}
