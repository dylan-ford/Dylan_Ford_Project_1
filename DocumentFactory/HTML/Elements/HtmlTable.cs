using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.HTML.Elements
{
    public class HtmlTable : HtmlElement
    {
        private string[] _head;
        private string[] _row1;
        private string[] _row2;
        private string[] _row3;
        private string _table;
        public HtmlTable(string head, string row1, string row2, string row3)
        {
            _head = head.Split('$');
            _row1 = row1.Split('$');
            _row2 = row2.Split('$');
            _row3 = row3.Split('$');
        }
        public override string ToString()
        {
            _table += "<table><thead><tr>";
            for (int i = 1; i < _head.Length; i++)
            {
                _table += $"<th>{_head[i]}</th>";
            }

            _table += "</tr></thead><tr>";

            for (int i = 1; i < _head.Length; i++)
            {
                _table += $"<td>{_row1[i]}</td>";
            }

            _table += "</tr><tr>";

            for (int i = 1; i < _head.Length; i++)
            {
                _table += $"<td>{_row2[i]}</td>";
            }

            _table += "</tr><tr>";

            for (int i = 1; i < _head.Length; i++)
            {
                _table += $"<td>{_row3[i]}</td>";
            }

            _table += "</tr></table>";

            return _table;
        }
    }
}