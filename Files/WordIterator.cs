using System;
using System.Text;

namespace csharp_text_analyser_lukaszkedziora
{
    public class WordIterator : Iterator
    {
        private string FileContent;
        private int index = 0;
        public string word;
        StringBuilder sb = new StringBuilder(10);
        
        public WordIterator(string fileContent){
            this.FileContent = fileContent;
        }

        private bool IsWhiteSpace(char element){
            if (element == ' '){
               return true; 
            } 
        return false;
        }
        
        public bool HasNext(){
        if (index < FileContent.Length){
                return true;
                }
            return false;
            
        }


        public string MoveNext(){
            string word = null;
         if (this.IsWhiteSpace(FileContent[index])){
                index++;
                word = sb.ToString();
                sb.Clear();
                return word;
            }
                sb.Append(FileContent[index++]);
                return null;
        }

        public void Remove()
        {
            throw new System.NotImplementedException();
        }
    }
}