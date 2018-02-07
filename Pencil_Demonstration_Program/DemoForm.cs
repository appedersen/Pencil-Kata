using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pillar_Pencil_Kata;

namespace Pencil_Demonstration_Program
{
    public partial class Pencil_Kata_Demo_Program : Form
    {
        enum CommandType
        {
            Write,
            Delete,
            Edit,
            Sharpen
        };

        CommandType CurrentCommand;
        Pencil Pencil_Instance = new Pencil(50, 10, 100);

        public Pencil_Kata_Demo_Program()
        {
            InitializeComponent();
            CurrentCommand = CommandType.Write;

            this.Input_Textbox.KeyDown += Entered_Command;
            Update_Labels_and_Text();
        }


        

        private void Entered_Command(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                if(CurrentCommand == CommandType.Write)
                {
                    Pencil_Instance.Write(this.Input_Textbox.Text);
                }

                else if (CurrentCommand == CommandType.Delete)
                {
                    Pencil_Instance.Erase(this.Input_Textbox.Text);
                }

                else if (CurrentCommand == CommandType.Edit)
                {
                    Pencil_Instance.Edit(this.Input_Textbox.Text);
                }

                else if (CurrentCommand == CommandType.Sharpen)
                {
                    Pencil_Instance.Sharpen();
                }


                Update_Labels_and_Text();
                this.Input_Textbox.Text = "";


            }

            return;
            
        }

        private void Input_Textbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CommandButton_Write_CheckedChanged(object sender, EventArgs e)
        {
            CurrentCommand = CommandType.Write;
        }

        private void CommandButton_Erase_CheckedChanged(object sender, EventArgs e)
        {
            CurrentCommand = CommandType.Delete;
        }

        private void CommandButton_Edit_CheckedChanged(object sender, EventArgs e)
        {
            CurrentCommand = CommandType.Edit;
        }

        private void CommandButton_Sharpen_CheckedChanged(object sender, EventArgs e)
        {
            CurrentCommand = CommandType.Sharpen;

        }

        private void Sharpen_Button_Click(object sender, EventArgs e)
        {
            Pencil_Instance.Sharpen();
            Update_Labels_and_Text();
        }

        private void Update_Labels_and_Text()
        {
            this.Pencil_Paper_Textbox.Text = Pencil_Instance.Read_Paper();

            this.Sharpness_Label.Text = "Pencil Sharpness: " + Pencil_Instance.Get_Pencil_Durability().ToString();
            this.Length_Label.Text = "Pencil Length: " + Pencil_Instance.Get_Pencil_Length().ToString();
            this.Eraser_Label.Text = "Eraser Durability: " + Pencil_Instance.Get_Pencil_Eraser_Durability().ToString();

        }
    }
}
