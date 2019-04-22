using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace NeoPixel
{
    public partial class SelectPort : Form
    {
        public string SelectedPort { get; private set; }
        public SelectPort()
        {
            InitializeComponent();
            SelectedPort = "";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SelectedPort = cb.SelectedItem.ToString();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            cb.Items.Clear();
            cb.Items.AddRange(SerialPort.GetPortNames());
        }
    }
}
