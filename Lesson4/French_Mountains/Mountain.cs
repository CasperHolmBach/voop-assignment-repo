namespace French_Mountains;

public class Mountain : IComparable<Mountain>
{
    private string name;
    private int height;
    private int prominence;
    private string latitude;
    private string longitude;
    
    public Mountain(string name, int height, int prominence, string latitude, string longitude, string range)
    {
        this.name = name;
        this.height = height;
        this.prominence = prominence;
        this.latitude = latitude;
        this.longitude = longitude;
        Range = range;
    }
    
    public string Range { get; private set; }
    
    public int GetHeight()
    {
        return height;
    }
    
    public int GetProminence()
    {
        return prominence;
    }
    
    public override string ToString()
    {
        return $"Name: {name} " +
               $"Height: {height} " +
               $"Prominence: {prominence} " +
               $"Latitude: {latitude} " +
               $"Longitude: {longitude} " +
               $"Range: {Range} ";
    }

    public int CompareTo(Mountain? o)
    {
        if (GetProminence() < o.GetProminence())
        {
            return -1;
        }

        if (GetProminence() > o.GetProminence())
        {
            return 1;
        }
        
        else
        {
            if (GetHeight() < o.GetHeight())
            {
                return -1;
            }
            
            if (GetHeight() > o.GetHeight())
            {
                return 1;
            }
            
            else
            {
                return 0;
            }
        }
    }
}