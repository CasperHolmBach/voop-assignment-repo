namespace Array_Manipulation;

public class ArrayManipulation
{
    public int[] OddEven(int[] array)
    {
        int[] result = new int[array.Length];
        
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] % 2 != 0)
                {
                    result[j] = array[j];
                }
            }
            
            result[i] = array[i];
        }
        
        return result;
    }

    private void Sort(int[] array, int splitIndex)
    {
        
    }
    
    public static void DoArrayManipulation(){
        Random generator = new Random(222);
        int[] array = new int [10];
        for(int i = 0; i < array.Length; i++){
            array[i] = generator.Next(100);
        }
        Console.WriteLine("Input:  " + string.Join(", ", array));

        ArrayManipulation arrMani = new ArrayManipulation();
        int[] result = arrMani.OddEven(array);
        Console.WriteLine("Output:  " + string.Join(", ", result));
    }
}