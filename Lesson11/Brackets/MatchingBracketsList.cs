namespace Brackets;

public class MatchingBracketsList
{
    private Dictionary<char, char> brackets = new Dictionary<char, char>()
    {
        { ')' , '(' },
        { ']' , '[' },
        { '}' , '{' }
    };

    public bool CheckBracketsList(string? expression)
    {
        List<char> bracketsList = new List<char>();

        foreach (char c in expression)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                bracketsList.Add(c);
            }

            if (c == ')' || c == ']' || c == '}')
            {
                if (bracketsList[bracketsList.Count - 1] != brackets[c])
                {
                    return false;
                }
                
                bracketsList.RemoveAt(bracketsList.Count - 1);
            }
        }

        if (bracketsList.Count == 0)
            return true;
        
        return false;
    }
}