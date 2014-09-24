using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testApp
{
    public partial class Form1 : Form
    {
        int secret;
        int attempt;
        MyGuessRef.ServiceClient myguess = new MyGuessRef.ServiceClient();  //get proxy of service
        public Form1()
        {
            InitializeComponent();
            
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            
            Int32 low = Convert.ToInt32(lowerTxt.Text);
            Int32 Up = Convert.ToInt32(UpperTxt.Text);
            secret = myguess.SecretNumber(low, Up);
            attempt = 0;
            AttemptLbl.Text = "Attempts " + Convert.ToString(attempt);  
            MessageBox.Show("Secret Num has been generated");
        }

        private void GuessBtn_Click(object sender, EventArgs e)
        {
            attempt ++;
            AttemptLbl.Text = "Attempts " + Convert.ToString(attempt);
            Int32 gus = Convert.ToInt32(GuessTxt.Text);
            string ans = myguess.checkNumber(gus, secret);
            NumIsLbl.Text = "The Num is" + ans;
        }
    }
}
