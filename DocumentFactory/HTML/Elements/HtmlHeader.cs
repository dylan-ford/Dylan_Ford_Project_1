using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.HTML.Elements
{
    public class HtmlHeader : HtmlElement
    {
        private string _headerSize;
        private string _headerTitle;

        public HtmlHeader(string headerSize, string headerTitle)
        {
            _headerSize = headerSize;
            _headerTitle = headerTitle;
        }

        public override string ToString()
        {
            switch(_headerSize)
            {
                case "1":
                    return $"<h1>{_headerTitle}</h1>";
                case "2":
                    return $"<h2>{_headerTitle}</h2>";
                case "3":
                    return $"<h3>{_headerTitle}</h3>";
                default:
                    return null;
            }
            
        }
    }
}
