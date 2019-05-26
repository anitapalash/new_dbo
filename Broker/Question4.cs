using System;
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
    public partial class Question4 : Form
    {
        public Question4()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, bool> tempDict = new Dictionary<string, bool>();
            tempDict.Add(feature.Text, true);
            Program.setFeatures(tempDict);

            MessageBox.Show("Успех", "Успех", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, bool> tempDict = new Dictionary<string, bool>();
            tempDict.Add(feature.Text, false);
            Program.setFeatures(tempDict);

            MessageBox.Show("Успех", "Успех", MessageBoxButtons.OK);
            Application.Exit();
        }


    }
}
