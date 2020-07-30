using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown
{
    public class MarkdownDocument : IDocument
    {
        List<IElement> elementList = new List<IElement>(); //list of elements

        public MarkdownDocument(string fileName)
        {

        }

        public void AddElement(IElement element)
        {
            elementList.Add(element);
        }

        public void RunDocument()
        {
            var _fileName = @".\markdownoutput.md";
            using (var writer = new StreamWriter(_fileName))
            {
                foreach (var element in elementList)
                {
                    writer.WriteLine(element.ToString());
                }
            }
            var index = new FileInfo(_fileName);
            System.Diagnostics.Process.Start("chrome.exe", $"--homepage \"{index.FullName}\"");
        }
    }
}
