namespace csharp_text_analyser_lukaszkedziora
{
    public class CharIterator : Iterator
    {
        private string FileContent;
        private int index = 0;
        public CharIterator(string fileContent){
            this.FileContent = fileContent;
        }

        private bool IsWhiteSpace(char element){
            if (element == ' '){
               return false; 
            } 
        return true;
        }

       // public void isAlphabetical();{

       // }

        public bool HasNext(){
            if (index < FileContent.Length){
                return true;
                }
            return false;
            
        }

        public string MoveNext(){
         if (this.IsWhiteSpace(FileContent[index])){
                return FileContent[index++].ToString();
            }
            index++;
            //this.Remove();
            return null;
        }

        public void Remove()
        {   //index++;
            this.MoveNext();
        }
    }
}