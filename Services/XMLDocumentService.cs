using GoodTeas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GoodTeas.Services
{
    /// <summary>
    /// The XMLDocumentService class deals with handling all XML Document
    /// functionality for the GoodTeas project.
    /// </summary>
    internal class XMLDocumentService
    {
        /// <summary>
        /// Reads in Tea data as a list from XML data file.
        /// </summary>
        /// <param name="xmlFilePath"></param>
        /// <returns>List of Tea objects</returns>
        public List<Tea> ReadInData(string xmlFilePath= "C:\\Users\\shelb\\source\\repos\\GoodTeas\\Resources\\GoodTeas.xml")
        {
            // 
            string name = string.Empty;
            string type = string.Empty;
            string caffeineContent = string.Empty;
            string steepTime = string.Empty;
            string waterTemperature = string.Empty;
            string notes = string.Empty;
            string rating = string.Empty;
            // Initialize the Return List
            List<Tea> teas = new List<Tea>();
            // Initialize the XMLDocument
            XmlDocument xmlDocument = new XmlDocument();
            // Load the XML data
            xmlDocument.Load(xmlFilePath);
            // Get the Root Node
            XmlElement root = xmlDocument.DocumentElement;
            // Get all the Teas
            foreach (XmlElement teaNode in root.ChildNodes)
            {
                foreach (XmlElement node in teaNode.ChildNodes)
                {
                    if (node.Name == "Name")
                    {
                        name = node.InnerText;
                    }
                    else if (node.Name == "Type")
                    {
                        type = node.InnerText;
                    }
                    else if (node.Name == "CaffeineContent")
                    {
                        caffeineContent = node.InnerText;
                    }
                    else if (node.Name == "SteepTime")
                    {
                        steepTime = node.InnerText;
                    }
                    else if (node.Name == "WaterTemperature")
                    {
                        waterTemperature = node.InnerText;
                    }
                    else if (node.Name == "Notes")
                    {
                        notes = node.InnerText;
                    }
                    else if (node.Name == "Rating")
                    {
                        rating = node.InnerText;
                    }
                }
                // Initialize the Tea instance
                Tea tea = new Tea(name, type, caffeineContent, steepTime, waterTemperature, notes, rating);
                // Add Tea to the List
                teas.Add(tea);
            }
            return teas;
        }
    }
}
