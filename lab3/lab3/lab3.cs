using System;

namespace Lab3
{
    class Program
    {
        //klasa próbna
        public class Human
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public void SayHello()
            {
                Console.WriteLine($"{FirstName} {LastName} says hello");
            }
        }

        static void Main()
        {
            Console.WriteLine("klasa probna");
            Human human = new Human
            {
                FirstName = "Ewa",
                LastName = "Boguszewska"
            };
            human.SayHello();
        }
    }
}