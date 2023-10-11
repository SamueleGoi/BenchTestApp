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

namespace ProceduraCollaudo
{
    public partial class Form6 : Form
    {
        public SerialPort mySerialPort;
        public int rxStatus = 0;
        public string rxBuf;

        public Form6()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToShortDateString();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            labelRev.Text = "Rev. " + Collaudo.rev;

            labelDate.Text = DateTime.Now.ToShortDateString();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

            mySerialPort = new SerialPort();

            mySerialPort.PortName = Collaudo.comPort;
            mySerialPort.BaudRate = Collaudo.comBaud;

            rxStatus = SendCommand("cal0");

            if (rxStatus != 1)
            {
                MessageBox.Show("Errore COM", Collaudo.msgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCen1_Click(object sender, EventArgs e)
        {
            if (checkBoxSetOk.Checked)
            {
                if (SendCommand("cen0") == 1)
                {
                    Thread.Sleep(100);

                    if (SendCommand("cen1") == 1)
                    {
                        labelCen1.ForeColor = Color.FromArgb(0, 192, 0); //verde
                        labelCen1.Text = "OK";
                    }
                    else
                    {
                        labelCen1.ForeColor = Color.FromArgb(192, 0, 0); //rosso
                        labelCen1.Text = "ERR";
                    }
                }
            }
            else
            {
                MessageBox.Show("Verificare il display", Collaudo.msgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCen0_Click(object sender, EventArgs e)
        {
            if (SendCommand("cen0") == 1)
            {
                labelCen1.ForeColor = Color.FromArgb(0, 192, 0); //verde
                labelCen1.Text = "OK";
            }
            else
            {
                labelCen1.ForeColor = Color.FromArgb(192, 0, 0); //rosso
                labelCen1.Text = "ERR";
            }
        }

        private void iconButtonToForm6_Click(object sender, EventArgs e)
        {
            if (checkBoxFunct.Checked && checkBoxIdle.Checked && checkBoxJumper.Checked && checkBoxJumper.Checked && checkBoxLed.Checked)
            {
                if (SendCommand("cen0") == 1)
                {
                    this.Hide();
                    var form7 = new Form7();
                    form7.Closed += (s, args) => this.Close();
                    form7.Show();
                }
            }
        }

        public int SendCommand(string cmd)
        {
            int retVal = 0;

            try
            {
                mySerialPort.ReadTimeout = 3000;

                mySerialPort.Open();

                mySerialPort.WriteLine(cmd);
                rxBuf = mySerialPort.ReadLine();

                if (rxBuf == null)
                {
                    retVal = 2;
                }

                mySerialPort.DiscardInBuffer();
                mySerialPort.DiscardOutBuffer();

                //Console.WriteLine($"{rxBuf[0]}, {rxBuf[1]}, {rxBuf[2]}, lung: {rxBuf.Length}");

                mySerialPort.Close();

                if (rxBuf == "ACK")
                {
                    retVal = 1;
                }
                else if (rxBuf == "NAK")
                {
                    retVal = 0;
                }
                else
                {
                    retVal = 2;
                }

                rxBuf = "";
                return retVal;
            }
            catch (Exception)
            {
                return 2;
            }
        }
    }
}
