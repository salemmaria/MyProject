using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {

        private StringBuilder word = new StringBuilder("lol");

        public Form1()
        {
            InitializeComponent();
        }

        private void txtBx_EnterGuessBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttn_Guess_Click(object sender, EventArgs e)
        {
            string message;
            bool isCorrect = word.ToString().Contains(txtBx_EnterGuessBox.Text);

            if (isCorrect)
            {
                message = "Correct guess!";
                bttn_theWord.Text = "lol";
                MessageBox.Show(message);

                txtBx_EnterGuessBox.Clear();
            }
            else
            {
                string incorrect_guess = txtBx_EnterGuessBox.Text;
                listBx_wrongGuessesBox.Items.Add(incorrect_guess);
            }

            word.Replace(word.ToString(), "synesthesia");
        }

        private void txtBx_wrongGuessBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Word Guessing Game! Click OK to proceed.");
            MessageBox.Show("MAOT MOG NAWNG TANAN");
            MessageBox.Show("kapoy");
            MessageBox.Show("di nako");
        }

        private void bttn_theWord_Click(object sender, EventArgs e)
        {

        }

        private void listBx_wrongGuessesBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}