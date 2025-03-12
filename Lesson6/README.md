# Threads
## Task A
Create a task class called `RunnableTask.cs`.
- Declare two variables and apply proper encapsulation:
  - `sum(int)`
  - `threadName(string)`
- Create a one argument constructor: `public RunnableTask(string threadName)`
  - Initialize the variable `sum = 0`.
  - Initialize a variable `threadName` using the `string` passed as an argument.
- Implement a method that does as follows:
  - Create a for loop that executes 10 times.
  - Add the value of the current iteration, to `sum` in each iteration.
  - Print the `threadName`, and the value *(current value of sum)* such that it looks as follows for the first three iterations of the loop:
    - `Thread: A - Current Value: 0`
    - `Thread: A - Current Value: 1`
    - `Thread: A - Current Value: 3`
  - Finally, after the loop is finished, print the sum from each thread such that it looks as follows: 
    - `Thread: A - Sum: 45`
- Implement a `Run()` method which creates a new thread and calls the method you just created, and finally starting the thread.

***Hint:***
```csharp
public void Run() 
{
    Thread newThread = new Thread(**YOUR METHOD**);
    newThread.Start(); 
}
```

Add the following to the `Main()` method in `ThreadDemo.cs`
- Create three `RunnableTask` objects. Pass the name of the thread as an argument (Use names A, B, C for each task).
- Start/execute the threads by calling `Run()`.
- Examine output: The **last line** for each of the threads should be:
  - `Thread: A - Sum: 45`
  - `Thread: B - Sum: 45`
  - `Thread: C - Sum: 45`

Remember, the order of Thread A, B and C could be different, but the sum for these threads should be **45**.

## Task b

Create a class `Counter.cs`.
- Declare a variable `Count` of type `int`. (remember to apply proper encapsulation)
- Create a Constructor to initialize the variable counter, to be `Count=0;`
- Create a getter for retrieving the value of counter. The method should return the value of the counter.
- Implement an `IncrementCounter()` method with the signature `public void IncrementCounter()`. The method should increment the value of counter by **2**.
- Implement an `DecrementCounter()` method with the signature `public void DecrementCounter()`. The method should decrement the value of counter by **1**.



Create a new class, `Task1.cs`.

- Declare a variable `cr` of type Counter
- Create a 1 argument constructor to initialize the variable `cr`.
- Implement a method `DoIncrement` that invokes the `IncrementCounter()` method 10 times.
- Implement the `Run()` method which creates a new thread and calls the `DoIncrement`-method, and then starts the thread.

***Hint:*** 
```csharp
public void Run() 
{
    Thread newThread = new Thread(DoIncrement);
    newThread.Start(); 
}
```


Create a new class, `Task2.cs`.

- Declare a variable `cr` of type Counter
- Create a 1 argument constructor to initialize the variable `cr`.
- Implement a method `DoDecrement` that invokes the `DecrementCounter()` method 10 times.
- Implement the `Run()` method which creates a new thread and calls the `DoDecrement`-method, and then starts the thread.



Add the following to the `Main()` method in `ThreadDemo.cs`

- Create an object of class `Counter`
- Write the following statement: `Thread.Sleep(1000);`
- Print the value of the counter by using the getter for `count` from the `Counter` class:

  - ```csharp
    Console.WriteLine("The value of counter before running threads is: " + counter.Count);
    ```

- Create an object of class `Task1` (thread class). Pass the `Counter` object as an argument

- Create an object of class `Task2` (thread class). Pass the `Counter` object as an argument

- Start/execute both threads.

- Write the following statement: `Thread.Sleep(1000);`

- Print the value of counter again by using the getter for `count` from the `Counter` class.

  - ```csharp
    Console.WriteLine("The value of counter after running threads is: " + counter.Count);
    ```

- The output should look as follows:

```
The value of counter before running threads is: 0
The value of counter after running threads is: 10
```

