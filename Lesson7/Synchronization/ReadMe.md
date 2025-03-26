# Synchronization Exercise

This exercise simulates a simple train reservation system where the passengers can book, cancel and view available seats.

## Key Concepts:
Please keep in mind the following key concepts while doing this exercise.
* Critical Section: Identifying the parts of your code that need to be protected by synchronization.
* Race Conditions: Recognizing situations where multiple threads accessing shared data can lead to unexpected and incorrect results.
* Synchronization: Using synchronization mechanism to control access to shared resources and prevent race conditions.

### Implement `TrainReservationSystem.cs`
* Locate the class `TrainReservationSystem.cs` under Synchronization namespace.
* Declare a variable `avaiableSeats` and initialize it to 10.

**Reminder** Ensure thread safety by using a **lock** / **Synchronized attribute** / **Monitor** to prevent race conditions when accessing the shared `availableSeats` variable.

* Implement `BookSeat()` method as follows. This method allows users to book a specified number of seats.
    * If enough seats are available:
        * The `availableSeats` variable is decremented by the `seatsToBook` value.
        * Print a message to the console indicating the number of seats booked and the remaining available seats.
        * Return `true`.
    * If there are insufficient seats:
        * Print message to the console indicating the number of available seats and that the booking failed.
        * Return `false`.
* Implement `CancelSeat()` method. This method allows users to cancel a specified number of seats.
  * The `availableSeats` variable is incremented by the `seatsToCancel` parameter 
  * Print message to the console indicating the number of seats cancelled and the updated `availableSeats` count.
  * Return `true`, indicating that the cancellation was successful.

* Implement `GetAvailableSeat()` method. This method allows users to check the current number of available seats by returning `availableSeats`.

### Program.cs
This class is fully implemented for you to test the system. 
Take a look.

It creates and executes 3 threads representing 3 passengers who want to book and cancel seats respectively.

Running the program should give the following output (Text may vary based your print statements):
## Output
```text
Available Seats before booking and cancellation= 10
Booked 2 seats. Remaining: 8
Booked 3 seats. Remaining: 5
Cancelled 2 seats. Available: 7
Available Seats after booking and cancellation= 7
```