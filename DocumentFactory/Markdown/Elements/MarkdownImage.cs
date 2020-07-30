using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown.Elements 
{
    public class MarkdownImage : MarkdownElement
    {
        private string _imageLoc;
        private string _altText;
        private string _titleText;

        public MarkdownImage(string imageLoc, string altText, string titleText)
        {
            _imageLoc = imageLoc;
            _altText = altText;
            _titleText = titleText;
        }

        //turns obj into string
        public override string ToString()
        {
            return $"![{_altText}]({_imageLoc} \"{ _titleText}\")\n";
        }
    }
}
