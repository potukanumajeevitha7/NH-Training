using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_10_evening
{
    abstract class Salary
    {
        public int GetPF(int basic)
        {
            return 12 * basic / 100;
        }
        public int GetHRA(int basic)
        {
            return 40 * basic / 100;
        }
        public abstract int GetCA();
        public abstract int GetSA();
    }
    class microsoft : Salary
    {
        public override int GetCA()
        {
            return 25000;
        }
        public override int GetSA()
        {
            return 10000;
        }
    }
    class Google : Salary
    {
        public override int GetCA()
        {
            return 32000;
        }
        public override int GetSA()
        {
            return 56000;
        }
    }
    class IBM : Salary
    {
        public override int GetCA()
        {
            return 45000;
        }
        public override int GetSA()
        {
            return 50000;
        }
    }
    class facebook : Salary
    {
        public override int GetCA()
        {
            return 1000;
        }
        public override int GetSA()
        {
            return 3000;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //microsoft
            //Google
            //IBM
            //facebook
            Console.WriteLine("completed processing");
            Console.ReadLine();
        }
    }
}
