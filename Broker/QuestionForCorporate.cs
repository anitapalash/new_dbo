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
    public partial class QuestionForCorporate : Form
    {
        public QuestionForCorporate()
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
            tempDict.Add(feature7.Text, checkBox7.Checked);
            tempDict.Add(feature8.Text, checkBox8.Checked);

            Program.setFeatures(tempDict);
            this.Hide();
            new Question3().ShowDialog();
        }
    }
}
