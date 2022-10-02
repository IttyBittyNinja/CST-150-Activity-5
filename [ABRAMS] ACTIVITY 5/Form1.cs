using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ABRAMS__ACTIVITY_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            StreamWriter outputFile;

            if (openFile.ShowDialog() == DialogResult.OK) // Open the selected file
            {
                filePathInput.Text = openFile.FileName; // Display file directory in textbox
                inputFile = new StreamReader(openFile.FileName); // Set input file to selected file path
                outputFile = File.CreateText("Output.txt"); // Create output file
                wordListBox.Items.Clear(); // Clear anything currently in the ListBox
                
                string wordList; // Current word being read from file
                string firstWordSort = "z"; // First word alphabetically
                string lastWordSort = "a"; // Last word alphabetically
                string vowelWordSort = ""; // Word with most vowels
                int vowelCountFinal = 0; // Vowel counter

                while (!inputFile.EndOfStream)
                {
                    wordList = inputFile.ReadLine(); // Get word from file list
                    
                    wordListBox.Items.Add(wordList.ToLower()); // print word to textbox in lower-case
                    outputFile.WriteLine(wordList.ToLower());


                    if (String.Compare(wordList.ToLower(), firstWordSort.ToLower()) < 0) // Compare to strings to find the first word alphabetically
                    {
                        firstWordSort = wordList;
                    }
                    firstWord.Text = firstWordSort; // Print first word to textbox
                    

                    if (String.Compare(wordList.ToLower(), lastWordSort.ToLower()) > 0) // Compare to strings to find the last word alphabetically
                    {
                        lastWordSort = wordList;
                    }
                    lastWord.Text = lastWordSort; // Print last word to textbox
                    

                    int vowelCount = 0; // vowel counter for for-loop
                    for (int i = 0; i < wordList.Length; i++) // for-loop based on length of word
                    {
                        if (wordList.ToLower()[i] == 'a' || wordList.ToLower()[i] == 'e' || wordList.ToLower()[i] == 'i' || wordList.ToLower()[i] == 'o' || wordList.ToLower()[i] == 'u') // If the current character is a vowel
                        {
                            vowelCount++; // increment if a vowel exists
                        }
                    }
                    if (vowelCount > vowelCountFinal) // If the current word has more vowels than the previous word
                    {
                        vowelCountFinal = vowelCount; // Vowel counter is raised
                        vowelWordSort = wordList; // Word with most vowels is assigned
                    }
                    vowelWord.Text = vowelWordSort; // Print word with most vowels to textbox

                    

                    
                }
                

                outputFile.WriteLine("First word alphabetically:");
                outputFile.WriteLine(firstWordSort);

                outputFile.WriteLine("Last word alphabetically:");
                outputFile.WriteLine(lastWordSort);

                outputFile.WriteLine("Word with most vowels:");
                outputFile.WriteLine(vowelWordSort);
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("No file selected.");
            }
        }
    }
}
