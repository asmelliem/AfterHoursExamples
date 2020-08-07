
using August6thEnums.Cards;
using August6thEnums.Cars;
using August6thEnums.Enums;

using System;
using System.Collections.Generic;
using System.Linq;

namespace August6thEnums
{  

    static class MyExtensions
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //UserInputForShapes();
            //UserInputForAutomobiles();

            //Exercise 58-60
            var deck = CreateDeck();
            do
            {
                deck = ShuffleDeck(deck);
                var firstCard = deck.First();
                deck.RemoveAt(0);
                Console.WriteLine($"Shuffling...You drew {firstCard.PrintCard()}. There are now {deck.Count} cards left in the deck");                

            } while (ContinueProgram());

            Console.WriteLine("Goodbye!");
        }

        public static bool ContinueProgram()
        {
            while (true)
            {
                Console.WriteLine("Would you like to continue? (y/n)");
                var input = Console.ReadLine().ToUpper();

                if (input == "Y")
                {
                    return true;
                }
                else if (input == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("You didn't enter a 'Y' or 'N'");
                }
            };

        }

        public static List<Card> ShuffleDeck(List<Card> deck)
        {
            deck.Shuffle();
            return deck;
        }        

        public static List<Card> CreateDeck()
        {
            List<Card> cards = new List<Card>();

            foreach(var suit in Enum.GetNames(typeof(Suit)))
            {
                foreach(var rank in Enum.GetNames(typeof(Rank)))
                {
                    cards.Add(new Card(suit, rank));
                }
            }
            return cards;
        }

        private static void UserInputForAutomobiles()
        {
            Console.WriteLine("Please enter a car type: 0.SUV  4.Rickshaw  5.Sports");

            var userInput = Console.ReadLine();
            var validInput = Enum.TryParse(userInput, out CarType carType);

            IAutomobile automobile;
            switch (carType)
            {
                case CarType.Suv:
                    automobile = new SUV();
                    automobile.Mileage = 200;
                    automobile.Type = carType;
                    automobile.VroomVroom();
                    break;
                case CarType.Rickshaw:
                    automobile = new Rickshaw();
                    automobile.Mileage = 250;
                    automobile.Type = carType;
                    automobile.VroomVroom();
                    break;
                case CarType.Sports:
                    automobile = new Sports();
                    automobile.Mileage = 500;
                    automobile.Type = carType;
                    automobile.VroomVroom();
                    break;
                default:
                    break;
            }
        }

        private static void UserInputForShapes()
        {
            Console.WriteLine("What shape would you like to use?");
            Console.WriteLine("Enter the side of the shape:");

            try
            {
                var userInput = Console.ReadLine();
                var validInput = Enum.TryParse(userInput, out NumberOfSides side);

                IShape shape;
                switch (side)
                {
                    case NumberOfSides.Circle:
                        Console.WriteLine("You entered a Circle");
                        shape = new Circle(side);
                        break;

                    case NumberOfSides.Triangle:
                        Console.WriteLine("You entered a Triangle");
                        shape = new Triangle();
                        shape.NumberOfSides = side;
                        break;

                    case NumberOfSides.Rectangle:
                        Console.WriteLine("You entered a Rectangle");
                        shape = new Rectangle();
                        shape.NumberOfSides = side;
                        break;

                    case NumberOfSides.Hexagon:
                        Console.WriteLine("You entered a Hexagon");
                        shape = new Hexagon();
                        shape.NumberOfSides = side;
                        break;

                    default:
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You input is invalid");
            }
        }
    }
}
