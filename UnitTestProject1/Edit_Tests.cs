using System;
using Pillar_Pencil_Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Edit_Tests
    {
        [TestMethod]
        public void Pencil_Can_Edit_With_Blank_Space()
        {
            Pencil Pencil_instance = new Pencil(100, 100, 100);
            Pencil_instance.Write("Wabbit Season");
            Pencil_instance.Erase("Wabbit");
            Pencil_instance.Edit("Duck");


            Assert.AreEqual("Duck   Season", Pencil_instance.Read_Paper());

        }

        [TestMethod]
        public void Pencil_Can_Edit_And_Collide_with_Text()
        {
            Pencil Pencil_instance = new Pencil(100, 100, 100);
            Pencil_instance.Write("I ran into a wall");
            Pencil_instance.Erase("ran");
            Pencil_instance.Edit("walked");


            Assert.AreEqual("I walk@@to a wall", Pencil_instance.Read_Paper());
        }

        [TestMethod]
        public void Pencil_Can_Edit_Past_Existing_Text()
        {
            Pencil Pencil_instance = new Pencil(100, 100, 100);
            Pencil_instance.Write("Mary had a big");
            Pencil_instance.Erase("big");
            Pencil_instance.Edit("little lamb");


            Assert.AreEqual("Mary had a little lamb", Pencil_instance.Read_Paper());

        }

    }
}
