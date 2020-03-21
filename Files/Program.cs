using System;
using System.Collections.Generic;


namespace csharp_text_analyser_lukaszkedziora
{
    class Program
    {
        static void Main(string[] args)
        {   
            HashSet<string> words = new HashSet<string>(); 
            int sumChar = 0;
            int sumWord = 0;
            int sumDictionary = 0;
            int countOf = 0;

            var time = System.Diagnostics.Stopwatch.StartNew();            
            try{
            
            foreach (string file_name in args) {
                
                FileContent file = new FileContent(file_name);
                           
                for(IIterator iter = file.CharIterator(); iter.HasNext();){
                StatisticalAnalysis oneletter = new StatisticalAnalysis(iter);
                sumChar = sumChar + (oneletter.Size());
                }
                Console.Clear();
                Console.WriteLine(file_name);

                for(IIterator iter = file.WordIterator(); iter.HasNext();){
                StatisticalAnalysis statistical = new StatisticalAnalysis(iter);
                sumWord = sumWord + (statistical.Size());
                sumDictionary = statistical.DictionarySize(words);
                countOf = countOf + statistical.CountOf("love", "hate", "music");
                }
                Console.WriteLine("  Char count: " + sumChar);
                Console.WriteLine("  Word count: " + sumWord);
                Console.WriteLine("    Dict siz: " + sumDictionary);
                Console.WriteLine("'love' count: " + countOf);
                Console.WriteLine();
            }
        }
                catch (System.IO.FileNotFoundException) {
                    Console.WriteLine("Could not find file, please enter correct file name");
                }
            time.Stop();
            double elapsedTime = time.ElapsedMilliseconds/1000.0;
            Console.WriteLine($"Benchmark time: {elapsedTime} secs");
        }
        
    }
}
