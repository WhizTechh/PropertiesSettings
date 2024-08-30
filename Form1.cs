//By WhizTech

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertiesSettingsForm.Properties;

namespace PropertiesSettingsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Settings.Default.SaveText; // Load value
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.SaveText = textBox1.Text;
            Settings.Default.Save(); // Saves value
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.SaveText = textBox1.Text;
            Settings.Default.Reset(); // Resets SaveText
        }
    }
}
