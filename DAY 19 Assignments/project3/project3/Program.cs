using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
//*****************************************************************
//Author: JEEVITHA
//Purpose: C# code to read xml file
//*****************************************************************

namespace project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\XML2\\Employees1.Xml");
            foreach (XmlNode Node in doc.DocumentElement.ChildNodes)
            {
                String text = Node.InnerText;
                Console.WriteLine(text);
            }
            Console.ReadLine();


        }

    }
}
