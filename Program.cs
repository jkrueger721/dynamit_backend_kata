using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static void Main(string[] args)
    {
        // int i;
        // int count;
        // int item;


        var text = File.ReadAllText(@"Paragraph.txt");
        var punctuation = text.Where(Char.IsPunctuation).Distinct().ToArray();
        var words = text.Split().Select(x => x.Trim(punctuation)).ToArray();

          Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word] += 1; 
                }
                else
                {
                    dictionary.Add(word,1);
                }
            }
        // Dictionary<string, int>.ValueCollection vals = dictionary.Values;
        Console.WriteLine();
        foreach( KeyValuePair<string, int> kvp in dictionary )
        {
            Console.WriteLine("Key = {0}, Value = {1}", 
                kvp.Key, kvp.Value);
        }
        
    }
}