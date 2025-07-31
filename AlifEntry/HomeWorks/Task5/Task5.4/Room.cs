using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks.Task5.Task5._4
{
    public class Room
    {
        public int Number { get; private set; }
        public string? Type { get; private set; }
        public double Price { get; set; }
        public bool IsBooked { get; set; }

        public Room(int number, string type, double price, bool isBooked = false)
        {
            Number = number;
            Type = type;
            Price = price;
            IsBooked = isBooked;
        }
    }
}
