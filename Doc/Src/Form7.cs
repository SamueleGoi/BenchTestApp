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
    public partial class Form7 : Form
    {
        public SerialPort mySerialPort;
        public int rxStatus = 0;
        public string rxBuf;

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            labelRev.Text = "Rev. " + Collaudo.rev;
            if (Collaudo.model == "250")
            {
                labelStart.Text = "07.01. Impostare un setpoint di 200A e verificare il corretto setpoint sul display";
                buttonSpa.Text = "SPA200";
            }
            else if (Collaudo.model == "150")
            {
                labelStart.Text = "07.01. Impostare un setpoint di 100A e verificare il corretto setpoint sul display";
                buttonSpa.Text = "SPA100";
            }

            labelDate.Text = DateTime.Now.ToShortDateString();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

            mySerialPort = new SerialPort();

            mySerialPort.PortName = Collaudo.comPort;
            mySerialPort.BaudRate = Collaudo.comBaud;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToShortDateString();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void buttonSpa_Click(object sender, EventArgs e)
        {
            if (Collaudo.model == "250")
            {
                if (SendCommand("spa200") == 1)
                {
                    labelSpa.ForeColor = Color.FromArgb(0, 192, 0); //verde
                    labelSpa.Text = "OK";
                }
                else
                {
                    labelSpa.ForeColor = Color.FromArgb(192, 0, 0); //rosso
                    labelSpa.Text = "ERR";
                }
            }
            else if (Collaudo.model == "150")
            {
                if (SendCommand("spa100") == 1)
                {
                    labelSpa.ForeColor = Color.FromArgb(0, 192, 0); //verde
                    labelSpa.Text = "OK";
                }
                else
                {
                    labelSpa.ForeColor = Color.FromArgb(192, 0, 0); //rosso
                    labelSpa.Text = "ERR";
                }
            }
        }

        private void buttonCen1_Click(object sender, EventArgs e)
        {
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
