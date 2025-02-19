// See https://aka.ms/new-console-template for more information

using DanishIslandSolution;

DanishIslandFileReader fr = new DanishIslandFileReader("Islands punktum.txt");
//DanishIslandFileReader fr = new DanishIslandFileReader("Islands komma.txt");
fr.ReadFile();

Console.WriteLine("Result:\n" + string.Join("\n", fr.GetList()));