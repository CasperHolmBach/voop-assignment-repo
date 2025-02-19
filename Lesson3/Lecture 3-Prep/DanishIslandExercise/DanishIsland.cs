using System.Text;

namespace DanishIslandExercise;

public class DanishIsland
{
    private string name;
    private double circumference;
    private double area;
    private int addresses;
    private int addrPerKm2;

    public DanishIsland(string name, double circumference, double area, int addresses, int addrPerKm2)
    {
        this.name = name;
        this.circumference = circumference;
        this.area = area;
        this.addresses = addresses;
        this.addrPerKm2 = addrPerKm2;
    }

    public string getName()
    {
        return name;
    }

    public double getCircumference()
    {
        return circumference;
    }

    public double getArea()
    {
        return area;
    }

    public int getAddresses()
    {
        return addresses;
    }

    public int getAddrPerKm2()
    {
        return addrPerKm2;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append(name);
        builder.Append("\t");
        builder.Append(circumference);
        builder.Append("\t");
        builder.Append(area);
        builder.Append("\t");
        builder.Append(addresses);
        builder.Append("\t");
        builder.Append(addrPerKm2);
        builder.Append("\n");
        return builder.ToString();
    }
}