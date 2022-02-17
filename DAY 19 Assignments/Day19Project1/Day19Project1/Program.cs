using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
//*************************************************************
//Author: JEEVITHA
//Purpose: C# code to read XML file and print the content 
         //from the file
//****************************************************************
namespace Day19Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("E:\\NBHTraining\\XML Files\\Employees.Xml");
            //XmlNode node = doc.DocumentElement.SelectSingleNode("/Products/Products");
            foreach (XmlNode Node in doc.DocumentElement.ChildNodes)
            {
                String text = Node.InnerText;
                Console.WriteLine(text);
            }
            Console.ReadLine();
        }
    }
}
