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

namespace Task_9._1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryWriter bw = new BinaryWriter(File.Open("1.dat", FileMode.Create));
                textBox2.Text = textBox2.Text.Trim();
                for (int i = 0; i < textBox2.Lines.Length; i++)
                {
                    string s2 = textBox2.Lines[i];
                    bw.Write(s2);
                }
                bw.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string s3 = "";
                BinaryReader br = new BinaryReader(File.Open("1.dat", FileMode.Open));
                while (br.PeekChar() > -1)
                {
                    s3 = br.ReadString();
                }
                br.Close();
                br = new BinaryReader(File.Open("1.dat", FileMode.Open));

                while (br.PeekChar() > -1)
                {
                    string s4 = br.ReadString();
                    if (s4[0] == s3[0])
                    {
                        textBox3.Text += s4 + "\r\n";
                    }
                }
                br.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}

