using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks.Task5.Task5._3
{
    class BusRoute
    {
        public string? RounteNumber { get; private set; }
        public List<string> Stops { get; private set; } = new();
        public int TimeBetweenStops { get; private set; }

        public void SetRouteName(string name, int stops) 
        {
            TimeBetweenStops = stops;
            RounteNumber = name;
        }

        public void AddStop(string stop) 
        {
            if (string.IsNullOrEmpty(stop)) 
            {
                Console.WriteLine("stop name cant be null");
                return;
            }

            Stops.Add(stop);
        }

        public int GetTotalTime() 
        {
            return Stops.Count * TimeBetweenStops;
        }

        public string GetNextStop(string currentStop) 
        {
            if (!Stops.Contains(currentStop)) 
            {
                return "No such stop";
            }

            var index = Stops.IndexOf(currentStop);

            if (index == Stops.Count - 1) 
            {
                return "last station";
            }

            return Stops[index + 1];
        }

        public void RemoveStop(string stop) 
        {
            if (!Stops.Contains(stop))
            {
                Console.WriteLine("Cant remove stop that does not exist");
                return;
            }

            Stops.Remove(stop);
            Console.WriteLine($"{stop} stop is removed");
        }

        public void PrintRoute() 
        {
            if (Stops.Count == 0) 
            {
                Console.WriteLine("Stops are not defined!");
                return;
            }

            Console.WriteLine("Route: ");

            Stops.ForEach(Console.WriteLine);
            Console.WriteLine("------------");
        }
    }
}
