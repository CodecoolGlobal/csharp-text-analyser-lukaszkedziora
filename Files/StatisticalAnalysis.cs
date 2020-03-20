using System;
using System.Text;


namespace csharp_text_analyser_lukaszkedziora
{
    class StatisticalAnalysis

    {
       private Iterator Elements;
       private int counter = 0;
       //private StringBuilder FileContentWithoutWhite = new StringBuilder(10);
        public StatisticalAnalysis(Iterator elements){
             this.Elements = elements;
        }
    
        public StatisticalAnalysis(){
           

        }

        public int CountOf(params string[] name){
            return 0;
        }

        public int DictionarySize(){
            return 0;
        }

        public int Size(){
            Elements.MoveNext();
            counter++;
              
            return counter;           
        } 


    }
}
