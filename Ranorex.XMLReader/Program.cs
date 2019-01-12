using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Ranorex.XMLReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string elementName = "activity";

            XDocument xml = XDocument.Load("SampleReport.rxlog.data");
            List<XElement> elements = xml.Descendants(elementName).ToList();
            foreach (XElement element in elements)
            {
                Console.WriteLine(element.Value.Trim());
            }

            Console.Read();
        }
    }
}