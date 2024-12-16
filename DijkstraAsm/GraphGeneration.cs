using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAsm;

public class GraphGeneration
{
    public static void GenerateGraphFile(int numberOfNodes, int maxConnections, int weightMax, string filePath)
    {
        Random rand = new Random();
        StringBuilder fileContent = new StringBuilder();

        int startNode = rand.Next(1, numberOfNodes + 1);
        int endNode;
        do
        {
            endNode = rand.Next(1, numberOfNodes + 1);
        } while (endNode == startNode);

        fileContent.AppendLine(startNode.ToString());
        fileContent.AppendLine(endNode.ToString());

        HashSet<string> connections = new HashSet<string>();

        int nodeForStartNode;
        do
        {
            nodeForStartNode = rand.Next(1, numberOfNodes + 1);
        } while (nodeForStartNode == startNode);

        int weightStart = rand.Next(1, weightMax + 1);
        connections.Add($"{startNode} - {nodeForStartNode} : {weightStart}");

        int nodeForEndNode;
        do
        {
            nodeForEndNode = rand.Next(1, numberOfNodes + 1);
        } while (nodeForEndNode == endNode || nodeForEndNode == nodeForStartNode);

        int weightEnd = rand.Next(1, weightMax + 1);
        connections.Add($"{endNode} - {nodeForEndNode} : {weightEnd}");

        while (connections.Count < maxConnections)
        {
            int node1 = rand.Next(1, numberOfNodes + 1);
            int node2;
            do
            {
                node2 = rand.Next(1, numberOfNodes + 1);
            } while (node2 == node1);

            int weight = rand.Next(1, weightMax + 1);
            connections.Add($"{node1} - {node2} : {weight}");
        }

        foreach (var connection in connections)
        {
            fileContent.AppendLine(connection);
        }

        File.WriteAllText(filePath, fileContent.ToString());
    }
}