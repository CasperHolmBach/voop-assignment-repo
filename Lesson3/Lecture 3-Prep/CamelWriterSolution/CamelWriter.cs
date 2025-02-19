namespace CamelWriterSolution;

public class CamelWriter
{
    private StreamReader inFile;

    public CamelWriter(string fName)
    {
        inFile = new StreamReader(fName);
    }

    public void ReadLines()
    {
        string line;
        using (inFile) // I will explain this in the lecture :-)
        {
            while ((line = inFile.ReadLine()) != null)
            {
                Convert2Camel(line);
            }
        }
    }

    private void Convert2Camel(string line)
    {
        string[] words = line.Split(' ');
        string camelLine = words[0].ToLower(); 

        for (int i = 1; i < words.Length; i++)
        {
            camelLine += words[i].Substring(0,1).ToUpper()+ words[i].Substring(1);
            
        }

        Console.WriteLine(camelLine);
        PrintToFile(camelLine);
    }

    private void PrintToFile(string line)
    {
        string relativePath = @"..\..\..\CamelOut.txt";
        string targetPath = Path.GetFullPath(relativePath);
        StreamWriter fw=null;

        try
        {
            fw = new StreamWriter(targetPath, true);
            fw.WriteLine(line);

        }
        catch (IOException e)
        {
            Console.WriteLine(e.ToString());
        }
        finally
        {
            fw.Close();
        }
    }
}