namespace DanishIslandSolution;

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

            try
            {
                using (inFile) // I will explain this in the lecture :-)
                {
                    string line;
                    while ((line = inFile.ReadLine()) != null)

                    {
                            string[] tokens = line.Split(' ');
                            string name = tokens[0];
                            double circ = double.Parse(tokens[1]);
                            double area = double.Parse(tokens[2]);
                            int addr = int.Parse(tokens[3]);
                            int adkm = int.Parse(tokens[4]);
                            islandList.Add(new DanishIsland(name, circ, area, addr, adkm));
                        
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (FormatException ne)
            {
                Console.WriteLine("NumberFormatException in " + "\n" + ne.Message);
            }
        }

        public List<DanishIsland> GetList()
        {
            return islandList;
        }
}