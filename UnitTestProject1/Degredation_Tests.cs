using System;
using System.Text;
using Pillar_Pencil_Kata;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Degredation_Tests
    {
        [TestMethod]
        public void Pencils_Can_Write_Full_Line_If_Durability_Allows()
        {
            Pencil Pencil_instance = new Pencil(1000,100,100);
            Pencil_instance.Write("There is no better programmer than Andrew, except everyone else");
            Assert.AreEqual("There is no better programmer than Andrew, except everyone else", Pencil_instance.Read_Paper());
        }

        [TestMethod]
        public void Pencils_Can_Not_Write_Full_Line_If_Durability_Is_Low()
        {
            Pencil Pencil_instance = new Pencil(37,100,100);
            Pencil_instance.Write("There is no better programmer than Andrew, except everyone else");
            Assert.AreEqual("There is no better programmer than Andrew                      ", Pencil_instance.Read_Paper());
        }

        [TestMethod]
        public void Dull_Tips_Cannot_Write()
        {
            Pencil Pencil_instance = new Pencil(0,100,100);
            Pencil_instance.Write("Writing");
            Assert.AreEqual("       ", Pencil_instance.Read_Paper());
        }

        [TestMethod]
        public void Newly_Dull_Tips_Cannot_Write()
        {
            Pencil Pencil_instance = new Pencil(8,100,100);
            Pencil_instance.Write("Writing is hard");
            Assert.AreEqual("Writing        ", Pencil_instance.Read_Paper());
        }

        [TestMethod]
        public void Newly_Dull_Tips_Cannot_Write_A_New_Line()
        {
            Pencil Pencil_instance = new Pencil(8,100,100);
            Pencil_instance.Write("Writing");
            Pencil_instance.Write(" is hard");
            Assert.AreEqual("Writing        ", Pencil_instance.Read_Paper());
        }

    }
}
