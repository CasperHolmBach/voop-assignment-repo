q# Danish Island Exercise

**Provided Files:**

* `Islands komma.txt`
* `Islands punktum.txt`
* `DanishIslandExercise.DanishIsland.cs`
* `DanishIslandExercise.DanishIslandFileReader.cs`: Code skeleton that can be used as a starting point
* `Program.cs` is also provided. Please take a look. You pass the name of the file from here.

**Description**

These files contain information about Danish inhabited islands. The information in the files is the same, except for the decimal separator (comma or period).

Each line in the files represents one island with the following data (separated by spaces):

`Navn Omkreds Areal Addresser Adr/km2`

The data types for each field are: (`string`, `double`, `double`, `int`, `int`).

**DanishIslandExercise**

The `DanishIslandExercise` project contains the following classes:

* `DanishIsland`: This class represents a single island. The code is fully implemented. Please take a look.
* `DanishIslandFileReader`: This class is a code skeleton for reading the island data from the text files. You need to implement the missing functionality:

    * Load the file one line at a time.
    * Split the line at the space character.
    * Convert the individual values to their correct data types.
    * Create a `DanishIsland` object for each line and add it to a list.
    * Handle exceptions and close the stream properly.
    * In the `main()` method, you can choose which file to read ("Islands komma.txt" or "Islands punktum.txt") based on the decimal separator used in the file.

**Hints**

* Use a `StreamReader` to read the file.
* Use the `split()` method to split the line into an array of strings.
* Use `double.Parse()` and `int.Parse()` to convert strings to `double` and `int` respectively.
* Use a `List<DanishIsland>` to store the island objects.
* Use `try-catch` blocks to handle `FileNotFoundException` and `FormatException`.

