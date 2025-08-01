using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks.Task6.Task6._2
{
    using BCrypt.Net;
    internal class User
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PasswordHash { get; private set; }
        public bool IsLoggedIn { get; private set; }

        private DateTime _registeredTime;

        public User(string firstName, string lastName, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            PasswordHash = BCrypt.HashPassword(password);
            IsLoggedIn = false;
            _registeredTime = DateTime.Now;
        }

        public void Login(string username, string password) 
        {
            if (IsLoggedIn)
            {
                Console.WriteLine("You are already logged in");
                return;
            }

            if (FirstName.Equals(username) && BCrypt.Verify(password, PasswordHash))
            {
                IsLoggedIn = true;
                Console.WriteLine($"Welcome back, {username}");
                return;
            }
            Console.WriteLine("Error occured!");
        }

        public void Logout()
        {
            if (!IsLoggedIn) 
            {
                Console.WriteLine("You are already logged out");
                return;
            }
            IsLoggedIn = false;
            Console.WriteLine("You have logged out");
        }

        public string GetFullInfo() 
        {
            return $"{FirstName} {LastName}| online: {IsLoggedIn}";
        }

        public void ChangePassword(string oldPassword, string newPassword) 
        {
            if (BCrypt.Verify(oldPassword, PasswordHash)) 
            {
                PasswordHash = BCrypt.HashPassword(newPassword);
                Console.WriteLine("Password updated");
                return;
            }
            Console.WriteLine("odl password does not match");
            return;
        }

        public int GetAccountAgeInDays() 
        {
            return (DateTime.Now - _registeredTime).Days;
        }
    }
}
