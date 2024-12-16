using System.Text.RegularExpressions;

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
            try
            {   
                StartNode = int.Parse(reader.ReadLine());
                EndNode = int.Parse(reader.ReadLine());
            }
            catch {}

            Regex regex = new Regex(@"");
        };
    }
}
