using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static void Main(string[] args)
    {
    
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
        // Test values of key pairing
        Console.WriteLine();
        foreach( KeyValuePair<string, int> kvp in dictionary )
        {
            Console.WriteLine("Key = {0}, Value = {1}", 
                kvp.Key, kvp.Value);
        }
        using (StreamWriter file = new StreamWriter("Output.txt"))
        foreach (var entry in dictionary)
        file.WriteLine("This word: {0}, Occurs {1} times", entry.Key, entry.Value); 
        
    }
}