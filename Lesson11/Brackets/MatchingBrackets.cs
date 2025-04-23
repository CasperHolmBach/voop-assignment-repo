namespace Brackets;

public class MatchingBrackets
{
    private Dictionary<char, char> brackets = new Dictionary<char, char>()
    {
        { ')' , '(' },
        { ']' , '[' },
        { '}' , '{' }
    };
    
    public bool CheckBrackets(string? expression)
    {
        Stack<char> bracketStack = new ();
        
        foreach (var c in expression)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                bracketStack.Push(c);
            }

            if (c == ')' || c == '}' || c == ']')
            {
                if (bracketStack.Count == 0)
                    return false;
                
                if (bracketStack.Peek() == brackets[c])
                {
                    bracketStack.Pop();
                }
            }
        }
        
        if (bracketStack.Count == 0)
            return true;
        
        return false;
    }
}