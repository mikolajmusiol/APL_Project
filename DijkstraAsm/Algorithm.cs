using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAsm;

public class Algorithm
{
    public Dictionary<int, int> ComputeShortestDistances(Graph graph)
    {
        var distances = new Dictionary<int, int>();
        var visited = new HashSet<int>();
        var nodes = graph.Connections.SelectMany(c => new[] { c.IdNodeA, c.IdNodeB }).Distinct().ToList();

        // Initialize distances to infinity, except the start node
        foreach (var node in nodes)
        {
            distances[node] = int.MaxValue;
        }
        distances[graph.StartNode] = 0;

        while (visited.Count < nodes.Count)
        {
            // Select the unvisited node with the smallest distance
            var currentNode = nodes
                .Where(n => !visited.Contains(n))
                .OrderBy(n => distances[n])
                .FirstOrDefault();

            if (distances[currentNode] == int.MaxValue)
                break; // Remaining nodes are unreachable

            visited.Add(currentNode);

            // Get neighbors of the current node
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

    public List<int> GetShortestPath(Graph graph)
    {
        var distances = ComputeShortestDistances(graph);
        if (distances[graph.EndNode] == int.MaxValue)
            return new List<int>(); // No path exists

        var path = new List<int>();
        var currentNode = graph.EndNode;

        while (currentNode != graph.StartNode)
        {
            path.Add(currentNode);
            currentNode = graph.Connections
                .Where(c => c.IdNodeA == currentNode || c.IdNodeB == currentNode)
                .Select(c => (c.IdNodeA == currentNode ? c.IdNodeB : c.IdNodeA, c.Weight))
                .Where(n => distances[n.Item1] + n.Weight == distances[currentNode])
                .Select(n => n.Item1)
                .FirstOrDefault();

            if (currentNode == 0)
                return new List<int>(); // No valid path
        }

        path.Add(graph.StartNode);
        path.Reverse();
        return path;
    }
}
