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
    public partial class Form4 : Form
    {
        public SerialPort mySerialPort;
        public int rxStatus = 0;
        public string rxBuf;

        public Form4()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToShortDateString();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            labelRev.Text = "Rev. " + Collaudo.rev;

            labelDate.Text = DateTime.Now.ToShortDateString();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

            mySerialPort = new SerialPort();

            mySerialPort.PortName = Collaudo.comPort;
            mySerialPort.BaudRate = Collaudo.comBaud;


            mySerialPort.ReadTimeout = 3000;

            try
            {
                mySerialPort.Open();

                mySerialPort.WriteLine("inf");

                Thread.Sleep(500);

                rxBuf = mySerialPort.ReadExisting();
                this.Invoke(new EventHandler(ShowData));

                mySerialPort.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Errore porta COM", Collaudo.msgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCom_Click(object sender, EventArgs e)
        {
            if (SendCommand("com1") == 1)
            {
                labelCom.ForeColor = Color.FromArgb(0, 192, 0); //verde
                labelCom.Text = "OK";

                Thread.Sleep(100);

                if (SendCommand("cal1") == 1)
                {
                    labelCom.ForeColor = Color.FromArgb(0, 192, 0); //verde
                    labelCom.Text = "OK";
                }
                else
                {
                    labelCom.ForeColor = Color.FromArgb(192, 0, 0); //rosso
                    labelCom.Text = "ERR";
                }
            }
            else
            {
                labelCom.ForeColor = Color.FromArgb(192, 0, 0); //rosso
                labelCom.Text = "ERR";
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

        private void ShowData(object sender, EventArgs e)
        {
            textBoxInfo.Text = rxBuf.ReplaceLineEndings();
            textBoxInfo.Text = rxBuf.Replace("\n", Environment.NewLine);
        }

        private void iconButtonToForm5_Click(object sender, EventArgs e)
        {
            if (checkBoxCtrl.Checked)
            {
                this.Hide();
                var form5 = new Form5();
                form5.Closed += (s, args) => this.Close();
                form5.Show();
            }
            else
            {
                MessageBox.Show("Verificare sul display", Collaudo.msgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
