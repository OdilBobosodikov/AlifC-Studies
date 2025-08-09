using System;
using System.Collections.Generic;

namespace AlifEntry.TaskSets.Polymorghism
{


    public abstract class SilkRoadTrader
    {
        public string Name { get; set; }
        public string City { get; set; }

        public SilkRoadTrader(string name, string city)
        {
            Name = name;
            City = city;
        }

        public abstract void Trade();

        public virtual void Greet()
        {
            Console.WriteLine($"{Name} from {City} welcomes you to the Great Bazar!");
        }

        public void Negotiate(int price)
        {
            Console.WriteLine($"{Name} offers goods for {price} gold coins.");
        }

        public void Negotiate(int price, string currency)
        {
            Console.WriteLine($"{Name} offers goods for {price} {currency}.");
        }
    }

    public class SilkTrader : SilkRoadTrader
    {
        public SilkTrader(string name, string city) : base(name, city) { }

        public override void Trade()
        {
            Console.WriteLine($"{Name} displays shimmering Bukhara silk woven with golden threads.");
        }
    }

    public class SpiceTrader : SilkRoadTrader
    {
        public SpiceTrader(string name, string city) : base(name, city) { }

        public override void Trade()
        {
            Console.WriteLine($"{Name} offers saffron, cumin, and coriander from the Fergana Valley.");
        }
    }

    public class CeramicTrader : SilkRoadTrader
    {
        public CeramicTrader(string name, string city) : base(name, city) { }

        public override void Trade()
        {
            Console.WriteLine($"{Name} sells blue-glazed Samarkand pottery with intricate floral patterns.");
        }
    }

    public class BazarManager
    {
        public void ProcessDeal(SilkRoadTrader trader)
        {
            Console.WriteLine($"\n--- Deal at the Great Bazar of {trader.City} ---");
            trader.Greet(); 
            trader.Trade();  
        }

        public void ProcessDeal(List<SilkRoadTrader> traders)
        {
            Console.WriteLine("\nMultiple deals happening at once...");
            foreach (var t in traders)
            {
                ProcessDeal(t);
            }
        }
    }
}
