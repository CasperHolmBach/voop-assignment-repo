# Circular Buffer
Instead of the class `Q`, you must implement a `CircularBuffer`. 
The code for `Producer`, `Consumer` and `PcFixed` have been provided in this exercise. 
Study the code and complete the following tasks:

Open the `CircularBuffer.cs` and implement the following:
### Task 1 - Implementation of CircularBuffer.cs - Put(int n)
Implement the `Put(int n)` method as follows: 

- The `Producers` try to put in values starting at `index = 0`. A value can only be inserted if the place is empty (null). 
Else it should wait for a `Consumer` to empty the place.
  - ***Hint:*** `Monitor.Wait(buffer)` can be used to wait

- The value it should put in, should be the argument passed through in the method.

- When a `Producer` has inserted a value on the last place, it should start over and try to insert the next value on `index = 0`.

   - ***Hint:*** *Compute circular index using modulo*

- Notify the other threads, when the producer is done with putting value in the buffer.
  - ***Hint:*** You can use `Monitor.PulseAll(buffer)`
- You can use the following print statement inside the put method, to print which place and what value was put in.

   - > `Console.WriteLine(Thread.CurrentThread.Name + "\tPut: " + putIndex + ": " + n);`

***Hint:*** Remember to `Monitor.Enter(buffer)` and `Monitor.Exit(buffer)` to access and release the buffer.
### Task 2 - Implementation of CircularBuffer.cs - Get()
Implement the `Get()` method as follows: 

- The `Consumers` takes the values starting on `index = 0`. 
If there is no value on the place, wait for a `Producer` to put in a value.
  - ***Hint:*** `Monitor.Wait(buffer)` can be used to wait
- When a value is taken, set the place to `null`.

- When the value on the last place is taken, start at `index = 0`.

    - ***Hint:*** *Again, compute circular index using modulo*

- Notify other threads, when consumer is done with getting value from the buffer.
  - ***Hint:*** You can use `Monitor.PulseAll(buffer)`
- You can use the following print statement inside the get method, to print which place and what value was taken.

   - > `Console.WriteLine(Thread.CurrentThread.Name + "\tGot: " + getIndex + ": " + buffer[getIndex]);`

***Hint:*** Remember to `Monitor.Enter(buffer)` and `Monitor.Exit(buffer)` to access and release the buffer.
### Task 3
Experiment with different number of `Producers` and `Consumers` in `PcFixed.cs`

### Task 4
Experiment with different sleep-times in `Producer` and `Consumer`



### Example

Below is an example output from running the program:
```csharp
Producer_0      Put: 0: 0
Producer_1      Put: 1: 100
Consumer_0      Got: 0: 0
Consumer_1      Got: 1: 100
*** Buffer empty ***
Producer_0      Put: 2: 1
Producer_1      Put: 3: 101
Producer_0      Put: 4: 2
Producer_1      Put: 0: 102
Consumer_0      Got: 2: 1
Producer_1      Put: 1: 103
Producer_1      Put: 2: 104
*** Buffer full ***
Consumer_1      Got: 3: 101
Producer_1      Put: 3: 106
*** Buffer full ***
*** Buffer full ***
Consumer_2      Got: 4: 2
Consumer_1      Got: 0: 102
Consumer_0      Got: 1: 103
Consumer_0      Got: 2: 104
Producer_1      Put: 4: 108
Producer_0      Put: 0: 4
Consumer_2      Got: 3: 106
Producer_1      Put: 1: 109
Consumer_0      Got: 4: 108
Consumer_1      Got: 0: 4
Producer_1      Put: 2: 110
Producer_0      Put: 3: 5
Producer_0      Put: 4: 6
Consumer_2      Got: 1: 109
Consumer_0      Got: 2: 110
Consumer_1      Got: 3: 5
Producer_1      Put: 0: 111
Producer_1      Put: 1: 112
```