using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
       
            if (cmbAlgorithm.Text == "MD5")
            {
                MessageBox.Show("md5 work");

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
        
        public static bool HashComparison(this String newHash, String OriginalHash)
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
    }

    public static class HashChecks
    {
        public static String MD5Check(this string newHash)
        {

            return newHash;
        }
    }
}
