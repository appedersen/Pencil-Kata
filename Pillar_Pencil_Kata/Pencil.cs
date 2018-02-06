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

        int Default_durability; //Could be long if really durable pencils are required
        int Current_durability;
        int Eraser_durability;

        int Index_of_Last_Erased_Segment;

        int Pencil_Length;

       
        public Pencil(int Initial_Durabiltiy, int Initial_Length, int Eraser_Initial_Durability)  //Overload for constructor, provided an initial durability and length
        {
            Paper = "";
            Default_durability = Initial_Durabiltiy;
            Current_durability = Initial_Durabiltiy;
            Pencil_Length = Initial_Length;
            Eraser_durability = Eraser_Initial_Durability;
            Index_of_Last_Erased_Segment = 0;

        }

        public void Edit(string Text_to_insert)
        {
            string Newly_Edited_Segment = Build_Edit_String(Text_to_insert);
            string Beginning_Segment = Paper.Substring(0, Index_of_Last_Erased_Segment);
            string Trailing_Segment = "";

            if (Index_of_Last_Erased_Segment + Text_to_insert.Length < Paper.Length)
            {
                Trailing_Segment = Paper.Substring(Index_of_Last_Erased_Segment + Text_to_insert.Length);
            }
            Paper = Rebuild_Paper(Beginning_Segment, Newly_Edited_Segment, Trailing_Segment);

            return;
        }

        private string Build_Edit_String(string Text_to_insert)
        {
            string Editted_Text = "";
            for (int i = 0; i < Text_to_insert.Length; i++)
            {
                if(Index_of_Last_Erased_Segment + i < Paper.Length)
                {
                    if(char.IsWhiteSpace(Paper[Index_of_Last_Erased_Segment + i]) || char.IsWhiteSpace(Text_to_insert[i]))
                    {
                        Editted_Text += Text_to_insert[i];
                    }
                    else
                    {
                        Editted_Text += "@";
                    }
                }
                else
                {
                    Editted_Text += Text_to_insert[i];
                }
            }
            return Editted_Text;
        }


        public void Erase(String Substring_to_be_erased)
        {
            int index_of_substring = -1;
            int Undeleted_Character_Count = 0;


            if (Substring_to_be_erased.Length > 0 && Paper.Length > 0)
            {
                index_of_substring = Paper.LastIndexOf(Substring_to_be_erased);

                if (Substring_to_be_erased.Length > Eraser_durability)
                {
                    Undeleted_Character_Count = Get_Count_Of_Undeleted_Characters_From_Partial_Erase(Substring_to_be_erased);
                }

                if (index_of_substring >= 0)
                {

                    int Erased_Char_Size = Substring_to_be_erased.Length;
                    Rebuild_Paper_For_Erase(index_of_substring, Undeleted_Character_Count, Erased_Char_Size);
                    
                }
            }

            return;
        }

        private void Rebuild_Paper_For_Erase(int Index_of_Erase_Start, int Undeleted_Character_Count, int Erased_Char_Size)
        {
            Index_of_Last_Erased_Segment = Index_of_Erase_Start;
            string Initial_Segment = Paper.Substring(0, Index_of_Erase_Start + Undeleted_Character_Count);
            string Modified_Segment = new string(' ', Erased_Char_Size - Undeleted_Character_Count);
            string Trailing_Segment = Paper.Substring(Index_of_Erase_Start + Erased_Char_Size);

            Paper = Rebuild_Paper(Initial_Segment, Modified_Segment, Trailing_Segment);
            Eraser_durability -= Erased_Char_Size - Undeleted_Character_Count;
            if (Eraser_durability < 0)
            {
                Eraser_durability = 0;
            }
        }

        private string Rebuild_Paper(string Initial_Segment, string Modified_Segment, string Trailing_Segment)
        {
            return Initial_Segment + Modified_Segment + Trailing_Segment;
        }

        public void Sharpen()
        {
            if(Pencil_Length > 1)
            {
                Current_durability = Default_durability;
                Pencil_Length--;
            }

        }

        public void Write(string Intended_Message)
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

        public string Read_Paper()
        {
            return Paper;
        }

        private int Get_Count_Of_Undeleted_Characters_From_Partial_Erase(string Substring_to_be_erased)
        {
            int Non_White_Space_Characters = 0;
            int Undeleted_Character_Count = Substring_to_be_erased.Length;

            for (int i = Substring_to_be_erased.Length - 1; i >= 0; i--)
            {
                if (Non_White_Space_Characters < Eraser_durability)
                {
                    if (Char.IsWhiteSpace(Substring_to_be_erased[i]) == false)
                    {
                        Non_White_Space_Characters++;
                    }
                    Undeleted_Character_Count--;
                }
            }
            return Undeleted_Character_Count;
        }


    }
}
