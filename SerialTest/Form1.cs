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

namespace SerialTest
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      string[] ports = SerialPort.GetPortNames();
      cboComPort.Items.AddRange(ports);
//foreach (string port in ports)
//{
//  cboComPort.Items.Add(port);
//}
    }

    private void cmdOpenPort_Click(object sender, EventArgs e)
    {
      if (cboComPort.SelectedIndex == -1)
      {
        MessageBox.Show("Bitte COM-Port auswählen!!");
      }
      else
      {
        serialPort1.PortName = cboComPort.SelectedItem.ToString();
        if (!serialPort1.IsOpen)
        {
          serialPort1.Open();
          lblComInfo.Text = "COM-Port wurde geöffnet";
          cmdOpenPort.Enabled = false;
          cmdClosePort.Enabled = true;
        }
        else
        {
          lblComInfo.Text = "Öffnen des COM-Ports fehlgeschlagen";
        }
      }
    }

    private void cmdClosePort_Click(object sender, EventArgs e)
    {
      if (serialPort1.IsOpen)
      {
        serialPort1.Close();
        lblComInfo.Text = "COM-Port wurde geschlossen";
        cmdClosePort.Enabled = false;
        cmdOpenPort.Enabled = true;
      }
      else
      {
        lblComInfo.Text = "COM-Ports bereits geschlossen";
      }
    }

    private void cmdSend_Click(object sender, EventArgs e)
    {
      if (serialPort1.IsOpen)
      {
        serialPort1.WriteLine(numNumber.Value.ToString());
        Thread.Sleep(200);
        string data = serialPort1.ReadExisting();
        lblData.Text = data;
      }
    }
  }
}
