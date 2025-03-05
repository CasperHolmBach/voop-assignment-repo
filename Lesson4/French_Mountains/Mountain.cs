namespace French_Mountains;

public class Mountain : IComparable<Mountain>
{
    public string name;
    public int height;
    public int prominence;
    public string latitude;
    public string longitude;
    public string range;
    
    public Mountain(string name, int height, int prominence, string latitude, string longitude, string range)
    {
        this.name = name;
        this.height = height;
        this.prominence = prominence;
        this.latitude = latitude;
        this.longitude = longitude;
        this.range = range;
    }

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
        return $"Name: {name} \n" +
               $"Height: {height} \n" +
               $"Prominence: {prominence} \n" +
               $"Latitude: {latitude} \n" +
               $"Longitude: {longitude} \n" +
               $"Range: {range}";
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