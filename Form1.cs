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
using System.Threading;
using System.Xml.Linq;

namespace mySSMS
{
    public partial class frmMain : Form
    {
        // Globals
        private static SerialPort srl1;
        private static string[] s = new string[9];
        private static string Ricevuta;
        private static char separatore = ' ';
        public frmMain()
        {
            InitializeComponent();

            // Istanza dell’oggetto
            srl1 = new SerialPort();

            // Definizione del gestore evento DataReceived (delegate) 
            srl1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (string port in SerialPort.GetPortNames())
            {
                cmbPorte.Items.Add(port);
            }
            cmbPorte.SelectedIndex = 0;
            srl1.PortName = cmbPorte.SelectedItem.ToString();

            srl1.BaudRate = 9600;
            srl1.DataBits = 8;
            srl1.Parity = Parity.None;
            srl1.StopBits = StopBits.One;
            srl1.Handshake = Handshake.None;
        }

        private void DataReceivedHandler(object sender,
                    SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(DisplayData_event));
        }

        private void DisplayData_event(object sender, EventArgs e)
        {
            Ricevuta = srl1.ReadLine();
            // Riempi listview
            s = Ricevuta.Split(separatore);
            for (int i = 0; i < s.Length; i += 3)
            {
                ListViewItem lsitem = new ListViewItem(
                new string[]
                {
                    s[i],
                    s[i + 1],
                    s[i + 2]
                }
                );
                listView1.Items.Add(lsitem);
            }
        }
        private void btnApriChiudi_Click(object sender, EventArgs e)
        {
            switch (btnApriChiudi.Text)
            {
                case "Open":
                    srl1.Open();
                    cmbPorte.Enabled = false;
                    btnApriChiudi.Text = "Close";
                    break;
                case "Close":
                    srl1.Close();
                    cmbPorte.Enabled = true;
                    btnApriChiudi.Text = "Open";
                    break;
            }
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            srl1.WriteLine(txtQuery.Text);
        }

        private void cmbPorte_SelectedIndexChanged(object sender, EventArgs e)
        {
            srl1.PortName = cmbPorte.SelectedItem.ToString();
        }
    }
}
