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

        static String SHA1Check(String filePath)
        {
            using (var sha1 = SHA1.Create())
            {
                using (var openFile = File.OpenRead(filePath))
                {
                    var hash = sha1.ComputeHash(openFile);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        static String SHA256Check(String filePath)
        {
            using (var sha256 = SHA256.Create())
            {
                using (var openFile = File.OpenRead(filePath))
                {
                    var hash = sha256.ComputeHash(openFile);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        static String SHA384Check(String filePath)
        {
            using (var sha384 = SHA384.Create())
            {
                using (var openFile = File.OpenRead(filePath))
                {
                    var hash = sha384.ComputeHash(openFile);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        static String SHA512Check(String filePath)
        {
            using (var sha512 = SHA512.Create())
            {
                using (var openFile = File.OpenRead(filePath))
                {
                    var hash = sha512.ComputeHash(openFile);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFilePath.Text))
            {
                MessageBox.Show("Error 001: No file path entered.");
            }

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
                newHash = SHA1Check(filePath);
            }
            else if (cmbAlgorithm.Text == "SHA-256")
            {
                newHash = SHA256Check(filePath);
            }
            else if (cmbAlgorithm.Text == "SHA-384")
            {
                newHash = SHA384Check(filePath);
            }
            else if (cmbAlgorithm.Text == "SHA-512")
            {
                newHash = SHA512Check(filePath);
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

        private void TxtSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = fdlg.FileName;
            }
        }
    }
}
