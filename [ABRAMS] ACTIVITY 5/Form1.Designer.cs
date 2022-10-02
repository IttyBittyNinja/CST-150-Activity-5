namespace _ABRAMS__ACTIVITY_5
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.filePathInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstWord = new System.Windows.Forms.TextBox();
            this.lastWord = new System.Windows.Forms.TextBox();
            this.vowelWord = new System.Windows.Forms.TextBox();
            this.wordListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filePathInput
            // 
            this.filePathInput.Location = new System.Drawing.Point(81, 0);
            this.filePathInput.Name = "filePathInput";
            this.filePathInput.Size = new System.Drawing.Size(308, 22);
            this.filePathInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Words In Lower-case";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Word (Alphabetically)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Word (Alphabetically)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Word With Most Vowels";
            // 
            // firstWord
            // 
            this.firstWord.Location = new System.Drawing.Point(182, 183);
            this.firstWord.Name = "firstWord";
            this.firstWord.Size = new System.Drawing.Size(207, 22);
            this.firstWord.TabIndex = 6;
            // 
            // lastWord
            // 
            this.lastWord.Location = new System.Drawing.Point(182, 217);
            this.lastWord.Name = "lastWord";
            this.lastWord.Size = new System.Drawing.Size(207, 22);
            this.lastWord.TabIndex = 7;
            // 
            // vowelWord
            // 
            this.vowelWord.Location = new System.Drawing.Point(182, 246);
            this.vowelWord.Name = "vowelWord";
            this.vowelWord.Size = new System.Drawing.Size(207, 22);
            this.vowelWord.TabIndex = 8;
            // 
            // wordListBox
            // 
            this.wordListBox.FormattingEnabled = true;
            this.wordListBox.ItemHeight = 16;
            this.wordListBox.Location = new System.Drawing.Point(182, 44);
            this.wordListBox.Name = "wordListBox";
            this.wordListBox.Size = new System.Drawing.Size(207, 116);
            this.wordListBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 279);
            this.Controls.Add(this.wordListBox);
            this.Controls.Add(this.vowelWord);
            this.Controls.Add(this.lastWord);
            this.Controls.Add(this.firstWord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePathInput);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Word Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox filePathInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstWord;
        private System.Windows.Forms.TextBox lastWord;
        private System.Windows.Forms.TextBox vowelWord;
        private System.Windows.Forms.ListBox wordListBox;
    }
}

