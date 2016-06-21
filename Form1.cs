﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Array s;

        public Form1()
        {
            InitializeComponent();
            s = File.ReadAllLines("words.txt");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (string word in s)
            {
                if (textBox1.Text != "")
                {
                    if (word[0] == textBox1.Text[textBox1.Text.Length - 1] && !textBox2.Text.Contains(word))
                    {
                        textBox2.Text += Environment.NewLine + $"{textBox1.Text[textBox1.Text.Length - 1]} {word}";
                        break;
                    }
                }
                else
                {
                    textBox2.Text = "";
                }                
            }
        }
    }
}
