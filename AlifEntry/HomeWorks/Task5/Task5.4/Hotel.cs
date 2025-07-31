using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks.Task5.Task5._4
{
    public class Hotel
    {
        public List<Room> Rooms { get; private set; } = new();
        
        public void AddRoom(Room room) 
        {
            Rooms.ForEach(r =>
            {
                if (r.Number == room.Number) 
                {
                    Console.WriteLine("Can't add room tjat is already in the list");
                    return;
                }
            });

            Rooms.Add(room);
        }

        public void BookRoom(int number) 
        {
            var room = Rooms.FirstOrDefault(x => x.Number == number);
            if (room == null) 
            {
                Console.WriteLine("Cant book non existing room");
                return;
            }
            if (room.IsBooked) 
            {
                Console.WriteLine("Room already booked");
                return;
            }

            room.IsBooked = !room.IsBooked;
        }

        public void CancelBooking(int number) 
        {
            var room = Rooms.FirstOrDefault(x => x.Number == number);
            if (room == null)
            {
                Console.WriteLine("Cant cancel booking for non existing room");
                return;
            }

            if (!room.IsBooked)
            {
                Console.WriteLine("Room was not booked");
                return;
            }

            room.IsBooked = !room.IsBooked;
        }

        public List<Room> ShowAvailableRooms() 
        {
            return Rooms.Where(x => !x.IsBooked).ToList();
        }

        public List<Room> ShowBookedRooms() 
        {
            return Rooms.Where(x => x.IsBooked).ToList();
        }

        public double TotalBookedIncome() 
        {
            return Rooms.Where(x => !x.IsBooked).Select(x => x.Price).Sum();
        }
    }
}
