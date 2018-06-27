using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncryptDecrypt;

namespace TextConsole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EncryptDecryptClass encdec = new EncryptDecryptClass();
        Label l = new Label();

        /// <summary>
        /// This function encrypts the input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Encrypt_Click(object sender, EventArgs e)
        {
            textBox_EncryptedText.Text = "";
            textBox_CoverText.Text = "";
            l.Text = "";
            string input = textBox_Input.Text; // User entered input string
            if (input != string.Empty)
            {
                string encryptedString = encdec.EncryptInput(input); //Encryption Function 
                textBox_EncryptedText.Text = encryptedString;
                int numberofchars = encryptedString.Length;
                int numberofwords = 1 + (8 * numberofchars); //Number of words required to hide this text.
                textBox_CoverText.Text = "Enter " + numberofwords.ToString() + " words here";
                l.Text = numberofwords.ToString();
                l.Hide();
            }
            else
            {
                textBox_EncryptedText.Text = "Error: Please enter an input";
            }
        }

        /// <summary>
        /// This function recovers the hidden string in the input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Decrypt_Click(object sender, EventArgs e)
        {
            textBox_Output.Text = "";
            string input = textBox_StegnographTextInput.Text; //String with hidden text
            if (input != string.Empty)
            {
                string stringToDecodeFromSentence = encdec.decodstenograph(input, l.Text); //Recover encrypted string
                string output = encdec.DecryptInput(stringToDecodeFromSentence); //Recover original message
                textBox_Output.Text = output;
            }
            else
            {
                textBox_Output.Text = "Error: Please enter stenograph text input";
            }
        }

        /// <summary>
        /// This method changes number of spaces between words in cover text besed on ascii value of characterts in encrypted string.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stegnograph_Click(object sender, EventArgs e)
        {
            textBox_StegnographText.Text = "";
            string covertext = textBox_CoverText.Text; //Input cover text where string will be hidden
            if (covertext != string.Empty) { 
                string output = string.Empty;
                //List<string> output = new List<string>();
                string[] arr = covertext.Split(' '); // split words based on space
                int numberofwords = Convert.ToInt32(l.Text); //Min number of words needed
                string hidetext = textBox_EncryptedText.Text;
                StringBuilder chararray = new StringBuilder(hidetext); //Convert text to hide into a char array
                int j = 0;

                // validation check to verify min required words are entered
                if (numberofwords <= arr.Length)
                {
                    //output = output + arr[j];
                    //j++;

                    //Process each char in text to be hidden
                    for (int i = 0; i < chararray.Length; i++)
                    {
                        string binary = Convert.ToString(chararray[i], 2).PadLeft(8, '0'); //Conver char ascii value to 8 bit binary value
                        StringBuilder bin = new StringBuilder(binary); // Binary string to array

                        //this loop appends number of spaces to words in cover text based on 0 and 1 in binary array
                        for (int k = 0; k < bin.Length; k++)
                        {
                            if (bin[k] == '1')
                            {
                                output = output + arr[j] + " ";
                            }
                            else
                            {
                                output = output + arr[j] + "  ";
                            }
                            j++;
                        }
                    }

                    if (numberofwords == arr.Length)
                        output = output + arr[arr.Length - 1];
                    else
                    {
                        while (j < arr.Length)
                        {
                            output = output + arr[j] + " ";
                            j++;
                        }
                    }
                }
                else
                {
                    output = ((numberofwords - arr.Length) > 1 ? "Error: Please enter " + (numberofwords - arr.Length) + " more words." :
                        "Error: Please enter " + (numberofwords - arr.Length) + " more word.");
                }
                textBox_StegnographText.Text = output;
            }
            else
            {
                textBox_StegnographText.Text = "Error: Please enter cover text input";
            }
        }

        /// <summary>
        /// This function resets application and clears all the fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset_Click(object sender, EventArgs e)
        {
            textBox_Input.Text = string.Empty;
            textBox_StegnographTextInput.Text = string.Empty;
            textBox_EncryptedText.Text = string.Empty;
            textBox_Output.Text = string.Empty;
            textBox_CoverText.Text = string.Empty;
            textBox_StegnographText.Text = string.Empty;
        }        
    }
}
