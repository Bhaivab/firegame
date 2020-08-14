using System;
using FireGame_assign1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FireGame_assign1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            functionalTask functoinObejct = new functionalTask();
            Form1 obj = new Form1();
            functoinObejct.ClkStart(obj.btnShoot);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestMethod2()
        {
            functionalTask functoinObejct = new functionalTask();
            Form1 obj = new Form1();
            functoinObejct.ClkStart(obj.btnSHootAway);
            Assert.IsTrue(true);
        }


    }
}
