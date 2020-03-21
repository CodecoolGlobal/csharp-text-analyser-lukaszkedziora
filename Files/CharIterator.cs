namespace csharp_text_analyser_lukaszkedziora
{
    public class CharIterator : IIterator
    {
        private string FileContent;
        private int index = 0;
        public string letter;

        public CharIterator(FileContent fileContent){
            this.FileContent = fileContent.File;
            
        }
        public bool HasNext(){
            if (index < FileContent.Length){
                return true;
                }
            return false;  
        }
        public string MoveNext(){
                letter = FileContent[index++].ToString();
                return letter;
        }
    }
}