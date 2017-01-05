using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zdarzenia
{
    public partial class Form1 : Form
    {
        private Gift gift;

        public Form1()
        {
            InitializeComponent();

            gift = new Gift(LogView);

        }

        private void Value1ChangeButton_Click(object sender, EventArgs e)
        {
            String newValue1 = Value1TextBox.Text;
            String newValue2 = Value2TextBox.Text;
            String newValue3 = Value3TextBox.Text;

            gift.Value1 = newValue1;
            gift.Value2 = newValue2;
            gift.Value3 = newValue3;
        }

        private void ClearLogButton_Click(object sender, EventArgs e)
        {
            LogView.Items.Clear();
        }
    }
}
