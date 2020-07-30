using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown.Elements
{
    public class MarkdownList : MarkdownElement
    {
        private string _listType;
        private string _item1;
        private string _item2;
        private string _item3;

        public MarkdownList(string listType, string item1, string item2, string item3)
        {
            _listType = listType;
            _item1 = item1;
            _item2 = item2;
            _item3 = item3;
        }

        public override string ToString()
        {
            if(_listType == "Ordered")
            {
                return $"1. {_item1}\n2. {_item2}\n3. {_item3}\n";
            }
            else
            {
                return $"* {_item1}\n* {_item2}\n* {_item3}\n";
            }
        }

    }
}
