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
        Console.WriteLine(words[2]);
        foreach( string w in words){
            Console.WriteLine(w);
        }
    }
}