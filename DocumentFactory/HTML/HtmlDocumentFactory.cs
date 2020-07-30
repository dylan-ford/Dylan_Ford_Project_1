using DocumentFactory.HTML.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.HTML
{
    public class HtmlDocumentFactory :IDocumentFactory
    {
        private static HtmlDocumentFactory _instance;

        public HtmlDocumentFactory()
        {

        }

        public static HtmlDocumentFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new HtmlDocumentFactory();
            }

            return _instance;
        }

        public IDocument CreateDocument(string fileName)
        {
            return new HtmlDocument(fileName);
        }

        public IElement CreateElement(string elementType, string props)
        {
            var propArray = props.Split(';');
            IElement element;

            //determine element type
            switch (elementType)
            {
                case "Image":
                    element = new HtmlImage(propArray[0], propArray[1], propArray[2]);
                    return element;
                case "Header":
                    element = new HtmlHeader(propArray[0], propArray[1]);
                    return element;
                case "List":
                    element = new HtmlList(propArray[0], propArray[1], propArray[2], propArray[3]);
                    return element;
                case "Table":
                    element = new HtmlTable(propArray[0], propArray[1], propArray[2], propArray[3]);
                    return element;
                default:
                    return null;
            }
        }
    }
}
