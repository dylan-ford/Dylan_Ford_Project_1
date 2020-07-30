using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown.Elements
{
    public class MarkdownTable : MarkdownElement
    {
        private string[] _head;
        private string[] _row1;
        private string[] _row2;
        private string[] _row3;
        private string _table;
        public MarkdownTable(string head, string row1, string row2, string row3)
        {
            _head = head.Split('$');
            _row1 = row1.Split('$');
            _row2 = row2.Split('$');
            _row3 = row3.Split('$');
        }
        public override string ToString()
        {
            for(int i = 1; i < _head.Length; i++)
            {
                _table += $"| {_head[i]} ";
            }

            _table += "|\n| --- | --- | --- |\n";

            for (int i = 1; i < _row1.Length; i++)
            {
                _table += $"| {_row1[i]} ";
            }

            _table += "|\n";

            for (int i = 1; i < _row2.Length; i++)
            {
                _table += $"| {_row2[i]} ";
            }

            _table += "|\n";

            for (int i = 1; i < _row3.Length; i++)
            {
                _table += $"| {_row3[i]} ";
            }

            _table += "|\n";

            return _table;
        }
    }
}
