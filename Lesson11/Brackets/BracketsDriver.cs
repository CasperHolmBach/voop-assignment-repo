namespace Brackets;

public class BracketsDriver
{
    public static void Main(string[] args)
    {
        MatchingBracketsList pc = new MatchingBracketsList();
        
        string? expression = "";
        do{
            Console.WriteLine("Enter an expression with { [ ( ) ] }: ('q' to stop)");
            expression = Console.ReadLine();
            if(!expression.Equals("q".ToLower())){
                bool b = pc.CheckBracketsList(expression);
                Console.WriteLine(expression + " has balanced brackets: " + b);
            }
        }while (!expression.Equals("q".ToLower()));
        
    }
}