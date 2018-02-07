namespace Pencil_Demonstration_Program
{
    partial class Pencil_Kata_Demo_Program
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Pencil_Paper_Textbox = new System.Windows.Forms.TextBox();
            this.CommandButton_Write = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.CommandButton_Erase = new System.Windows.Forms.RadioButton();
            this.CommandButton_Edit = new System.Windows.Forms.RadioButton();
            this.Input_Textbox = new System.Windows.Forms.TextBox();
            this.Sharpen_Button = new System.Windows.Forms.Button();
            this.Sharpness_Label = new System.Windows.Forms.Label();
            this.Length_Label = new System.Windows.Forms.Label();
            this.Eraser_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paper ";
            // 
            // Pencil_Paper_Textbox
            // 
            this.Pencil_Paper_Textbox.Location = new System.Drawing.Point(12, 25);
            this.Pencil_Paper_Textbox.Multiline = true;
            this.Pencil_Paper_Textbox.Name = "Pencil_Paper_Textbox";
            this.Pencil_Paper_Textbox.ReadOnly = true;
            this.Pencil_Paper_Textbox.Size = new System.Drawing.Size(293, 217);
            this.Pencil_Paper_Textbox.TabIndex = 1;
            // 
            // CommandButton_Write
            // 
            this.CommandButton_Write.AutoSize = true;
            this.CommandButton_Write.Checked = true;
            this.CommandButton_Write.Cursor = System.Windows.Forms.Cursors.Default;
            this.CommandButton_Write.Location = new System.Drawing.Point(311, 41);
            this.CommandButton_Write.Name = "CommandButton_Write";
            this.CommandButton_Write.Size = new System.Drawing.Size(50, 17);
            this.CommandButton_Write.TabIndex = 2;
            this.CommandButton_Write.TabStop = true;
            this.CommandButton_Write.Text = "Write";
            this.CommandButton_Write.UseVisualStyleBackColor = true;
            this.CommandButton_Write.CheckedChanged += new System.EventHandler(this.CommandButton_Write_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Command";
            // 
            // CommandButton_Erase
            // 
            this.CommandButton_Erase.AutoSize = true;
            this.CommandButton_Erase.Cursor = System.Windows.Forms.Cursors.Default;
            this.CommandButton_Erase.Location = new System.Drawing.Point(311, 64);
            this.CommandButton_Erase.Name = "CommandButton_Erase";
            this.CommandButton_Erase.Size = new System.Drawing.Size(52, 17);
            this.CommandButton_Erase.TabIndex = 4;
            this.CommandButton_Erase.Text = "Erase";
            this.CommandButton_Erase.UseVisualStyleBackColor = true;
            this.CommandButton_Erase.CheckedChanged += new System.EventHandler(this.CommandButton_Erase_CheckedChanged);
            // 
            // CommandButton_Edit
            // 
            this.CommandButton_Edit.AutoSize = true;
            this.CommandButton_Edit.Cursor = System.Windows.Forms.Cursors.Default;
            this.CommandButton_Edit.Location = new System.Drawing.Point(311, 87);
            this.CommandButton_Edit.Name = "CommandButton_Edit";
            this.CommandButton_Edit.Size = new System.Drawing.Size(43, 17);
            this.CommandButton_Edit.TabIndex = 5;
            this.CommandButton_Edit.Text = "Edit";
            this.CommandButton_Edit.UseVisualStyleBackColor = true;
            this.CommandButton_Edit.CheckedChanged += new System.EventHandler(this.CommandButton_Edit_CheckedChanged);
            // 
            // Input_Textbox
            // 
            this.Input_Textbox.Location = new System.Drawing.Point(12, 248);
            this.Input_Textbox.Name = "Input_Textbox";
            this.Input_Textbox.Size = new System.Drawing.Size(293, 20);
            this.Input_Textbox.TabIndex = 7;
            this.Input_Textbox.TextChanged += new System.EventHandler(this.Input_Textbox_TextChanged);
            // 
            // Sharpen_Button
            // 
            this.Sharpen_Button.Location = new System.Drawing.Point(311, 110);
            this.Sharpen_Button.Name = "Sharpen_Button";
            this.Sharpen_Button.Size = new System.Drawing.Size(71, 23);
            this.Sharpen_Button.TabIndex = 8;
            this.Sharpen_Button.Text = "Sharpen";
            this.Sharpen_Button.UseVisualStyleBackColor = true;
            this.Sharpen_Button.Click += new System.EventHandler(this.Sharpen_Button_Click);
            // 
            // Sharpness_Label
            // 
            this.Sharpness_Label.AutoSize = true;
            this.Sharpness_Label.Location = new System.Drawing.Point(311, 136);
            this.Sharpness_Label.Name = "Sharpness_Label";
            this.Sharpness_Label.Size = new System.Drawing.Size(35, 13);
            this.Sharpness_Label.TabIndex = 9;
            this.Sharpness_Label.Text = "label3";
            // 
            // Length_Label
            // 
            this.Length_Label.AutoSize = true;
            this.Length_Label.Location = new System.Drawing.Point(311, 161);
            this.Length_Label.Name = "Length_Label";
            this.Length_Label.Size = new System.Drawing.Size(35, 13);
            this.Length_Label.TabIndex = 10;
            this.Length_Label.Text = "label3";
            // 
            // Eraser_Label
            // 
            this.Eraser_Label.AutoSize = true;
            this.Eraser_Label.Location = new System.Drawing.Point(311, 185);
            this.Eraser_Label.Name = "Eraser_Label";
            this.Eraser_Label.Size = new System.Drawing.Size(35, 13);
            this.Eraser_Label.TabIndex = 11;
            this.Eraser_Label.Text = "label3";
            // 
            // Pencil_Kata_Demo_Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 297);
            this.Controls.Add(this.Eraser_Label);
            this.Controls.Add(this.Length_Label);
            this.Controls.Add(this.Sharpness_Label);
            this.Controls.Add(this.Sharpen_Button);
            this.Controls.Add(this.Input_Textbox);
            this.Controls.Add(this.CommandButton_Edit);
            this.Controls.Add(this.CommandButton_Erase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CommandButton_Write);
            this.Controls.Add(this.Pencil_Paper_Textbox);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(474, 336);
            this.MinimumSize = new System.Drawing.Size(474, 336);
            this.Name = "Pencil_Kata_Demo_Program";
            this.Text = "Pencil Kata Demo Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pencil_Paper_Textbox;
        private System.Windows.Forms.RadioButton CommandButton_Write;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton CommandButton_Erase;
        private System.Windows.Forms.RadioButton CommandButton_Edit;
        private System.Windows.Forms.TextBox Input_Textbox;
        private System.Windows.Forms.Button Sharpen_Button;
        private System.Windows.Forms.Label Sharpness_Label;
        private System.Windows.Forms.Label Length_Label;
        private System.Windows.Forms.Label Eraser_Label;
    }
}

