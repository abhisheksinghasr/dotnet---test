using System;

namespace UserDetailsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine("Enter your Name:");
            user.Name = Console.ReadLine();

            Console.WriteLine("Enter your Father's Name:");
            user.FatherName = Console.ReadLine();

            Console.WriteLine("Enter your Address:");
            user.Address = Console.ReadLine();

            Console.WriteLine("Enter your Mobile Number:");
            user.MobileNumber = Console.ReadLine();

            Console.WriteLine("\nUser Details:");
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine($"Father's Name: {user.FatherName}");
            Console.WriteLine($"Address: {user.Address}");
            Console.WriteLine($"Mobile Number: {user.MobileNumber}");
        }
    }

    class User
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
    }
}
