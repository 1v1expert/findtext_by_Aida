using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace find_word_in_filetext
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Search";
            button2.Text = "Select file";
            label1.Text = "Input text - > ";
            label2.Text = "";
            button3.Text = "Exit";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iter = 0;
            string temp;
            
                if (textBox1.Text == "")
                    MessageBox.Show("Not find text for find");

                StreamReader fs = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                while (!fs.EndOfStream)
                {
                    char sim = (char)fs.Read();
                    if (sim != ' ')
                        label2.Text = label2.Text + sim;
                    else
                    {
                        temp = label2.Text;
                        if (temp == textBox1.Text)
                            iter++;
                        label2.Text = "";
                    }
                }
                label2.Text = textBox1.Text + ":" + " is found of: " + iter;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
    labl1:
            openFileDialog1.Title = "Selected is file";
            openFileDialog1.Filter = "Text files | *.txt";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("File is not selected");
                goto labl1;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
