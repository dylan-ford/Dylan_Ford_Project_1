using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.HTML.Elements
{
    public class HtmlImage : HtmlElement
    {
        private string _imageLoc;
        private string _altText;
        private string _titleText;

        public HtmlImage(string imageLoc, string altText, string titleText)
        {
            _imageLoc = imageLoc;
            _altText = altText;
            _titleText = titleText;
        }

        //turns obj into string
        public override string ToString()
        {
            return $"<img alt='{_altText}' title='{_titleText}' src='{_imageLoc}' /><br />";
        }
    }
}