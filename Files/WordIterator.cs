using System.Linq;

using System;
using System.Text;
namespace csharp_text_analyser_lukaszkedziora
{
    public class WordIterator : Iterator
    {
        private FileContent FileContent;
        private int index = 0;
        public string word;
        
        public WordIterator(FileContent fileContent){
            this.FileContent = fileContent;
        }

        private bool IsWhiteSpace(char element){
            if (element == ' '){
               return true; 
            } 
        return false;
        }
        
        public bool HasNext(){
        if (index < FileContent.FileWordList.Length){
                return true;
                }
            return false;
            
        }

        public string MoveNext(){
            return FileContent.FileWordList[index++];
            
        }

        public void Remove()
        {
            throw new System.NotImplementedException();
        }
    }
}