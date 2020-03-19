using System;

namespace csharp_text_analyser_lukaszkedziora
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] argument = new string[1];
            argument[0] = "test.txt";        
            Console.WriteLine(argument[0]);
           
           
           // foreach (string file_name in argument)
            FileContent file = new FileContent("test.txt");
                //for(Iterator iter = file.CharIterator  )


            for(Iterator iter = file.CharIterator(); iter.HasNext();){
            //StatisticalAnalysis elements = new StatisticalAnalysis(iter.MoveNext());}
            String name = iter.MoveNext();
            Console.Write(name);}


            for(Iterator iter = file.WordIterator(); iter.HasNext();){
            //StatisticalAnalysis elements = new StatisticalAnalysis(iter.MoveNext());}
            String name = iter.MoveNext();
           

            Console.Write(name);}
            
                    
            


        }
    }
}
