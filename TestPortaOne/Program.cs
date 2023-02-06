using System;
using System.Collections.Generic;
using System.Linq;

namespace TestPortaOne
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Владелец\RiderProjects\TestPortaOne\TestPortaOne\Text.txt");

         string[] test1 = ChooseTheChar(text);
        // Console.WriteLine( NonRepeatChar(test1));
      Console.WriteLine(NonRepeatChar(test1).ToString().First());  
        }
        public static String[] ChooseTheChar(string text)
        {
            char[] separators = new char[] { ' ', '.', '\n', '\t' };
            String []  exclusiveChars = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return exclusiveChars;
        }

        public static List<string> NonRepeatChar(string[] text)
        {
            List<string> exclusiveChar=new List<string>();
            foreach (var symbol in (text))
            { 
                char [] symbols;
                symbols = symbol.ToCharArray();
                try
                {
                    exclusiveChar.Add(symbols.
                        GroupBy(i => i)
                        .Where(g => g
                            .Count() == 1).
                        Select(g => g.Key).
                        First().ToString());
                }
                catch (System.InvalidOperationException)
                {
                    exclusiveChar.Add(null);
            }
                
                
            }
                    
                
            
            return exclusiveChar.Distinct().ToList() ;
        }
        
    }
}