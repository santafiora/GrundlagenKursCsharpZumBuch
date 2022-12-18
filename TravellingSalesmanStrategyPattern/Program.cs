/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingSalesmanStrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
*/

using System;

//Klassen um Strategien zu implementieren
public abstract class TravellingSalesman
{
    public abstract int[] Travel(int[][] distances, int startVertex);
}

public class BruteForce : TravellingSalesman
{
    //Brute Force Implementierung
    public override int[] Travel(int[][] distances, int startVertex)
    {
        int[] path = GeneratePath(distances.Length, startVertex);
        int minDist = int.MaxValue;

        for (int i = 0; i < path.Length - 1; i++)
        {
            int tempDist = CalcDist(path, distances);
            if (tempDist < minDist)
                minDist = tempDist;

            Permute(path);
        }

        return path;
    }

    //Erstelle eine Route
    private static int[] GeneratePath(int size, int startVertex)
    {
        int[] path = new int[size - 1];

        for (int i = 0, j = 0; i < size; i++)
        {
            if (i != startVertex)
                path[j++] = i;
        }

        return path;
    }

    //Berechnete die Tourenlänge
    private static int CalcDist(int[] path, int[][] distances)
    {
        int sum = 0;
        for (int i = 0; i < path.Length - 1; i++)
        {
            sum += distances[path[i]][path[i + 1]];
        }
        return sum;
    }

    //permutiere den Pfad
    private static void Permute(int[] path)
    {
        int i = path.Length - 2;

        while (i > 0 && path[i] > path[i + 1])
            i--;

        if (i == 0) return;

        int j = path.Length - 1;

        while (path[i] > path[j])
            j--;

        Swap(ref path[i], ref path[j]);

        int p = i + 1;
        int q = path.Length - 1;

        ReverseArr(p, q, path);
    }

    //Tauscht zwei int Werte
    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    //Dreht ein Array um
    private static void ReverseArr(int p, int q, int[] arr)
    {
        while (q > p)
        {
            Swap(ref arr[p], ref arr[q]);
            p++;
            q--;
        }
    }
}

public class Greedy : TravellingSalesman
{
    //Greedy Implementierung
    public override int[] Travel(int[][] distances, int startVertex)
    {
        if (startVertex < 0 || startVertex > distances.Length - 1)
            throw new Exception("Start Vertex außerhalb des Range!");

        int[] path = new int[distances.Length - 1];
        int currentVertex = startVertex;
        int pathCounter = 0;
        int minDist = int.MaxValue;
        int minDistVertex = 0;

        //Entferne den Startpunkt, sodass kein Kreisdurchlauf auf demselben erfolgt
        bool[] visited = new bool[distances.Length];
        visited[currentVertex] = true;

        while (pathCounter < path.Length)
        {
            //Initialisiere auf maxint
            minDist = int.MaxValue;

            //Finde den am nächsten gelegenen knoten zum aktuellen, welchen man besuchen kann
            for (int i = 0; i < distances.Length; i++)
            {
                if (i != currentVertex && !visited[i] && distances[currentVertex][i] < minDist)
                {
                    minDist = distances[currentVertex][i];
                    minDistVertex = i;
                }
            }

            visited[minDistVertex] = true;
            path[pathCounter] = minDistVertex;
            pathCounter++;
            currentVertex = minDistVertex;
        }
        return path;
    }
}

public class StrategyContext
{
    private TravellingSalesman _travelStrategy;

    public StrategyContext(TravellingSalesman travelStrategy)
    {
        _travelStrategy = travelStrategy;
    }

    public int[] Travel(int[][] distances, int startVertex)
    {
        return _travelStrategy.Travel(distances, startVertex);
    }
}

class Program
{
    static void Main(string[] args)
    {
        int startVertex = 0;
        //Abstands Matrix
        int[][] distances = new int[][]
        {
      new int[] { 0, 1, 6, 4 },
      new int[] { 1, 0, 3, 8 },
      new int[] { 6, 3, 0, 7 },
      new int[] { 4, 8, 7, 0 }
        };

        StrategyContext context = new StrategyContext(new BruteForce());

        int[] pathBruteForce = context.Travel(distances, startVertex);
        Console.Write("Brute Force: ");
        foreach (int vertex in pathBruteForce)
        {
            Console.Write("{0} ", vertex);
        }
        Console.WriteLine("\n");

        context = new StrategyContext(new Greedy());

        int[] pathGreedy = context.Travel(distances, startVertex);
        Console.Write("Greedy: ");
        foreach (int vertex in pathGreedy)
        {
            Console.Write("{0} ", vertex);
        }
        Console.WriteLine();

        Console.ReadKey();
    }
}