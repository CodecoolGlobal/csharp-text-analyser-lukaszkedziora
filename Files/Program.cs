using System;
using System.Collections.Generic;


namespace csharp_text_analyser_lukaszkedziora
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] argument = new string[1];
            argument[0] = "test.txt";        
            Console.WriteLine(argument[0]);
            int sumChar = 0;
            int sumWord = 0;
            FileContent file = new FileContent("test.txt");
            HashSet<string> words = new HashSet<string>(); 
            int sumDictionary = 0;
            int countOf = 0;
            


           
           // foreach (string file_name in argument)
            for(IIterator iter = file.CharIterator(); iter.HasNext();){
            StatisticalAnalysis oneletter = new StatisticalAnalysis(iter);
            sumChar = sumChar + (oneletter.Size());
            }
            Console.WriteLine(sumChar);
            for(IIterator iter = file.WordIterator(); iter.HasNext();){
            StatisticalAnalysis statistical = new StatisticalAnalysis(iter);
            sumWord = sumWord + (statistical.Size());
            sumDictionary = statistical.DictionarySize(words);
            countOf = countOf + statistical.CountOf("gate");
            }
            Console.WriteLine(sumWord);
            Console.WriteLine(sumDictionary);
            Console.WriteLine(countOf);


            
            

        }
        
    }
}
