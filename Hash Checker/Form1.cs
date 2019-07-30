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

        private void TxtOriginalHash_TextChanged(object sender, EventArgs e)
        {
            String newHash = "0123456789ABCDEF";
            string OriginalHash = txtOriginalHash.Text;
            if (cmbAlgorithm.Text == "MD5")
            {
                string source = txtFilePath.Text;
                
                newHash = MD5Check(source);


                bool Matches = HashComparison(newHash, OriginalHash);
                if (Matches == true)
                {
                    txtSafeToUse.Text = "Safe to use";
                }
                else
                {
                    txtSafeToUse.Text = "Not safe to use";
                }
                txtResultHash.Text = newHash;

            }
            else if (cmbAlgorithm.Text == "SHA-1")
            {
                MessageBox.Show("SHA-1");
            }
            else if (cmbAlgorithm.Text == "SHA-2")
            {
                MessageBox.Show("SHA-2");
            }
            else if (cmbAlgorithm.Text == "SHA-256")
            {
                MessageBox.Show("SHA-256");
            }
            else if (cmbAlgorithm.Text == "SHA-512")
            {
                MessageBox.Show("SHA-512");
            }
        }
        
        public static bool HashComparison(String newHash, String OriginalHash)

        {
            bool Match = false;
            if (OriginalHash == newHash)
            {
                return Match = true;
            }
            else
            {
                return Match;
            }
        }

        static String MD5Check(String fileName)
        {

            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(fileName))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }

        

        }
    }

    public static class HashChecks
    {

    }
}
