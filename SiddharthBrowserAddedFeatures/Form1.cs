/*
In the following questions, you will add more features into the browser that you created in Assignment 1. Choose two questions only from the following set of questions. If you do more than two, we will grade the first two only. Each question is 30 points. 

1. Add a simple calculator in your Web browser, with floating point +, -, *, and / operations. No service call is required in this question. [25 points] 

2.  Add text encryption decryption function in your browser. Follow the example in text 3.6.3. However, instead of using the localhost 
service, you must use the service in the ASU Repository at:  http://neptune.fulton.ad.asu.edu/WSRepository/Services/EncryptionWcf/Service.svc [25 points]  
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiddharthBrowserAddedFeatures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(input.Text);
        }

        /*Code for the addition operation*/
        private void add_Click(object sender, EventArgs e)
        {
            Int64 a = Convert.ToInt64(input1.Text);
            Int64 b = Convert.ToInt64(input2.Text);
            Int64 res = a + b;
            output.Text = " The answer is : " + Convert.ToString(res);
        }

        /* 
         * Codes for implementing the calculator functionality 
        */

        /*Code for the subtraction operation*/
        private void subtract_Click(object sender, EventArgs e)
        {
            Int64 a = Convert.ToInt64(input1.Text);
            Int64 b = Convert.ToInt64(input2.Text);
            Int64 res = a - b;
            output.Text = " The answer is : " + Convert.ToString(res);
        }

        /*Code for the multiplication operation*/
        private void multiply_Click(object sender, EventArgs e)
        {
            Int64 a = Convert.ToInt64(input1.Text);
            Int64 b = Convert.ToInt64(input2.Text);
            Int64 res = a * b;
            output.Text = " The answer is : " + Convert.ToString(res);
        }

        /*Code for the division operation*/
        private void divide_Click(object sender, EventArgs e)
        {
            Double a = Convert.ToDouble(input1.Text);
            Double b = Convert.ToDouble(input2.Text);
            try
            {
                if (b == 0)
                    throw new System.DivideByZeroException();
                Double res = a / b;
                output.Text = " The answer is : " + String.Format("{0:F3}", res);
            }
            catch(DivideByZeroException de)
            {
                DialogResult box = MessageBox.Show(de.ToString(), "Error!", MessageBoxButtons.OKCancel);
            }
        }

        /*Code to implement the encryption-decryption functionality*/
        private void encrypt_button_Click(object sender, EventArgs e)
        {
            MyEncryptionServiceReference.ServiceClient client = new MyEncryptionServiceReference.ServiceClient();
            String encrypt = client.Encrypt(input_text.Text);
            String decrypt = client.Decrypt(encrypt);
            encrypted.Text = encrypt;
            decrypted.Text = decrypt;
            client.Close();
        }

        private void encrypted_Click(object sender, EventArgs e)
        {

        }
    }
}
