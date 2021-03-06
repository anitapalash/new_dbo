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
    public partial class Question3 : Form
    {
        public Question3()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, bool> tempDict = new Dictionary<string, bool>();
            tempDict.Add(feature2.Text, checkBox2.Checked);
            tempDict.Add(feature3.Text, checkBox3.Checked);

            Program.setFeatures(tempDict);
            this.Hide();
            new Question4().ShowDialog();
        }
    }
}
