using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // static async Task Main()
    // {
    //     await ReadAndDisplayFilesAsync();
    // }

    // static async Task ReadAndDisplayFilesAsync()
    // {
    //     String filename = "Paragraph.txt";
    //     Char[] buffer;
        
    //     using (var sr = new StreamReader(filename)) {
    //         buffer = new Char[(int)sr.BaseStream.Length];
    //         await sr.ReadAsync(buffer, 0, (int)sr.BaseStream.Length);
    //     }

    //     Console.WriteLine(new String(buffer));
    // }

    static void Main(string[] args)
    {
        // var lines = File.ReadAllLines("Paragraph.txt");

        // for (int i = 0; i < lines.Length; i++)
        // {
        //     var fields = lines[i].Split(' ');
        //     Console.WriteLine(fields);
        // }
        
        // List<string> listofContents = File.ReadAllLines("Paragraph.txt").Where(x => !string.IsNullOrEmpty(x.Trim()) && !string.IsNullOrWhiteSpace(x.Trim())).ToList();
        // String[] MySortedContent =  listofContents.Where(x => !string.IsNullOrEmpty(x.Trim()) && !string.IsNullOrWhiteSpace(x.Trim())).ToArray();
        // for(int i = 0; i < MySortedContent.Length; i++){
        //     Console.WriteLine(MySortedContent[i]);
        // }
        // Console.WriteLine(MySortedContent[3]);

        var text = File.ReadAllText(@"Paragraph.txt");
        var punctuation = text.Where(Char.IsPunctuation).Distinct().ToArray();
        var words = text.Split().Select(x => x.Trim(punctuation)).ToArray();
        Console.WriteLine(words[2]);
        foreach( string w in words){
            Console.WriteLine(w);
        }
    }
}