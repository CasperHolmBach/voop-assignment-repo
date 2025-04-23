namespace Array_Manipulation;

public class FindFilesRecursive
{
    private int _numDirs;
    private int _numFiles;

    // Exercise: If a file is a directory: Call all files recursively,
    // else print full path to the file. Count both dirs and atomic files.
    private void FindFiles(string path) 
    {
        if (Directory.Exists(path))
        {
            _numDirs++;
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                _numFiles++;
            }
            
            string[] dirs = Directory.GetDirectories(path);
            foreach (var dir in dirs)
            {
                FindFiles(dir);
            }
        }
        
        Console.WriteLine("No files found");
    }
    
    public override string ToString() {
        return "FindFilesRecursive{" + "noDirs=" + _numDirs + ", noFiles=" + _numFiles + '}';
    }

    public static void FindFilesRecursively(){
        // Prompt the user to enter a directory or a file
        Console.WriteLine("Enter a directory or a file: ");
        string directory = Console.ReadLine();
        
        FindFilesRecursive ffr = new FindFilesRecursive();

        ffr.FindFiles(directory);
        Console.WriteLine("\n*************\n" + ffr);
    }
}