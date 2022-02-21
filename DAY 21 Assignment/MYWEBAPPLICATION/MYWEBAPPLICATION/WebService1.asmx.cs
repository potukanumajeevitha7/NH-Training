﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
//***********************************************************
//Author: JEEVITHA
//Purpose: Create web service for mathematical operation
//         Factorial, Add, Mul, Div
//************************************************************

namespace MYWEBAPPLICATION
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public int Factorial(int n)
        {
            int fact = 1, i;
            for (i = 1; i <= n; i++)
            fact = fact * i;
            return fact;
        }

        [WebMethod]

        public int Add(int a, int b)
        {
            return a + b;
        }

        [WebMethod]
        public int Mul(int a, int b)
        {
            return a*b;
        }

        [WebMethod]
        public int Div(int a, int b)
        {
            return a/b;
        }
    }
}
