namespace TextConsole
{
    partial class Form1
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
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_StegnographTextInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_EncryptedText = new System.Windows.Forms.TextBox();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_CoverText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_StegnographText = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(114, 30);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(226, 20);
            this.textBox_Input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Encrypted Text";
            // 
            // textBox_StegnographTextInput
            // 
            this.textBox_StegnographTextInput.Location = new System.Drawing.Point(352, 149);
            this.textBox_StegnographTextInput.Name = "textBox_StegnographTextInput";
            this.textBox_StegnographTextInput.Size = new System.Drawing.Size(226, 20);
            this.textBox_StegnographTextInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stegnograph Text Input";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // textBox_EncryptedText
            // 
            this.textBox_EncryptedText.Location = new System.Drawing.Point(114, 65);
            this.textBox_EncryptedText.Multiline = true;
            this.textBox_EncryptedText.Name = "textBox_EncryptedText";
            this.textBox_EncryptedText.ReadOnly = true;
            this.textBox_EncryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_EncryptedText.Size = new System.Drawing.Size(226, 44);
            this.textBox_EncryptedText.TabIndex = 9;
            // 
            // textBox_Output
            // 
            this.textBox_Output.Location = new System.Drawing.Point(352, 187);
            this.textBox_Output.Multiline = true;
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.ReadOnly = true;
            this.textBox_Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Output.Size = new System.Drawing.Size(226, 61);
            this.textBox_Output.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Output ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cover text";
            // 
            // textBox_CoverText
            // 
            this.textBox_CoverText.Location = new System.Drawing.Point(567, 30);
            this.textBox_CoverText.Name = "textBox_CoverText";
            this.textBox_CoverText.Size = new System.Drawing.Size(226, 20);
            this.textBox_CoverText.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Stegnograph Text";
            // 
            // textBox_StegnographText
            // 
            this.textBox_StegnographText.Location = new System.Drawing.Point(567, 65);
            this.textBox_StegnographText.Multiline = true;
            this.textBox_StegnographText.Name = "textBox_StegnographText";
            this.textBox_StegnographText.ReadOnly = true;
            this.textBox_StegnographText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_StegnographText.Size = new System.Drawing.Size(226, 44);
            this.textBox_StegnographText.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(816, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Stegnograph";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Stegnograph_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(816, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(906, 312);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox_StegnographText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_CoverText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Output);
            this.Controls.Add(this.textBox_EncryptedText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_StegnographTextInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //sffmka 


        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_StegnographTextInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_EncryptedText;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_CoverText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_StegnographText;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

