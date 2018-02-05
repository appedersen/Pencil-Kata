using System;
using Pillar_Pencil_Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class Eraser_Durability_Tests
    {
        [TestMethod]
        public void Eraser_With_Enough_Durability_Can_Erase_Whole_Phrase()
        {
            Pencil Pencil_instance = new Pencil(100,100,100);
            Pencil_instance.Write("This phrase will self destruct");
            Pencil_instance.Erase("self");
            Assert.AreEqual("This phrase will      destruct", Pencil_instance.Read_Paper());
        }

        [TestMethod]
        public void Eraser_Without_Enough_Durability_Will_Partially_Erase()
        {
            Pencil Pencil_instance = new Pencil(100, 100, 4);
            Pencil_instance.Write("Bookshelf");
            Pencil_instance.Erase("Bookshelf");
            Assert.AreEqual("Books    ", Pencil_instance.Read_Paper());
        }

        public void Eraser_With_No_Durability_Cannot_Erase()
        {
            Pencil Pencil_instance = new Pencil(100, 100, 0);
            Pencil_instance.Write("Sir Sam Vimes");
            Pencil_instance.Erase("Sir Sam Vimes");
            Assert.AreEqual("Sir Sam Vimes", Pencil_instance.Read_Paper());
        }

        public void Eraser_Durability_Persists_Through_Erases()
        {
            Pencil Pencil_instance = new Pencil(100, 100, 6);
            Pencil_instance.Write("I ran all night and day");
            Pencil_instance.Erase("day");
            Pencil_instance.Erase("and");
            Pencil_instance.Erase("night");
            Pencil_instance.Erase("all");
            Pencil_instance.Erase("ran");
            Pencil_instance.Erase("I");

            Assert.AreEqual("I ran all night        ", Pencil_instance.Read_Paper());
        }



    }
}
