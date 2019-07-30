using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;


namespace Hash_Checker
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();


        }
        

        static String MD5Check(String filePath)
        {
            try
            {
                using (var md5 = MD5.Create())
                {
                    using (var openFile = File.OpenRead(filePath))
                    {
                        var hash = md5.ComputeHash(openFile);
                        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
            }
            catch (InvalidCastException e)
            {
                //runs if the code is unable to create an MD5 hash.
                MessageBox.Show("Unable to calculate MD5");
                return "";
            }
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            //Assigns all the text boxes on the form to variables.
            string newHash = "0123456789ABCDEF";
            string OriginalHash = txtOriginalHash.Text;
            string filePath = txtFilePath.Text;

            if (cmbAlgorithm.Text == "MD5")
            {
                //Runs the function for creating an MD5 for the file selected.
                newHash = MD5Check(filePath);
            }
            else if (cmbAlgorithm.Text == "SHA-1")
            {
                MessageBox.Show("Algorithm not supported yet");
                return;
            }
            else if (cmbAlgorithm.Text == "SHA-2")
            {
                MessageBox.Show("Algorithm not supported yet");
                return;
            }
            else if (cmbAlgorithm.Text == "SHA-256")
            {
                MessageBox.Show("Algorithm not supported yet");
                return;
            }
            else if (cmbAlgorithm.Text == "SHA-512")
            {
                MessageBox.Show("Algorithm not supported yet");
                return;
            }

            //Displays the hash made into the text box. 
            txtResultHash.Text = newHash;

            //Comapres the calculated hash to the given hash and adjusts text boxes where necassary.
            if (OriginalHash == newHash)
            {
                txtSafeToUse.Text = "Safe to use";
            }
            else
            {
                txtSafeToUse.Text = "Not safe to use";
            }
        }
    }
}
