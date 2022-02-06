using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_10_evening_example
{
    abstract class College
    {
        public string CollegeName()
        {
            return "VIT";
        }
        public string CollegeLocation()
        {
            return "MADANAPALLI" ;
        }
        public abstract int StudentID();
        public abstract string StudentName();
    }
    class EEE : College
    {
        public override int StudentID()
        {
            return 1;
        }
        public override string StudentName()
        {
            return "john";
        }
    }
    class ECE : College
    {
        public override int StudentID()
       
        {
            return 2;
        }
        public override string StudentName()
        {
            return "jeevitha";
        }
    }
    class MECH : College
    {
        public override int StudentID()
        {
            return 3;
        }
        public override string StudentName()
        {
            return "mouni" ;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Details Entered Successfully");
            Console.ReadLine();
        }
    }
}
