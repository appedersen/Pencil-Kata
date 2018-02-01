using System;
using System.Text;
using Pillar_Pencil_Kata;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class Pencil_Test_
    {
        [TestMethod]
        public void Pencil_Can_Write()
        {
            Pencil Pencil_instance = new Pencil();
            Pencil_instance.Write("Dear Santa");
            Assert.AreEqual("Dear Santa", Pencil_instance.Read_Paper());
        }
        [TestMethod]
        public void Pencil_Can_Write_Multiple_Times()
        {
            Pencil Pencil_instance = new Pencil();

            Pencil_instance.Write("She sells seashells");
            Pencil_instance.Write(" down by the seashore");

            Assert.AreEqual("She sells seashells down by the seashore", Pencil_instance.Read_Paper());

        }
        [TestMethod]
        public void Pencil_Can_Have_Writers_Block()
        {
            Pencil Pencil_instance = new Pencil();

            Pencil_instance.Write("");

            Assert.AreEqual("", Pencil_instance.Read_Paper());

        }
        [TestMethod]
        public void Paper_Should_Be_Pristine_If_Not_Written_To()
        {
            Pencil Pencil_instance = new Pencil();
            Assert.AreEqual("", Pencil_instance.Read_Paper()); 

        }
    }
}
