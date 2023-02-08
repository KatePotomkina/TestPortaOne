using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestPortaOne;

internal class Program
{
    public static void Main(string[] args)
    {
        //var text = File.ReadAllText(@"C:\Users\Владелец\RiderProjects\TestPortaOne\TestPortaOne\Text.txt");
       // Console.WriteLine(text);
        string[] variad = { "hello", "kiu", "artur", "amato","honey", "hh" };/**/
      // var test1 = ChooseTheChar(text);
      Console.WriteLine(NonRepeatChar(variad).First());
    }


    public static string[] ChooseTheChar(string text)
    {
        var separators = new[] { ' ', '.', '\n', '\t','\0','\r','"','-' };
        var exclusiveChars = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        return exclusiveChars;
    }

    public static List<string> NonRepeatChar(string[] text)
    {
        var exclusiveChar = new List<string>();
        foreach (var symbol in text)
        {
            char[] symbols;
            symbols = symbol.ToCharArray();

            exclusiveChar.Add(symbols.GroupBy(i => i)
                .Where(g => g
                    .Count() == 1).Select(g => g.Key).First().ToString());
            
            
            
        }
        
        return exclusiveChar;
    }
}