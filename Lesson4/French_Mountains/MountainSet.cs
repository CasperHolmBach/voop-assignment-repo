using System.Reflection;

namespace French_Mountains;

public class MountainSet
{
    public ISet<Mountain> set;
    
    public MountainSet()
    {
        set = new SortedSet<Mountain>();
    }
    
    public void LoadMountains()
    {
        string fileName = "FrenchMountains.csv";
        using (StreamReader streamReader = new StreamReader(fileName))
        {
            while(!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                string[] lineArray = line.Split(";");

                string name = lineArray[0];
                int height = int.Parse(lineArray[1]);
                int prominence = int.Parse(lineArray[2]);
                string latitude = lineArray[3];
                string longitude = lineArray[4];
                string range = lineArray[5];
                
                Mountain mountain = new Mountain(name, height, prominence, latitude, longitude, range);
                set.Add(mountain);
            }
        }
    }
    
    public void PrintMountains()
    { 
        Console.WriteLine("[" + string.Join("\n, ", set) + "]");
    }

    public ISet<Mountain> SortByRange(IComparer<Mountain> comparer)
    {
        ISet<Mountain> rangeSet = new SortedSet<Mountain>(set, comparer);
        return rangeSet;
    }
}