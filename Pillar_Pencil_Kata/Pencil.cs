﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillar_Pencil_Kata
{
    public class Pencil
    {
        string Paper; //All that has been written is stored here 

        int Default_durability; //Could be long if really durable pencils are required
        int Current_durability;

        bool Durability_enabled; //The requirements said pencils _can_ have durability
                                 //so I am assuming that a pencil without a defined durability is
                                 //indestructible. In a real case I'd have this clarified. 
        int Pencil_Length; 
        public Pencil()
        {
            Paper = ""; //Brand new paper should be blank
            Durability_enabled = false;
        }

        public Pencil(int Initial_Durabiltiy) //We are provided 
        {
            Paper = "";
            Durability_enabled = true; //this pencil can be dulled
            Default_durability = Initial_Durabiltiy;
            Current_durability = Initial_Durabiltiy;
        }

        public Pencil(int Initial_Durabiltiy, int Initial_Length)
        {
            Paper = "";
            Durability_enabled = true; //this pencil can be dulled
            Default_durability = Initial_Durabiltiy;
            Current_durability = Initial_Durabiltiy;
            Pencil_Length = Initial_Length;

        }
        public void Erase(String Substring_to_be_erased)
        {
            int index_of_substring = -1;

            if (Substring_to_be_erased == "" || Paper == "")
            {
                return;
            }

            index_of_substring = Paper.LastIndexOf(Substring_to_be_erased);

            if(index_of_substring < 0)
            {
                return;
            }

            string erasedsection = new string(' ', Substring_to_be_erased.Length);

            string newpaper = Paper.Substring(0, index_of_substring);
            newpaper += erasedsection;
            newpaper += Paper.Substring(index_of_substring+Substring_to_be_erased.Length);
            Paper = newpaper;
            
        }


        public void Sharpen()
        {
            if(Durability_enabled && Pencil_Length > 1)
            {
                Current_durability = Default_durability;
                Pencil_Length--;
            }

        }

        public void Write(string Intended_Message)
        {


            if (Durability_enabled == false)
            {
                Paper += Intended_Message;
            }
            else
            {
                for(int Character_Postition = 0; Character_Postition < Intended_Message.Length; Character_Postition++)
                {
                    if(char.IsUpper(Intended_Message[Character_Postition]))
                    {
                        if(Current_durability >= 2)
                        {
                            Paper += Intended_Message[Character_Postition];
                            Current_durability -= 2;
                        }
                        else
                        {
                            Paper += " ";
                        }
                    }

                    else if(char.IsWhiteSpace(Intended_Message[Character_Postition]))
                    {
                        Paper += Intended_Message[Character_Postition];
                    }

                    else
                    {
                        if (Current_durability >= 1)
                        {
                            Paper += Intended_Message[Character_Postition];
                            Current_durability -= 1;
                        }
                        else
                        {
                            Paper += " ";
                        }
                    }


                }


            }
            return;
        }

        public string Read_Paper()
        {

            return Paper;
        }
    }
}
