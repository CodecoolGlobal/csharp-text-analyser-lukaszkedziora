using System.Collections.Generic;

namespace csharp_text_analyser_lukaszkedziora
{
    class StatisticalAnalysis

    {
        private IIterator Elements;
        private int counter = 0;
        private int counterCountOf = 0;
        public StatisticalAnalysis(IIterator elements){
             this.Elements = elements;
        }
    
        public int CountOf(params string[] name){
            if (Elements.MoveNext() == name[0]){
                counterCountOf++;
                return counterCountOf;
            }
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
