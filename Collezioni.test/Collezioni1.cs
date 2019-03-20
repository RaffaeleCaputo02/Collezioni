using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Collezioni.test
{
    [TestClass]
    public class Collezioni1
    {
        [TestMethod]
        public void TestVariabili()
        {
            int a = 2;
            int b = a;

            Assert.AreEqual(a, b);

        }

        [TestMethod]
        public void TestArray()
        {
            int[] c = { 1, 2, 3, 4};
            int [] d = c;
            Assert.AreEqual(c, d);

        }

        [TestMethod]
        public void TestArray1()
        {
            int[] e = { 1, 2, 3, 4};
            int[] f = { 1, 2, 3, 4};
            CollectionAssert.AreEqual(e, f);

        }

        [TestMethod]
        public void TestArray2()
        {
            int[] a = { 1, 2, 3, 4 };
            int[] asp = {11,12,13,14};
            
            int[]incremento=Collezioni.Incremento(a);
            CollectionAssert.AreEqual(asp, incremento);


        }
    }
}
