using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeoPixel
{
    public partial class MainForm : Form
    {
        byte[] send = new byte[3];
        public MainForm()
        {
            InitializeComponent();
        }
        Bitmap bmp = new Bitmap(300, 100);
        Graphics gp;
        private void b_Scroll(object sender, EventArgs e)
        {
            send[0] = (byte)(bRed.Value);
            send[1] = (byte)(bGreen.Value);
            send[2] = (byte)(bBlue.Value);
            colorBox.BackColor = Color.FromArgb((int)send[0], (int)send[1], (int)send[2]);
            lbBlue.Text = bBlue.Value.ToString();
            lbGreen.Text = bGreen.Value.ToString();
            lbRed.Text = bRed.Value.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Hide();
            SelectPort dlg = new SelectPort();
            if (dlg.ShowDialog() != DialogResult.OK)
                Close();
            serialPort1.PortName = dlg.SelectedPort;
            serialPort1.Open();
        }

        private void colorBox_DoubleClick(object sender, EventArgs e)
        {
            if (cDlg.ShowDialog() == DialogResult.OK)
            {
                colorBox.BackColor = cDlg.Color;
                send[0] = cDlg.Color.R;
                send[1] = cDlg.Color.G;
                send[2] = cDlg.Color.B;
                bRed.Value = cDlg.Color.R;
                bGreen.Value = cDlg.Color.G;
                bBlue.Value = cDlg.Color.B;
                lbBlue.Text = bBlue.Value.ToString();
                lbGreen.Text = bGreen.Value.ToString();
                lbRed.Text = bRed.Value.ToString();
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            SerialPort com = sender as SerialPort;
            com.Write(send, 0, 3);
        }
    }
}
