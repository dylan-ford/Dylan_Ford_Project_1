using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.HTML.Elements
{
    public class HtmlList : HtmlElement
    {
        private string _listType;
        private string _item1;
        private string _item2;
        private string _item3;

        public HtmlList(string listType, string item1, string item2, string item3)
        {
            _listType = listType;
            _item1 = item1;
            _item2 = item2;
            _item3 = item3;
        }

        public override string ToString()
        {
            if (_listType == "Ordered")
            {
                return $"<ol><li>{_item1}</li><li>{_item2}</li><li>{_item3}</li></ol>";
            }
            else
            {
                return $"<ul><li>{_item1}</li><li>{_item2}</li><li>{_item3}</li></ul>";
            }
        }
    }
}
