using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.TaskSets.TaskSet6
{
    internal class Sms : INotify
    {
        public string Message { get; private set; }
        public string PhoneNumber { get; private set; }

        public Sms(string message, string phoneNumber)
        {
            Message = message;
            PhoneNumber = phoneNumber;
        }

        public void Notify()
        {
            Console.WriteLine($"Notifying {PhoneNumber} by sms with message {Message}");
        }
    }
}
