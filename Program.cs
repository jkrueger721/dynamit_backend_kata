using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{

    static void Main(string[] args)
    {
        //Read text file and store in varible 
        var text = File.ReadAllText(@"Paragraph.txt");
        var fixedtext = Regex.Replace(text, "[^a-zA-Z0-9 ]", string.Empty);
        var fixedspace = Regex.Replace(fixedtext, "s+/" , " ");
        var lower = fixedspace.ToLower();
        var words = lower.Split(' ').ToArray();
        //create dictionary with key value paring of string and int where the "word" is 
        // the key and the "count" as the value 
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
        var items = from pair in dictionary
                    orderby pair.Value descending
                    select pair;
        // Write to file to display output
        using (StreamWriter file = new StreamWriter("Output.txt"))
        foreach (var entry in items)
        file.WriteLine("This word: {0} , Occurs {1} times", entry.Key, entry.Value); 
        
    }
}