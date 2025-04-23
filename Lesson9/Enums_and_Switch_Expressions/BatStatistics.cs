using Enums_and_Switch_Expressions.bats;

namespace Enums_and_Switch_Expressions;

public class BatStatistics
{
    public static List<BatWithEnum> Convert(List<Bat> bats) {
        throw new NotImplementedException("Not implemented yet!");
    }
    
    public static Dictionary<PopulationStatus, List<BatWithEnum>> GetPopulationStatusDictionary(List<BatWithEnum> bats)
    {
        throw new NotImplementedException("Not implemented yet!");
    }

    public static Dictionary<FeedingGroups, List<BatWithEnum>> GetFeedingGroupsDictionary(List<BatWithEnum> bats)
    {
        throw new NotImplementedException("Not implemented yet!");
    }
    
    public static void Main(string[] args)
    {
        try
        {
            List<Bat> bats = Bats.All();
            List<BatWithEnum> convertedBats = Convert(bats);
            
            // Console.Write("The following bats are carnivorous:"+ "\n - ");
            // var feedingGroupsDic = GetFeedingGroupsDictionary(convertedBats);
            // if (feedingGroupsDic.TryGetValue(FeedingGroups.Carnivore, out List<BatWithEnum> feedingGroupBats))
            // {
            //     Console.Write(string.Join("\n - ", feedingGroupBats) + "\n");
            // }
            //
            //
            // Console.Write("\nThe following bats are increasing in population:" + "\n - ");
            // var populationStatusDic = GetPopulationStatusDictionary(convertedBats);
            // if (populationStatusDic.TryGetValue(PopulationStatus.Increasing, out List<BatWithEnum> populationStatusBats))
            // {
            //     Console.Write(string.Join("\n - ", populationStatusBats));
            // }

        } catch (InvalidPopulationStatusException e) {
            Console.WriteLine(e);
        }
    }
}