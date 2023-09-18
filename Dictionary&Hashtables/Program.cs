using System;
using System.Collections;
using System.Collections.Generic;

namespace Dictionary_Hashtables
{
    internal class Program
    {
        /// <summary>
        /// A Dictionary takes an int as a key and a string called topGames
        /// My top ten favorite games are added to Dictionary with the key being their placement
        /// The topGames is looped through and each key/value pair is printed on a new line
        /// If topGames contains key 1, its printed to console
        /// An empty string result
        /// The TryGetValue method is implemented on topGames for key 11 and output is set to result string
        /// If outputs something to result then the result is printed to console
        /// Else "there is no game in the eleventh position." is printed
        /// The dictionary entry object at key 5 with a new game title
        /// Thew new value of key 5 is printed
        /// a new Hashtable is set equal to topGames
        /// a string favGame is made
        /// Favgame is set to the value of key 1 in the hashtable
        /// Favgame is printed to console
        /// Another hashtable is made using collection-initializer syntax, called capitals
        /// the other hashtable is initialized with a dew states as the key & the capital of the state as the value
        /// The capitals hashtable is looped through & the DictionaryEntry objects key & value is printed out on a new line
        /// all the elements are cleared in the capitals hashtables
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Dictionary<int, string> topGames = new Dictionary<int, string>();
            topGames.Add(1, "Borderlands 2");
            topGames.Add(3, "Elder Scrolls 5: Skyrim");
            topGames.Add(2, "Yakuza 0");
            topGames.Add(4, "Bayonetta");
            topGames.Add(5, "The Long Dark");
            topGames.Add(6, "Cyperpunk 2077");
            topGames.Add(7, "Bioshock");
            topGames.Add(8, "Minecraft");
            topGames.Add(9, "Borderlands 3");
            topGames.Add(10, "Resident Evil");

            foreach (KeyValuePair<int, string> kvp in topGames)
            {
                Console.WriteLine($"Key: {kvp.Key}, Values: {kvp.Value}");
            }


            if (topGames.ContainsKey(1))
            {
                Console.WriteLine($"My favorite game is : {topGames[1]}1!");

            }

            string result = "";

            topGames.TryGetValue(11, out result);

            if (result != "")
            {
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine("There is no game in the elventh position");

            }

            if (topGames.ContainsKey(2))
            {
                topGames[5] = "The Long Dark";
            }

            Console.WriteLine(topGames[5]);

            Hashtable hashTable = new Hashtable(topGames);

            string favGame = (string)hashTable[1];

            Console.WriteLine($"Favorite Game: { favGame}");

            Hashtable capitals = new Hashtable()
            {
                { "Oklahoma", "Oklahoma City" },
                { "New York", "Albany" },
                { "Texas", "Austin" },
                { "Ohio", "Colombus" },
            };

            foreach (DictionaryEntry kvp in capitals)
            {
                Console.WriteLine($"Key: {kvp.Key}, Values: {kvp.Value}");

                capitals.Clear();   
            }
        }
    }
}