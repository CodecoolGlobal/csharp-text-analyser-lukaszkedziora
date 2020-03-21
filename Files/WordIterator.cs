namespace csharp_text_analyser_lukaszkedziora
{
    public class WordIterator : IIterator
    {
        private FileContent FileContent;
        private int index = 0;
        
        public WordIterator(FileContent fileContent){
            this.FileContent = fileContent;
        }
        public bool HasNext(){
        if (index++ < FileContent.FileWordList.Length){
                return true;
                }
            return false;
            
        }
        public string MoveNext(){
            return FileContent.FileWordList[index-1];
            
        }

    }
}