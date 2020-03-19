using System;

namespace csharp_text_analyser_lukaszkedziora
{
    interface IterableText
    {
        public Iterator CharIterator();
        public Iterator WordIterator();

    }
}
