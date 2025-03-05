namespace French_Mountains;

public class MountainDriver
{
    public static void Main(string[] args)
    {
        MountainSet mountainSet = new MountainSet();
        
        mountainSet.LoadMountains();
        mountainSet.PrintMountains();
    }
}