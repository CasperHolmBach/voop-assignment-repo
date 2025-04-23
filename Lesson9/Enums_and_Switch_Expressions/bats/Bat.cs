namespace Enums_and_Switch_Expressions.bats;

public class Bat
{
    public string Name{ get; }
    public string FeedingGroups{ get; }
    public string PopulationStatus { get; }
    
    public Bat(string name, string populationStatus, string feedingGroups) {
        Name = name;
        PopulationStatus = populationStatus;
        FeedingGroups = feedingGroups;
    }

    public override string ToString() {
        return Name;
    }

}