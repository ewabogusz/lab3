using System;
using System.Collections.Generic;

namespace Lab3
{
    class Program
    {
        // Klasa próbna na zajęciach
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
            Console.WriteLine("KLASA PRÓBNA\n");
            Human human = new Human
            {
                FirstName = "Ewa",
                LastName = "Boguszewska"
            };
            human.SayHello();

            Console.WriteLine("KOLEKCJE\n");
            Console.WriteLine("Zadanie 1\n");

            string[] colors = { "blue", "green", "yellow", "red", "orange" };
            Console.WriteLine($"Mój pierwszy kolor w tablicy to: {colors[0]}\n");
            Console.WriteLine($"Mój ostatni kolor w tablicy to: {colors[colors.Length - 1]}\n");

            Console.WriteLine("Zadanie 2\n");
            int[] tab = { 1, 2, 3, 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Wypisanie liczb z tablicy:\n");

            Console.WriteLine("Pętla for");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine($"Liczba: {tab[i]}");
            }

            Console.WriteLine("\nPętla foreach");
            foreach (int number in tab)
            {
                Console.WriteLine($"Liczba: {number}");
            }

            Console.WriteLine("\nPętla while");
            int index = 0;
            while (index < tab.Length)
            {
                Console.WriteLine($"Liczba: {tab[index]}");
                index++;
            }

            Console.WriteLine("\nZadanie 3\n");
            List<string> fruits = new List<string> { "malina", "jablko", "truskawka", "gruszka","mango","jagoda" };
            Console.WriteLine(string.Join(", ", fruits) + "\n");
            fruits.RemoveAt(0);
            fruits.RemoveAt(fruits.Count - 1);
            Console.WriteLine(string.Join(", ", fruits) + "\n");
        }
    }
}
