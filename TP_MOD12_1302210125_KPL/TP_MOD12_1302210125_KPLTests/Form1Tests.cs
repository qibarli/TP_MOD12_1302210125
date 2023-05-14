using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_MOD12_1302210125_KPL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MOD12_1302210125_KPL.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Form1 test = new Form1();
            int input = 5;
            test.CariTandaBilangan(input);
        }
    }
}