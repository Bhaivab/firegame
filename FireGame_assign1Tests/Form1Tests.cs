using Microsoft.VisualStudio.TestTools.UnitTesting;
using FireGame_assign1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGame_assign1.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            functionalTask functoinObejct = new functionalTask();
            functoinObejct.loadBullet();
            Assert.IsTrue(true);
        }


        [TestMethod()]
        public void Form2Test()
        {
            functionalTask functoinObejct = new functionalTask();
            Form1 obj = new Form1();
            functoinObejct.ClkStart(obj.btnStart);
            Assert.IsTrue(true);
        }


        [TestMethod()]
        public void Form3Test()
        {
            
        }

    }
}