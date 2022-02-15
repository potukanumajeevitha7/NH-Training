using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*******************************************************
  //  Author: JEEVITHA
    //Purpose:access the modifiers within assembly
//**************************************************************
namespace johneyLibrary
{
    public class MyBaseClass
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;
        //********WITHIN CLASS**********
        public void MyBaseClassMethod()
        {
            
            a = 1;
            b = 2;
            c = 3;
            d = 4;  
            e = 5;
            
        }
    }
    public class MyDerivedClass : MyBaseClass
    {
        //************DERIVED CLASS**************
        public void MyDerivedClassMethod()
        {
            
            a = 1;
            b = 2;
            c = 3;
            d = 4;
            e = 5;
            
        }
    }
    public class MyOtherClass
    {
        //***********OTHER CLASS**************
        public void MyOtherClassMethod()
        {
            MyBaseClass mb =new MyBaseClass();
            
            mb.a = 1;
            mb.b = 2;
            mb.c = 3;
            mb.d = 4;
            mb.e = 5;
            
        }
    }
}
