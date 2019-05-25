﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broker
{
    public partial class Question2 : Form
    {
        public Question2()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, bool> tempDict = new Dictionary<string, bool>();
            tempDict.Add(feature1.Text, checkBox1.Checked);
            tempDict.Add(feature2.Text, checkBox2.Checked);
            tempDict.Add(feature3.Text, checkBox3.Checked);
            tempDict.Add(feature4.Text, checkBox4.Checked);
            tempDict.Add(feature5.Text, checkBox5.Checked);
            tempDict.Add(feature6.Text, checkBox6.Checked);

            Program.setFeatures(tempDict);
            this.Hide();
            new Question3().ShowDialog();
        }
    }
}
