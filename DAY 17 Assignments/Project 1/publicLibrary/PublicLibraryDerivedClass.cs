using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using johneyLibrary;
//************************************************************
  //  Author: JEEVITHA
    //Purpose: access the modifiers OTHER ASSEMBLY
//***************************************************************
namespace publicLibrary
{
    public class PublicLibraryDerivedClass : MyBaseClass
    {
        //***********DERIVED CLASS************
        public void PublicLibraryDerivedClassMethod()
        {
            a = 1;
            b=2;
            c=3;
            d=4;
            e=5;
        }
    }
    public class PublicLibraryOtherClass
    {
        //*************OTHER CLASS***************
        public void PublicLibraryOtherClassMethod()
        {
            MyBaseClass mb = new MyBaseClass();
            mb.a = 1;
            mb.b = 2;
            mb.c = 3;
            mb.d = 4;
            mb.e = 5;

        }
    }
}
