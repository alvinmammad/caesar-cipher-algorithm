using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cesar_algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            string input = "";
            input = txtInput.Text;
            char[] characters = input.ToCharArray();
            foreach (char element in characters)
            {
                txtEncrypted.Text += Convert.ToChar(element + 3).ToString();
            }
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            string password = "";
            password = txtEncrypted.Text;
            char[] characters = password.ToCharArray();
            foreach (char element in characters)
            {
                txtInput.Text += Convert.ToChar(element - 3).ToString();
            }
        }
    }
}
