using System;
using System.Text;
using System.Collections.Generic;


namespace csharp_text_analyser_lukaszkedziora
{
    class StatisticalAnalysis

    {
        private IIterator Elements;
        private int counter = 0;
       //private StringBuilder FileContentWithoutWhite = new StringBuilder(10);
        public StatisticalAnalysis(IIterator elements){
             this.Elements = elements;
        }
    
        public StatisticalAnalysis(){
           

        }

        public int CountOf(params string[] name){
            return 0;
        }

        public int DictionarySize(HashSet<string> words){

            words.Add(Elements.MoveNext());

            return words.Count;       
        }

        public int Size(){
            Elements.MoveNext();
            counter++;
              
            return counter;           
        } 


    }
}
