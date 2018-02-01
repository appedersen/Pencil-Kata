using System;
using System.Text;
using Pillar_Pencil_Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Sharpen_Tests
    {
        [TestMethod]
        public void Pencils_Can_Be_Sharpened()
        {

            Pencil Pencil_instance = new Pencil(6, 10);
            Pencil_instance.Write("Hello ");
            Pencil_instance.Sharpen();
            Pencil_instance.Write("World");

            Assert.AreEqual("Hello World", Pencil_instance.Read_Paper());
        }

        [TestMethod]
        public void Stubby_Pencils_Cannot_Be_Sharpened()
        {
            Pencil Pencil_instance = new Pencil(6, 2);
            Pencil_instance.Write("Hello ");
            Pencil_instance.Sharpen();
            Pencil_instance.Write("World ");
            Pencil_instance.Sharpen();
            Pencil_instance.Write("; ");

            Assert.AreEqual("Hello World   ", Pencil_instance.Read_Paper());


        }
    }
}
