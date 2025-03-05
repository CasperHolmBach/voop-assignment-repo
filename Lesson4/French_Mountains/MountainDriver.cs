namespace French_Mountains;

public class MountainDriver
{
    public static void Main(string[] args)
    {
        MountainSet mountainSet = new MountainSet();
        
        mountainSet.LoadMountains();
        mountainSet.PrintMountains();
        
        Console.WriteLine("\n ---------------------- \n");
        
        MountainComparer mountainComparer = new MountainComparer();
        ISet<Mountain> sortedSet = mountainSet.SortByRange(mountainComparer);
        Console.WriteLine("[" + string.Join("\n, ", sortedSet ) + "]");
    }
}