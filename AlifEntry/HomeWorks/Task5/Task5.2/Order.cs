using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks.Task5.Task5._2
{
    public class Order
    {
        public Dictionary<Product, int> Items { get; private set; } = new();

        public void AddProduct(Product product, int quantity) 
        {
            if (product.Stock < quantity) 
            {
                Console.WriteLine("Exceeds number of units in stock");
                return;
            }

            if (Items.ContainsKey(product)) 
            {
                Items[product] += quantity;
                return;
            }
            Items.Add(product, quantity);
        }

        public void RemoveProduct(Product product) 
        {
            if (!Items.ContainsKey(product)) 
            {
                return;
            }
            Items.Remove(product);
        }

        public decimal TotalPrice() 
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Key.Price * item.Value;
            }
            return total;
        }

        public string PrintReceipt() 
        {
            StringBuilder sb = new();

            sb.AppendLine("products bought: ");
            foreach (var item in Items) 
            {
                sb.AppendLine($"{item.Key.Name} - {item.Key.Price} X {item.Value} = {item.Key.Price * item.Value}");
            }

            sb.AppendLine($"Total: {this.TotalPrice()}");

            return sb.ToString();
        }

        public void ClearOrder() 
        {
            Items.Clear();
        }
    }
}
