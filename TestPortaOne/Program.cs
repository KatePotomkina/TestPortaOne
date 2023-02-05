using System;
using System.Collections.Generic;
using System.Linq;

namespace TestPortaOne
{
    internal class Program
    {
        public static void Main(string[] args)
        {
         string test="The Tao gave birth to machine language.  Machine language gave birth to the assembler. The assembler gave birth to the compiler.  Now there are ten thousand Each language has its purpose, however humble.  Each languag expresses the Yin and Yang of software.  Each language has its place within the Tao. But do not program in COBOL if you can avoid it.     -- Geoffrey James, \"The Tao of Programming\" ";
         string[] test1 = ChooseTheChar(test);
        // Console.WriteLine( NonRepeatChar(test1));
      Console.WriteLine(NonRepeatChar(test1).ToString().First());  
        }
        public static String[] ChooseTheChar(string text)
        {
            char[] separators = new char[] { ' ', '.', '\n', '\t' };

            String []  exclusiveChars = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var sub in exclusiveChars)
            {
                Console.WriteLine($"Substring: {sub}");
            }
            
            return exclusiveChars;
        }

        public static List<string> NonRepeatChar(string[] text)
        {
            List<string> exclusiveChar=new List<string>();
            foreach (var symbol in (text))
            { 
                char [] symbols;
                symbols = symbol.ToCharArray();
                exclusiveChar.Add(symbols.
                    GroupBy(i => i)
                    .Where(g => g
                        .Count() == 1).
                    Select(g => g.Key).
                    First().ToString());
                
            }
                    
                
            
            return exclusiveChar.Distinct().ToList() ;
        }
        
    }
}