using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillar_Pencil_Kata
{
    public class Pencil
    {
        string Paper; //All that has been written is stored here 



        public Pencil()
        {
            Paper = ""; //Brand new paper should be blank
        }

        public Pencil(int Durability)
        {
            
        }

        public void Write(string Intended_Message)
        {
            Paper += Intended_Message;
            return;
        }

        public string Read_Paper()
        {

            return Paper;
        }
    }
}
