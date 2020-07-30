using DocumentFactory.Markdown;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.HTML
{
    public class HtmlDocument : IDocument
    {
        List<IElement> elementList = new List<IElement>(); //list of elements

        public HtmlDocument(string _fileName)
        {

        }
        public void AddElement(IElement element)
        {
            elementList.Add(element);
        }

        public void RunDocument()
        {
            var _fileName = @".\htmloutput.html";
            using (var writer = new StreamWriter(_fileName))
            {
                writer.WriteLine("<!DOCTYPE html><html><head></head><body>");
                foreach (var element in elementList)
                {
                    writer.WriteLine(element.ToString());
                }
                writer.WriteLine("</body></html>");
            }
            
            var index = new FileInfo(_fileName);
            System.Diagnostics.Process.Start("chrome.exe", $"--homepage \"{index.FullName}\"");
        }
    }
}
