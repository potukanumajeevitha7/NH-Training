using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
//************************************************************************************
//Author: JEEVITHA
  //  Purpose: C# code to read xml file and print only employee names from the xml
//************************************************************************************
namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("E:\\NBHTraining\\XML Files\\Employees.Xml");
            foreach (XmlNode Node in doc.DocumentElement.ChildNodes)
            {
                foreach(XmlNode cnode in Node.ChildNodes)
                {
                    if (cnode.Name =="Name")
                    {
                        Console.WriteLine(cnode.InnerText);
                    }
                }
            
            }
            Console.ReadLine();
        }
    }
}
