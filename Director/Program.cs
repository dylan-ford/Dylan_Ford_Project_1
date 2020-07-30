using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DocumentFactory.Markdown;
using DocumentFactory.HTML;


namespace Director
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] commands;
            var list = File.ReadAllText("CreateDocumentScript.txt");
            commands = list.Split('#');

            //create documentfactory, markdown document
            var markdownFactory = MarkdownDocumentFactory.GetInstance();
            var htmlFactory = HtmlDocumentFactory.GetInstance();
            MarkdownDocument markdownDoc = null;
            HtmlDocument htmlDoc = null;          

            bool docType = false;
            //true == markdown, false == html

            foreach (var command in commands)
            {
                var strippedCommand = Regex.Replace(command, @"\t|\n|\r", "");
                var commandList = strippedCommand.Split(':');
                switch (commandList[0])
                {
                    case "Document":                        
                        var properties = commandList[1].Split(';');
                        //create document
                        //if properties[0] is "Markdown" make a markdown doc else make html
                        if(properties[0] == "Markdown")
                        {
                            docType = true;
                            markdownDoc = (MarkdownDocument)markdownFactory.CreateDocument(properties[1]);                            
                        }
                        else
                        {
                            docType = false;
                            htmlDoc = (HtmlDocument)htmlFactory.CreateDocument(properties[1]);
                        }
                        break;
                    case "Element":                            
                        if(docType) // markdown
                        {
                            markdownDoc.AddElement(markdownFactory.CreateElement(commandList[1], commandList[2]));
                        }
                        else //html
                        {
                            htmlDoc.AddElement(htmlFactory.CreateElement(commandList[1], commandList[2]));
                        }                        
                        break;
                    case "Run":
                        // Your document running code goes here
                        if(docType)
                        {
                            markdownDoc.RunDocument();
                        }
                        else
                        {
                            htmlDoc.RunDocument();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
