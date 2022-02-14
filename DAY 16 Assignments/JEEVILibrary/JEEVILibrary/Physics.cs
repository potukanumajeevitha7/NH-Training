using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***********************************************************
  //  Author: JEEVITHA
    //Purpose: create a class library with Physics class
//***********************************************************
namespace JEEVILibrary
{
    public class Physics
    {
        public int FinalVelocity(int u, int a, int t)
        {
            return u + a * t;
        }
    }
}
