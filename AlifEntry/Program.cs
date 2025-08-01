using AlifEntry.HomeWorks;
using AlifEntry.HomeWorks.Task5;
using AlifEntry.HomeWorks.Task5.Task5._2;
using AlifEntry.HomeWorks.Task5.Task5._3;
using AlifEntry.HomeWorks.Task5.Task5._4;
using AlifEntry.HomeWorks.Task5.Task5._5;
using AlifEntry.HomeWorks.Task6.Task6._1;
using AlifEntry.HomeWorks.Task6.Task6._3;
using AlifEntry.HomeWorks.Task6.Task6._4;
using AlifEntry.TaskSets.TaskSet3.Task2;
using AlifEntry.TaskSets.TaskSet6;
using System;
using System.Linq;
using System.Numerics;

namespace AlifEntry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task6
            //Task6.1
            var rect = new Rectangle(5, 10, "Red");

            Console.WriteLine($"Width: {rect.Width}");
            Console.WriteLine($"Height: {rect.Height}");
            Console.WriteLine($"Color: {rect.Color}");
            Console.WriteLine($"Area: {rect.GetArea()}");
            Console.WriteLine($"Perimeter: {rect.GetPerimeter()}");

            Console.WriteLine();

            //Task6.2
            var user = new HomeWorks.Task6.Task6._2.User("Ivan", "Ivanov", "1234");

            user.Login("Ivan", "wrong");           
            user.Login("Ivan", "1234");            

            Console.WriteLine(user.GetFullInfo()); 

            user.ChangePassword("1234", "abcd");   
            user.Logout();                         

            user.Login("Ivan", "1234");            
            user.Login("Ivan", "abcd");            

            Console.WriteLine($"Days after registration: {user.GetAccountAgeInDays()}");

            Console.WriteLine();

            //Task6.3
            Author author = new Author("Alexander", 45, "Russia");

            Book book1 = new Book("The Master and Margarita", "Novel", 350);
            Book book2 = new Book("Heart of a Dog", "Science Fiction", 150);

            author.AddBook(book1);
            author.AddBook(book2);

            author.Introduce();

            Console.WriteLine("Books by the author:");
            foreach (var book in author.ListBooks())
            {
                Console.WriteLine(book.GetInfo());
            }

            author.CelebrateBirthday();
            Console.WriteLine($"Happy birthday! The author is now {author.GetAge()} years old.");

            Console.WriteLine();

            //Task6.4
            Country uzbekistan = new Country("Uzbekistan", "Tashkent", 38000000, "Uzbek");

            uzbekistan.PrintInfo();
            #endregion
            #region Task5
            //Task 5.1
            //var account1 = new BankAccount("Alice", "ACC123", 1000, "Savings");
            //var account2 = new BankAccount("Bob", "ACC456", 500, "Current");
            //var account3 = new BankAccount("Charlie", "ACC789", 2000, "Business");

            //account1.Deposit(200);

            //account2.Withdraw(100); 
            //account2.Withdraw(300); 

            //account3.TransferTo(account1, 500);

            //Console.WriteLine("\n--- Account Statements ---");
            //Console.WriteLine(account1.PrintStatement());
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine(account2.PrintStatement());
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine(account3.PrintStatement());

            //Console.WriteLine();

            ////Task 5.2
            //var laptop = new Product("Laptop", 1500, 10);
            //var mouse = new Product("Mouse", 25, 50);
            //var book = new Product("Book", 15, 100);
            //var tshirt = new Product("T-Shirt", 20, 30);
            //var kettle = new Product("Kettle", 45, 20);

            //var allProducts = new List<Product> { laptop, mouse, book, tshirt, kettle };

            //var order = new Order();
            //order.AddProduct(laptop, 1);
            //order.AddProduct(mouse, 2);
            //order.AddProduct(book, 3);

            //Console.WriteLine("--- Product List ---");
            //foreach (var p in allProducts)
            //{
            //    Console.WriteLine($"{p.Name} - {p.Price} $ (in stock: {p.Stock})");
            //}

            //order.RemoveProduct(mouse);

            //Console.WriteLine("\n--- Receipt ---");
            //Console.WriteLine(order.PrintReceipt());

            //Console.WriteLine();

            ////Task 5.3
            //var route = new BusRoute();
            //route.SetRouteName("37", 5);

            //route.AddStop("Main Street");
            //route.AddStop("Central Park");
            //route.AddStop("City Hall");
            //route.AddStop("Museum");
            //route.AddStop("University");

            //route.AddStop("Airport"); 

            //Console.WriteLine("\n--- Initial Route ---");
            //route.PrintRoute();

            //Console.WriteLine($"\nTotal travel time: {route.GetTotalTime()} minutes");

            //string currentStop = "City Hall";
            //Console.WriteLine($"\nNext stop after '{currentStop}': {route.GetNextStop(currentStop)}");

            //route.RemoveStop("Museum");

            //Console.WriteLine("\n--- Updated Route ---");
            //route.PrintRoute();

            //Console.WriteLine($"\nTotal travel time: {route.GetTotalTime()} minutes");

            //Console.WriteLine();

            ////Task 5.4

            //var hotel = new Hotel();

            //hotel.AddRoom(new Room(101, "Single", 50));
            //hotel.AddRoom(new Room(102, "Double", 80));
            //hotel.AddRoom(new Room(103, "Suite", 150));
            //hotel.AddRoom(new Room(104, "Single", 55));
            //hotel.AddRoom(new Room(105, "Double", 85));
            //hotel.AddRoom(new Room(106, "Luxury Suite", 200));

            //int roomToCancel = 101;
            //hotel.BookRoom(roomToCancel);
            //hotel.BookRoom(103);
            //hotel.BookRoom(106);

            //Console.WriteLine("Booked rooms are: ");
            //foreach (var room in hotel.ShowBookedRooms())
            //{
            //    Console.WriteLine($"Room #{room.Number} - Type: {room.Type}, Price: ${room.Price}");
            //}

            //Console.WriteLine($"Cancel room #{roomToCancel}");
            //hotel.CancelBooking(roomToCancel);

            //Console.WriteLine("Available rooms are: ");
            //foreach (var room in hotel.ShowAvailableRooms())
            //{
            //    Console.WriteLine($"Room #{room.Number} - Type: {room.Type}, Price: ${room.Price}");
            //}

            //Console.WriteLine($"Total income from booked rooms is {hotel.TotalBookedIncome()}");

            //Console.WriteLine();

            ////Task 5.5
            //var movie1 = new Movie();
            //movie1.SetMovie("Interstellar", "Sci-Fi", 169, 0);

            //var movie2 = new Movie();
            //movie2.SetMovie("The Godfather", "Drama", 175, 0);

            //var movie3 = new Movie();
            //movie3.SetMovie("The Hangover", "Comedy", 100, 0);

            //var movie4 = new Movie();
            //movie4.SetMovie("Mad Max", "Action", 120, 0);

            //var movie5 = new Movie();
            //movie5.SetMovie("Arrival", "Sci-Fi", 116, 0);

            //var user = new User("Alice");
            //user.WatchMovie(movie1);
            //user.WatchMovie(movie2);
            //user.WatchMovie(movie4);

            //user.RateMovie(movie1, 9.0);
            //user.RateMovie(movie2, 8.5);
            //user.RateMovie(movie4, 7.5);

            //Console.WriteLine("--- Watched Movies with Ratings ---");
            //foreach (var movie in user.GetWatchHistory())
            //{
            //    Console.WriteLine($"Title: {movie.Title}, Genre: {movie.Genre}, Rating: {movie.Rating}");
            //}

            //var recomendations = user.RecomendedByGenre("Sci-Fi");

            //if (recomendations != null) 
            //{

            //    Console.WriteLine("Recomendations for Sci-Fi genre");
            //    recomendations.ForEach(movie => Console.WriteLine($"Title: {movie.Title}, Genre: {movie.Genre}, Rating: {movie.Rating}"));
            //}

            //Console.WriteLine($"\nAverage rating: {user.GetAverageRating():0.00}");
            #endregion
            #region TaskSet 3

            //Post post = new Post();
            //post.SetPost("Hello World");

            //for (int i = 0; i < 10; i++)
            //{
            //    post.AddLike();
            //}

            //post.AddComment(new Comment("Tom", "Great Post!"));
            //post.AddComment(new Comment("Bob", "Keep going!"));

            //Console.WriteLine(post.GetInfo());

            //Console.WriteLine();

            //IPlayer player = new FootballPlayer("Od", 3, "Qwe", "Hz");
            //IPlayer player2 = new FootballPlayer("Tom", 13, "Qwe", "Hz");

            //player.AssistTo(player2);
            //player.AssistTo(player2);

            //player.ScorePoint();

            //player.GetInfo();
            //player2.GetInfo();

            //player = new BasketballPlayer("Od", 3, "Qwe", "Hz");
            //player2 = new BasketballPlayer("Tom", 13, "Qwe", "Hz");

            //player.AssistTo(player2);
            //player.AssistTo(player2);

            //player.ScorePoint();

            //player.GetInfo();
            //player2.GetInfo();

            #endregion
            #region HW4
            //HW4.PrintStatus(12043);
            //HW4.PrintNumberStatus();
            //HW4.PrintEvenIndexes();
            //Console.WriteLine(HW4.RepetativeNumbers([1, 2, 1, 2, 4, 5, 6, 7, 1]));
            //Console.WriteLine();
            //HW4.PrintMultiTable(2, 3);
            //HW4.Calc();
            #endregion
            #region HW2 printout
            //TaskSet2.PrintFibonnachiSequance(10);
            //Console.WriteLine(HW3.EvenCount(12345));
            //Console.WriteLine(HW3.OddCount(12345));
            //Console.WriteLine(HW3.DigitCount(12345));
            //Console.WriteLine(HW3.MinDigit(12345));
            //Console.WriteLine(HW3.MaxDigit(12345));
            //Console.WriteLine(HW3.Pow(2, 3));

            //int x = 10;
            //int y = 20;

            //Console.WriteLine($"Before Swap: x = {x}, y = {y}");
            //HW3.Swap(ref x, ref y);
            //Console.WriteLine($"After Swap: x = {x}, y = {y}");

            //HW3.Divisors(8);

            //int[] arr = new int[] { 1, 2, 3 };
            //HW3.IncrementArrayElements(ref arr, 5);

            //foreach (var item in arr)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            //Console.WriteLine(HW3.MinNumber(1,2,3,-1));

            //Console.WriteLine(HW3.Min(1,2));
            //Console.WriteLine(HW3.Max(1,2));
            #endregion
        }

        static void ReferenceTypeCopyingExample() 
        {
            var val = new List<int>() { 1, 2, 3, 4, 5 };

            Console.Write("We have: ");
            val.ForEach(x => Console.Write(x + " "));
            Console.Write("values");

            Console.WriteLine();

            var copied = val;
            copied.Clear();

            Console.WriteLine($"After copying values by refference and clearing new variable we have {val.Count} values");
        }

        static int RecursyExample(int n) 
        {
            Console.WriteLine(n);
            if (n <= 0) 
            {
                return 0;
            }
            return RecursyExample(n-1);
        }
    }
}
