using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
    Mad Libs with C#.

    This program creates a Mad Libs. It is a word game where a player prompts another for a list of words to fill the blanks in a story creating humorous results to read out loud.
    Overall, developing it helps me to practice my skills of working with Data Types and Variables in C#.

    Author: Ricardo Carvalheira
    */

            // Let the user know that the program is starting:

            Console.WriteLine("Initializing the Mad Libs Game!");

            // Give the Mad Lib a title:
            string title = "The Weird Plot";

            Console.WriteLine("\r\n\t" + title);
            Console.WriteLine("\r\n     Press Enter to start...");
            Console.ReadLine();
            Console.Clear();

            // Define user input and variables:
            Console.WriteLine("First, help us to prepare your story responding the following:");

            Console.Write("\r\nMain Character's Name: ");
            string mainCharacterName = Console.ReadLine();

            Console.Write("\r\nAdjective 1: ");

            string adjective1 = Console.ReadLine();

            Console.Write("Adjective 2: ");
            string adjective2 = Console.ReadLine();

            Console.Write("Adjective 3: ");
            string adjective3 = Console.ReadLine();

            Console.Write("\r\nNow, we need word that represents an action, like ‘sit’, ‘eat’, ‘sleep’.\r\nAction: ");
            string actionVerb = Console.ReadLine();

            Console.Write("\r\nChoose a noun like a person (‘girl’), place (‘cabin’), or thing (‘toaster’).\r\nFirst Noun: ");
            string firstNoun = Console.ReadLine();

            Console.Write("Second Noun: ");
            string secondNoun = Console.ReadLine();

            Console.WriteLine("\r\nEnter one of the following:");

            Console.Write("\r\nAnimal: ");
            string animal = Console.ReadLine();

            Console.Write("Food: ");
            string food = Console.ReadLine();

            Console.Write("Fruit: ");
            string fruit = Console.ReadLine();

            Console.Write("Superhero: ");
            string superhero = Console.ReadLine();

            Console.Write("Country: ");
            string country = Console.ReadLine();

            Console.Write("Dessert: ");
            string dessert = Console.ReadLine();

            Console.Write("Year: ");
            string year = Console.ReadLine();

            Console.Clear();
            // The template for the story:

            string story = $"This morning {mainCharacterName} woke up feeling {adjective1.ToLower()}. \r\n\r\n'It is going to be a {adjective2.ToLower()} day!' Outside, a bunch of {animal.ToLower()}s were protesting to keep {food.ToLower()} in stores.\r\n\r\nThey began to {actionVerb.ToLower()} to the rhythm of the {firstNoun.ToLower()}, which made all the {fruit.ToLower()}s very {adjective3.ToLower()}.\r\n\r\nConcerned, {mainCharacterName} texted {superhero}, who flew {mainCharacterName} to {country} and dropped {mainCharacterName} in a puddle of frozen {dessert.ToLower()}.\r\n\r\n{mainCharacterName} woke up in the year {year}, in a world where {secondNoun.ToLower()}s ruled the world.";

            // Print the story:
            Console.WriteLine(story);

            Console.WriteLine("\r\n     Press Enter to close tab...");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
