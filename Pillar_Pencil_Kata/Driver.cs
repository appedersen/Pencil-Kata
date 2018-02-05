using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pillar_Pencil_Kata
{
    class Driver
    {
        static void Main(string[] args)
        {
            //Driver doesn't do anything, we're testing the Pencil object specifically.
            //Driver just asks for key input and then closes.
            Pencil Pencil_instance = new Pencil(100, 100, 11);
            Pencil_instance.Write("I ran all night and day");
            Pencil_instance.Erase("night and day"); 

            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }
    }
}
