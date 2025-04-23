namespace Enums_and_Switch_Expressions.bats;

public class BatWithEnum
{
    public string Name{ get; }
    public FeedingGroups FeedingGroups{ get; }
    public PopulationStatus PopulationStatus { get; }
    
    public BatWithEnum(string name, PopulationStatus populationStatus, FeedingGroups feedingGroups) {
        Name = name;
        PopulationStatus = populationStatus;
        FeedingGroups = feedingGroups;
    }

    public override string ToString() {
        return Name;
    }
}