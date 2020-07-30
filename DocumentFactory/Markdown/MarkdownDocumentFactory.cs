using DocumentFactory.Markdown.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown
{
    public class MarkdownDocumentFactory : IDocumentFactory
    {
        private static MarkdownDocumentFactory _instance;

        private MarkdownDocumentFactory()
        {

        }

        public static MarkdownDocumentFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MarkdownDocumentFactory();
            }

            return _instance;
        }
        public IDocument CreateDocument(string fileName)
        {
            //create new document
            return new MarkdownDocument(fileName);
        }

        public IElement CreateElement(string elementType, string props)
        {
            var propArray = props.Split(';');
            IElement element;

            //determine element type
            switch(elementType)
            {
                case "Image":
                    element = new MarkdownImage(propArray[0], propArray[1], propArray[2]);
                    return element;
                case "Header":
                    element = new MarkdownHeader(propArray[0], propArray[1]);
                    return element;
                case "List":
                    element = new MarkdownList(propArray[0], propArray[1], propArray[2], propArray[3]);
                    return element;
                case "Table":
                    element = new MarkdownTable(propArray[0], propArray[1], propArray[2], propArray[3]);
                    return element;
                default:
                    return null;
            }
        }
    }
}
