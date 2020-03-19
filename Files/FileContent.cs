using System;

namespace csharp_text_analyser_lukaszkedziora
{
    public class FileContent : IterableText
    {
        private string File;

        public FileContent(string file){
            this.File = System.IO.File.ReadAllText(@file);
        }

        public Iterator CharIterator(){
            return new CharIterator(File);
        }

        public Iterator WordIterator(){   
             return new WordIterator(File);

        }
    }
}