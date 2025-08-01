using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.TaskSets.TaskSet6
{
    internal class Email : INotify
    {
        public string EmailAdress { get; private set; }
        public string Message { get; private set; }
        
        public Email(string email, string message)
        {
            EmailAdress = email;
            Message = message;
        }
        public void Notify()
        {
            Console.WriteLine($"Notifying {EmailAdress} by email with message {Message}");
        }
    }
}
