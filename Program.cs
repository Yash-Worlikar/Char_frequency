using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char_frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string sent = Console.ReadLine();
            // create a char array and convert it to a string array
            char[] charArray = sent.ToCharArray();
            string[] sent_ary = sent.Select(x => x.ToString()).ToArray();
            //Create a dict to store the chars and their count
            IDictionary<string, int> Char_count = new Dictionary<string, int>();

            foreach (var word in sent_ary)
            {
                // Check if a charc exists in the Dictionary
                if (Char_count.ContainsKey(word.ToLowerInvariant()) == false)
                {
                    var matchQuery = from letter in sent_ary
                                     where letter.ToLowerInvariant() == word.ToLowerInvariant()
                                     select letter;
                    int count = matchQuery.Count();
                    Char_count.Add(word.ToLowerInvariant(), count);
                }
            }
            foreach (KeyValuePair<string, int> kvp in Char_count)
                Console.WriteLine("Character: {0}, Frequency: {1}", kvp.Key, kvp.Value);

        }
    }
}