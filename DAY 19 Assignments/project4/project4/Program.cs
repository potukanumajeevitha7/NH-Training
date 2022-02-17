using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
//*****************************************************************
//Author: JEEVITHA
//Purpose: Read Employee ID from user and write C# code to get
//the employee name from XML for this id
//******************************************************************

namespace project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ID Number:");
            int input = Convert.ToInt32(Console.ReadLine());

            XmlDocument file = new XmlDocument();
            file.Load("E:\\NBHTraining\\XML Files\\Employees.Xml");
            foreach(XmlNode node in file.DocumentElement.ChildNodes)
            {
                foreach(XmlNode node2 in node.ChildNodes)
                {
                    bool ID = node2.Name == "ID";
                    bool isIndex = (ID == true ? Convert.ToInt32(node2.InnerText) : 0) == input;
                    if (ID && isIndex)
                    {
                        Console.WriteLine($"The Name of the ID is {node2.NextSibling.InnerText}");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
