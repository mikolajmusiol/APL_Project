using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAsm;

// Implements Dijkstra's algorithm for finding the shortest path in a graph
public static class Algorithm
{
    // Computes the shortest distances from the start node to all other nodes
    public static Dictionary<int, int> ComputeShortestDistances(Graph graph)
    {
        var distances = new Dictionary<int, int>(); // Stores shortest known distances
        var visited = new HashSet<int>(); // Tracks visited nodes
        var nodes = graph.Connections.SelectMany(c => new[] { c.IdNodeA, c.IdNodeB }).Distinct().ToList();

        // Initialize distances to infinity, except for the start node
        foreach (var node in nodes)
        {
            distances[node] = int.MaxValue;
        }
        distances[graph.StartNode] = 0;

        // Process nodes until all are visited
        while (visited.Count < nodes.Count)
        {
            // Select the unvisited node with the smallest distance
            var currentNode = nodes
                .Where(n => !visited.Contains(n))
                .OrderBy(n => distances[n])
                .FirstOrDefault();

            // If the smallest distance is still infinity, stop (no more reachable nodes)
            if (distances[currentNode] == int.MaxValue)
                break;

            visited.Add(currentNode);

            // Get neighboring nodes and update their distances
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

    // Retrieves the shortest path from the start node to the end node
    public static List<int> GetShortestPath(Graph graph)
    {
        var distances = ComputeShortestDistances(graph);
        if (distances[graph.EndNode] == int.MaxValue)
            return new List<int>(); // No path found

        var path = new List<int>();
        var currentNode = graph.EndNode;

        // Backtrack from the end node to reconstruct the path
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
                return new List<int>(); // No valid path

            currentNode = nextNode.Value;
        }

        path.Add(graph.StartNode);
        path.Reverse(); // Reverse to get path from start to end
        return path;
    }

    // Returns the length of the shortest path from start to end node
    public static int GetShortestPathLength(Graph graph)
    {
        var distances = ComputeShortestDistances(graph);
        return distances.ContainsKey(graph.EndNode) ? distances[graph.EndNode] : int.MaxValue;
    }
}
