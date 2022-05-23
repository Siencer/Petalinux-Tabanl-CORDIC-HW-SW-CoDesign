using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
  public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            serialPort().BaudRate = 9600;
            serialPort().PortName = "COM6";
            serialPort.Open();
        }

        private void serialPort_Data(object x,System.IO.Ports.SerialDataEventArgs e)
        {
            string data1 = serialPort1_Data.ReadExisting();
            if(RichTextBox.InvokeRequired)
            {
                RichTextBox.Invoke(new MethodInvoker(delegate { RichTextBox.Text += data1 + "/r/n/n"; }));
            }
        }
        private void button(object x,EventArgs e)
        {
            string text;
            text;= TextBox.Text;

            serialPort.Writeline(text); 
        }
  }



