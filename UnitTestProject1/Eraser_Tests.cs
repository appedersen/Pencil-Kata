using System;
using System.Text;
using Pillar_Pencil_Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Eraser_Tests
    {
        [TestMethod]
        public void Pencil_Can_Erase_A_Single_Word()
        {
            Pencil Pencil_instance = new Pencil();
            Pencil_instance.Write("I played a bad game of baseball.");
            Pencil_instance.Erase("bad");
            Assert.AreEqual("I played a     game of baseball.", Pencil_instance.Read_Paper());
        }

        [TestMethod]
        public void Pencil_Can_Erase_Multiple_Words()
        {
            Pencil Pencil_instance = new Pencil();
            Pencil_instance.Write("I played a bad game of baseball.");
            Pencil_instance.Erase("of baseball.");
            Assert.AreEqual("I played a bad game             ", Pencil_instance.Read_Paper());
        }

        [TestMethod]
        public void Pencil_Can_Erase_The_Same_Word_Multiple_Times()
        {
            Pencil Pencil_instance = new Pencil();
            Pencil_instance.Write("The red house with a red gate was red.");
            Pencil_instance.Erase("red");
            Pencil_instance.Erase("red");
            Assert.AreEqual("The red house with a     gate was    .", Pencil_instance.Read_Paper());
        }
    }
}
