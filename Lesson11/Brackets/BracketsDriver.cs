namespace Brackets;

public class BracketsDriver
{
    public static void Main(string[] args)
    {
        MatchingBrackets pc = new MatchingBrackets();
        
        string? expression = "";
        do{
            Console.WriteLine("Enter an expression with { [ ( ) ] }: ('q' to stop)");
            expression = Console.ReadLine();
            if(!expression.Equals("q".ToLower())){
                bool b = pc.CheckBrackets(expression);
                Console.WriteLine(expression + " has balanced brackets: " + b);
            }
        }while (!expression.Equals("q".ToLower()));
        
    }
}