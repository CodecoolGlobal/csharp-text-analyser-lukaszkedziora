using System.Text;
using System;

namespace csharp_text_analyser_lukaszkedziora
{
    public class FileContent : IIterableText
    {
        public string File;
        private string FileWord;
        public string[] FileWordList;

      //  FileContent test = new FileContent();

        public FileContent(string file){
            this.File = System.IO.File.ReadAllText(@file);
            this.File = File.Replace("\n" , " ").Replace("\r", " ").Replace("  ", " ").Replace("   ", " ").Replace("    "," ");
            this.FileWord = File;
                        
        }
        public FileContent(){
            
        }

        public IIterator CharIterator(){
            File = File.Replace(" " , "");
            return new CharIterator(this);
        }

        public IIterator WordIterator(){   
            FileWordList = FileWord.Split(' ');
            return new WordIterator(this);

        }
    }
}