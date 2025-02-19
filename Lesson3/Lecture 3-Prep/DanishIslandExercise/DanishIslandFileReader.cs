namespace DanishIslandExercise;

using System;
using System.Collections.Generic;
using System.IO;

public class DanishIslandFileReader
{
    private StreamReader inFile;
    private List<DanishIsland> islandList;

    public DanishIslandFileReader(string fName)
    {
        inFile = new StreamReader(fName);
    }

    public void ReadFile()
    {
        
        islandList = new List<DanishIsland>();
       
        string line;
        string[] tokens;

        string name = "";
        double circ;
        double area;
        int addr;
        int adkm;
        
        // TASK:
        // Read the file one line at a time. Split the line at the space character.
        // Convert the individual values to the types that should be used in DanishIsland.
        // Create an object for each line and add it to the list.
        // Be careful to catch exceptions and close the stream.

       
    }

    public List<DanishIsland> GetList()
    {
        return islandList;
    }
    
}