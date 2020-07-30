using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown.Elements
{
    public class MarkdownHeader : MarkdownElement
    {
        private int _headerSize;
        private string _headerTitle;

        public MarkdownHeader(string headerSize, string headerTitle)
        {
            _headerSize = Int32.Parse(headerSize);
            _headerTitle = headerTitle;
        }

        public override string ToString()
        {
            string output = null;
            for(var i = 0; i < _headerSize; i++)
            {
                output += "#";
            }
            output += $" {_headerTitle}\n";
            return output;
        }
    }
}
