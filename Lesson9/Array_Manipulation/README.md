# Array Manipulation and Recursion
As you implement the different tasks, you can test your implementation by uncommenting the code in `ArrayManipulationDriver`.
## Recursion
The purpose of the class `FindFilesRecursive.cs` is to recursively iterate through  a given directory, and its subdirectories.
- Implement the method `FindFiles(string path)` in a way, so that it increments the variable `_numFiles`, 
for every "atomic" file (atomic meaning it has no sub-files), and simultaneously writes the full file path 
in the console, for each file incremented.
  - If the method encounters a directory, it should instead increment the variable `_numDirs` and make a recursive call 
(meaning `FilesInDirs` should be called in the method).

***Hint:*** 
  - You can use `Directory.GetDirectories(path)` to get all directories of a path.
  - You can use ` Directory.GetFiles(path)` to get all files of a path.

## Manipulation of arrays
Within the `ArrayManipulation.cs`-class you will find the methods `OddEven()` and `Sort()`.
The method `OddEven()` should take an array of random numbers (between 0 - 100) as input.
### Task A
The numbers must be arranged so that all odd numbers precede all even numbers. Write a method using the method signature
    `public int[] OddEven(int[] array)`, which rearranges all the numbers in the array. For example:
  
`Input: [70, 95, 94, 94, 43, 56, 37, 81, 44, 13]`
  
`Output: [95, 43, 37, 81, 13, 44, 56, 94, 94, 70]`
    
    Hint: You might want somewhere to temperarily store your numbers, while you are sorting them

### Task B
For this task you are going to be implementing the method signature `private void Sort(int[] array, int splitIndex)`.
The point of the method is to sort the input array, in a manner so that it arranges the numbers of the within the array in ascending order.

The `int splitIndex` is supposed to denote where in the array, the sorting must start over from lowest to highest, in case you might have more than one type of numbers to be sorted.
We now want to call this method from within the `OddEven()`-method, as we want the two parts of the array to be sorted like they are underneath:

`Input: [70, 95, 94, 94, 43, 56, 37, 81, 44, 13]`

`OddEven: [95, 43, 37, 81, 13, 44, 56, 94, 94, 70]`
   
`Output: [13, 37, 43, 81, 95, 94, 94, 70, 56, 44]`


In the example above the `int splitIndex` is set to 5, in the context of a 5 number array.

    Hint: You might want to check out the Array.Sort() method for this
        Bonus Hint: When sorting the second half of the array, pay attention to the "length" you pass as the parameter.