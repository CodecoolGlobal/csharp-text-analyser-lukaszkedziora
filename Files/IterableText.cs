using System;

namespace csharp_text_analyser_lukaszkedziora
{
    interface IIterableText
    {
        public IIterator CharIterator();
        public IIterator WordIterator();

    }
}
