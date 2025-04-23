# Enums and Switch Expressions

This task is created to make you a bit more comfortable using enums and introduce you to switch expressions.

You may already have used the `switch` statement. But C# also allows you to use it as an expression, neat! 

For instance, let's say we want to map a creature's type, ordinarily we would do something like this:
```csharp
string creature = "person";
string type = "";
switch (creature)
{
    case "person":
        type = "humanoid";
        break;
    case "chihuahua":
    case "bulldog":
        type = "canine";
        break;
    case "sword fish":
        type = "fish";
        break;
    default:
        throw new Exception("Invalid creature");
}
```

Using switch expressions we can rewrite it:

```csharp
public static string ToType(string creature) => creature switch 
{
    "person"    => "humanoid",
    "chihuahua"    => "canine",
    "sword fish"    => "fish",
    _ => throw new Exception("Invalid creature")
};

// Call the method
string type = ToType("person");
```

Check out the documentation for more information: [Switch-Expressions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/switch-expression)
## The task

In this task we'll be working with Bats. `Bats.All()` provides a list of bats with the following attributes:

- `Name : string` - name of the bat
- `PopulationStatus : string` - The status of its population:
  - Increasing
  - Declining
  - Stable
  - Unknown
- `FeedingGroups : string` - What food the bat eats:
  - Frugivore,
  - Insectivore,
  - Omnivore,
  - Sanguivore,
  - Nectarivore,
  - Carnivore

However, there is a problem; for some reason the original developer thought it would be a good idea 
to save `PopulationStatus` and `FeedingGroups` as strings 😮.

As such, you are tasked with converting each bat in the list to an instance
of `BatWithEnum` where the `PopulationStatus` and `FeedingGroups` attributes,
have been switched out with appropriate enums.

### Task 1 - BatStatistics - Convert

The `Convert` method needs to be implemented. 
- Create a new `List<BatWithEnum>` local variable that can hold the new `BatWithEnum` instances you will be creating.
- Iterate over the parameter/list `bats` (the parameter referenced gets instantiated in the main method) and 
create a new instance of `BatWithEnum` for each of them
  - When creating a new `BatWithEnum` instance:
    - Create and call a method that uses a switch expression to set the `PopulationStatus` constructor parameter depending on 
    which of the ENUMs correlate to the `PopulationStatus` of the current bat's object.
    - For the default case THROW an `InvalidPopulationStatusException` that is propagated 
    to the calling method (Do not handle the exception within the `Convert` method).
    - Create and call another method that uses `Enum.TryParse(..)` to set the `FeedingGroups` constructor parameter
- Return the list from the method

If implemented correctly, you should be able to run the `Main` method of the `BatStatistics`-class without getting any errors.

### Task 2 - BatStatistics - GetPopulationStatusDictionary

Now that we have converted our `List<Bat>` to `List<BatWithEnum>`, we need to map them, 
such that it's easier to look up bats with a given `PopulationStatus` and `FeedingGroups`.

This will allow us to retrieve bats that are `Insectivore` and get a complete list of bats that fall under that category for example.

Implement `GetPopulationStatusDictionary`:
- Create a local instance of  `Dictionary<PopulationStatus, List<BatWithEnum>>` that holds the bats.
- Iterate over the list of bats in the `bats` parameter.
- For each bat, find the list of bats of the same type 
(**hint**: you can use `TryGetValue(bat.PopulationStatus, out List<BatWithEnum> list)` on the dictionary)
  - The returned value from `TryGetValue` is going to be false during the first iteration 
    of each type, as the list doesn't exist within the dictionary. If that's the case you should create a new `List` for 
    the bat Type and add the bat to the list.
  - Add the `BatWithEnum` instance to the List
  - Continue until you have mapped all bats
  - return the map

***Hint***:
```csharp
list = new List<BatWithEnum>();
list.Add(bat);
mappedBats.Add(bat.PopulationStatus, list);
```
### Task 3 - BatStatistics - GetFeedingGroupsDictionary
The procedure for `GetFeedingGroupsDictionary` is the same as `GetPopulationStatusDictionary`, except for the
fact that you will be using different enums.

Implement `GetFeedingGroupsDictionary`:
- Create a local instance of  `Dictionary<FeedingGroups, List<BatWithEnum>>` that holds the bats.
- Iterate over the list of bats in the `bats` parameter.
- For each bat, find the list of bats of the same type
  (**hint**: you can use `TryGetValue(bat.FeedingGroups, out List<BatWithEnum> list)` on the dictionary)
  - The returned value from `TryGetValue` is going to be false during the first iteration
    of each type, as the list doesn't exist within the dictionary. If that's the case you should create a new `List` for
    the bat Type and add the bat to the list.
  - Add the `BatWithEnum` instance to the List
  - Continue until you have mapped all bats
  - return the map

***Hint***:
```csharp
list = new List<BatWithEnum>();
list.Add(bat);
mappedBats.Add(bat.FeedingGroups, list);
```

### Task 4 - Testing your implementation
To test your implementation uncomment the remaining part of the `Main` method and run it.

If done correctly, you should get an output that starts like this:
```
The following bats are carnivorous:
 - Lyroderma lyra
 - Megaderma spasma
 - Mimon bennettii
 - Noctilio albiventris
 - Noctilio leporinus
 - Vampyrumspectrum

The following bats are increasing in population:
 - Chaerephon atsinanana
 - Corynorhinus rafinesquii
 - Cynnopterus sphinx
 - Mormopterus francoismoutoui
 - Myotis daubentonii
 - Myotis grisescens
...
```