using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = webBrowser1.DocumentTitle;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = webBrowser1.StatusText;       
        }
    }
}
