namespace CamelWriterExercise;

public class CamelWriter
{
    private StreamReader inFile;

    public CamelWriter(string fName)
    {
        //Initialize inFile with fName
    }

    public void ReadLines()
    {
        // Use a StreamReader to read inFile one line at a time
        // Call convert2camel method for each line.
        throw new NotSupportedException("Implement this method"); 
    }

    private void Convert2Camel(string line)
    {
        // Split line into a String[] of the individual words in the line using split()
        // Convert the 1st word to lowercase and the first letter of the remaining words to uppercase.
        // Combine the words into one long word.
        // Print the line on console
        // Call PrintToFile method for each line
        throw new NotSupportedException("Implement this method"); 
    }
    
    private void PrintToFile(string line)
    {
        // Use a StreamWriter to write line in "CamelOut.txt"
        throw new NotSupportedException("Implement this method"); 
    }
}