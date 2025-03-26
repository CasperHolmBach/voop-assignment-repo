// See https://aka.ms/new-console-template for more information

using Synchronization;

TrainReservationSystem reservationSystem = new TrainReservationSystem();
Console.WriteLine("Available Seats before booking and cancellation= "+reservationSystem.GetAvailableSeats());

Thread thread1 = new Thread(() => reservationSystem.BookSeat(2));
Thread thread2 = new Thread(() => reservationSystem.BookSeat(3));
Thread thread3 = new Thread(() => reservationSystem.CancelSeat(2));
thread1.Start();
thread2.Start();
thread3.Start();
thread1.Join();
thread2.Join();
thread3.Join();
Console.WriteLine("Available Seats after booking and cancellation= "+reservationSystem.GetAvailableSeats());