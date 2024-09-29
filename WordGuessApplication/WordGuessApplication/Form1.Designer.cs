namespace WordGuessApplication
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
            this.txtBx_EnterGuessBox = new System.Windows.Forms.TextBox();
            this.bttn_Guess = new System.Windows.Forms.Button();
            this.bttn_displayGuesses = new System.Windows.Forms.Button();
            this.bttn_theWord = new System.Windows.Forms.Button();
            this.listBx_wrongGuessesBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtBx_EnterGuessBox
            // 
            this.txtBx_EnterGuessBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx_EnterGuessBox.Font = new System.Drawing.Font("Arial", 12F);
            this.txtBx_EnterGuessBox.Location = new System.Drawing.Point(59, 86);
            this.txtBx_EnterGuessBox.Multiline = true;
            this.txtBx_EnterGuessBox.Name = "txtBx_EnterGuessBox";
            this.txtBx_EnterGuessBox.Size = new System.Drawing.Size(239, 21);
            this.txtBx_EnterGuessBox.TabIndex = 2;
            this.txtBx_EnterGuessBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBx_EnterGuessBox.TextChanged += new System.EventHandler(this.txtBx_EnterGuessBox_TextChanged);
            // 
            // bttn_Guess
            // 
            this.bttn_Guess.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bttn_Guess.Font = new System.Drawing.Font("Arial", 12F);
            this.bttn_Guess.ForeColor = System.Drawing.Color.White;
            this.bttn_Guess.Location = new System.Drawing.Point(110, 112);
            this.bttn_Guess.Name = "bttn_Guess";
            this.bttn_Guess.Size = new System.Drawing.Size(129, 31);
            this.bttn_Guess.TabIndex = 3;
            this.bttn_Guess.Text = "Guess";
            this.bttn_Guess.UseVisualStyleBackColor = false;
            this.bttn_Guess.Click += new System.EventHandler(this.bttn_Guess_Click);
            // 
            // bttn_displayGuesses
            // 
            this.bttn_displayGuesses.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bttn_displayGuesses.Font = new System.Drawing.Font("Arial", 12F);
            this.bttn_displayGuesses.ForeColor = System.Drawing.Color.White;
            this.bttn_displayGuesses.Location = new System.Drawing.Point(355, 12);
            this.bttn_displayGuesses.Name = "bttn_displayGuesses";
            this.bttn_displayGuesses.Size = new System.Drawing.Size(156, 31);
            this.bttn_displayGuesses.TabIndex = 4;
            this.bttn_displayGuesses.Text = "Wrong guess";
            this.bttn_displayGuesses.UseVisualStyleBackColor = false;
            // 
            // bttn_theWord
            // 
            this.bttn_theWord.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bttn_theWord.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_theWord.ForeColor = System.Drawing.Color.White;
            this.bttn_theWord.Location = new System.Drawing.Point(12, 12);
            this.bttn_theWord.Name = "bttn_theWord";
            this.bttn_theWord.Size = new System.Drawing.Size(337, 70);
            this.bttn_theWord.TabIndex = 5;
            this.bttn_theWord.Text = "s?????????a";
            this.bttn_theWord.UseVisualStyleBackColor = false;
            this.bttn_theWord.Click += new System.EventHandler(this.bttn_theWord_Click);
            // 
            // listBx_wrongGuessesBox
            // 
            this.listBx_wrongGuessesBox.Font = new System.Drawing.Font("Arial", 12F);
            this.listBx_wrongGuessesBox.FormattingEnabled = true;
            this.listBx_wrongGuessesBox.ItemHeight = 18;
            this.listBx_wrongGuessesBox.Location = new System.Drawing.Point(355, 45);
            this.listBx_wrongGuessesBox.Name = "listBx_wrongGuessesBox";
            this.listBx_wrongGuessesBox.Size = new System.Drawing.Size(156, 112);
            this.listBx_wrongGuessesBox.TabIndex = 7;
            this.listBx_wrongGuessesBox.SelectedIndexChanged += new System.EventHandler(this.listBx_wrongGuessesBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 164);
            this.Controls.Add(this.listBx_wrongGuessesBox);
            this.Controls.Add(this.bttn_theWord);
            this.Controls.Add(this.bttn_displayGuesses);
            this.Controls.Add(this.bttn_Guess);
            this.Controls.Add(this.txtBx_EnterGuessBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Guess the Word";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBx_EnterGuessBox;
        private System.Windows.Forms.Button bttn_Guess;
        private System.Windows.Forms.Button bttn_displayGuesses;
        private System.Windows.Forms.Button bttn_theWord;
        private System.Windows.Forms.ListBox listBx_wrongGuessesBox;
    }
}

