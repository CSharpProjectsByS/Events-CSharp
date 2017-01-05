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
        private HandlerChangeProperties hChangeProperties;

        public Form1()
        {
            InitializeComponent();

            gift = new Gift();
            hChangeProperties = new HandlerChangeProperties(LogView, gift);
            gift.ChangePropertyEvent += hChangeProperties.changePropertiesValuesAndLogIt;
        }

        private void Value1ChangeButton_Click(object sender, EventArgs e)
        {
            String newValue1 = Value1TextBox.Text;
            String newValue2 = Value2TextBox.Text;
            String newValue3 = Value3TextBox.Text;

            gift.changeProperties(newValue1, newValue2, newValue3);
        }

        private void ClearLogButton_Click(object sender, EventArgs e)
        {
            LogView.Items.Clear();
        }
    }
}
