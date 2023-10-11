using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace ProceduraCollaudo
{
    public partial class Form3 : Form
    {
        string[] ports = SerialPort.GetPortNames();
        public SerialPort mySerialPort;
        public bool portOk = false;
        public string rxBuf;
        public int rxStatus = 0;

        /******* DEBUG *******/
        //public string model = "150";
        //public string matricola = "2303.D.620567";
        //public string ignition = "1";

        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToShortDateString();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            labelRev.Text = "Rev. " + Collaudo.rev;

            timer1.Start();
            labelDate.Text = DateTime.Now.ToShortDateString();
            labelTime.Text = DateTime.Now.ToLongTimeString();

            buttonOpen.Enabled = false;
            //buttonEsciCollaudo.Enabled = false;
            buttonInviaMatricola.Enabled = false;
            buttonInviaModel.Enabled = false;
            buttonInviaIgnition.Enabled = false;
            buttonInviaProfibus.Enabled = false;

            comboBoxCOM.Items.AddRange(ports);
            //comboBoxCOM.SelectedIndex = 0;

            labelMatricola.Text = Collaudo.matricola;
            labelModel.Text = Collaudo.model + "A";
            if (Collaudo.modelIgnition == "1")
            {
                labelIgnition.Text = "Ignition";
            }
            else
            {
                labelIgnition.Text = "Ignition";
            }
        }

        public void comboBoxCOM_Click(object sender, EventArgs e)
        {
            comboBoxCOM.Items.Clear();
            comboBoxCOM.Items.AddRange(ports);
            //comboBoxCOM.SelectedIndex = 0;
        }

        private void comboBoxCOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonOpen.Enabled = true;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            buttonOpen.Enabled = false;

            mySerialPort = new SerialPort();


            Collaudo.comPort = comboBoxCOM.Text;
            mySerialPort.PortName = Collaudo.comPort;
            mySerialPort.BaudRate = Collaudo.comBaud;

            //TryOpen();

            //Console.WriteLine($"{portOk}");
            //Console.WriteLine($"{mySerialPort.BaudRate}");
            //Console.WriteLine($"{mySerialPort.Parity}");
            //Console.WriteLine($"{mySerialPort.StopBits}");
            //Console.WriteLine($"{mySerialPort.DataBits}");

            rxStatus = SendCommand("esc");
            /******* INVIO "esc" *******/
            if (rxStatus == 0 || rxStatus == 1)
            {

                labelStatusCOM.ForeColor = Color.FromArgb(0, 192, 0); //verde
                labelStatusCOM.Text = "APERTA";

                if (SendCommand("pwd123") == 1)
                {
                    rxStatus = 1;

                    //buttonEntraCollaudo.Enabled = false;
                    //buttonEsciCollaudo.Enabled = true;
                    buttonInviaMatricola.Enabled = true;
                    buttonInviaModel.Enabled = true;
                    buttonInviaIgnition.Enabled = true;
                    buttonInviaProfibus.Enabled = true;
                }
            }
            else if (rxStatus == 2)
            {
                labelStatusCOM.ForeColor = Color.FromArgb(192, 0, 0); //rosso
                labelStatusCOM.Text = "CHIUSA";

                buttonInviaMatricola.Enabled = false;
                buttonInviaModel.Enabled = false;
                buttonInviaIgnition.Enabled = false;
                buttonInviaProfibus.Enabled = false;
            }
            else
            {
                if (SendCommand("pwd123") == 1)
                {
                    rxStatus = 1;

                    //buttonEntraCollaudo.Enabled = false;
                    //buttonEsciCollaudo.Enabled = true;
                    buttonInviaMatricola.Enabled = true;
                    buttonInviaModel.Enabled = true;
                    buttonInviaIgnition.Enabled = true;
                    buttonInviaProfibus.Enabled = true;
                }
            }
        }
        /******* INVIO nsn{matricola} *******/
        private void buttonInviaMatricola_Click(object sender, EventArgs e)
        {
            if (SendCommand("csn") == 1)
            {
                Thread.Sleep(100);

                if (SendCommand($"nsn{labelMatricola.Text}") == 1)
                {
                    rxStatus = 1;

                    labelMatricolaOk.ForeColor = Color.FromArgb(0, 192, 0); //verde
                    labelMatricolaOk.Text = "OK";
                }
                else
                {
                    rxStatus = 0;

                    labelMatricolaOk.ForeColor = Color.FromArgb(192, 0, 0); //rosso
                    labelMatricolaOk.Text = "ERR";
                }
            }

        }

        /******* INVIO max{model} *******/
        private void buttonInviaModel_Click(object sender, EventArgs e)
        {
            if (SendCommand($"max{Collaudo.model}") == 1)
            {
                rxStatus = 1;

                labelModelloOk.ForeColor = Color.FromArgb(0, 192, 0); //verde
                labelModelloOk.Text = "OK";
            }
            else
            {
                rxStatus = 0;

                labelModelloOk.ForeColor = Color.FromArgb(192, 0, 0); //rosso
                labelModelloOk.Text = "ERR";
            }
        }

        /******* INVIO ige{modelIgnition} *******/
        private void buttonInviaIgnition_Click(object sender, EventArgs e)
        {
            if (SendCommand($"ige{Collaudo.modelIgnition}") == 1)
            {
                rxStatus = 1;

                labelIgnitionOk.ForeColor = Color.FromArgb(0, 192, 0); //verde
                labelIgnitionOk.Text = "OK";
            }
            else
            {
                rxStatus = 0;

                labelIgnition.ForeColor = Color.FromArgb(192, 0, 0); //rosso
                labelIgnition.Text = "ERR";
            }
        }

        /******* INVIO prf *******/
        private void buttonInviaProfibus_Click(object sender, EventArgs e)
        {
            rxStatus = SendCommand("prf");

            if (rxStatus == 0 || rxStatus == 1)
            {
                rxStatus = 1;

                labelProfibusOk.ForeColor = Color.FromArgb(0, 192, 0); //verde
                labelProfibusOk.Text = "OK";
            }
            else
            {
                rxStatus = 0;

                labelProfibusOk.ForeColor = Color.FromArgb(192, 0, 0); //rosso
                labelProfibusOk.Text = "ERR";
            }
        }

        private void iconButtonToForm4_Click_1(object sender, EventArgs e)
        {
            if (labelMatricolaOk.ForeColor == Color.FromArgb(0, 192, 0) && labelModelloOk.ForeColor == Color.FromArgb(0, 192, 0) && labelIgnitionOk.ForeColor == Color.FromArgb(0, 192, 0) && labelProfibusOk.ForeColor == Color.FromArgb(0, 192, 0))
            {
                this.Hide();
                var form4 = new Form4();
                form4.Closed += (s, args) => this.Close();
                form4.Show();
            }
            else
            {
                MessageBox.Show("Verificare il corretto invio dei parametri", Collaudo.msgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonModificaMatricola_Click(object sender, EventArgs e)
        {
            string value = "";

            if (InputBox("Modifica", "Inserisci il numero di matricola", ref value) == DialogResult.OK)
            {
                labelMatricolaOk.ForeColor = Color.FromArgb(255, 255, 255); //bianco
                labelMatricola.Visible = true;
                labelMatricola.Text = value;
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

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            System.Windows.Forms.Button buttonOk = new System.Windows.Forms.Button();
            System.Windows.Forms.Button buttonCancel = new System.Windows.Forms.Button();

            form.Text = title;
            label.Text = promptText;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(36, 36, 372, 20);
            textBox.SetBounds(36, 86, 700, 20);
            buttonOk.SetBounds(228, 160, 160, 60);
            buttonCancel.SetBounds(400, 160, 160, 60);

            label.AutoSize = true;
            form.ClientSize = new Size(796, 307);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;

            form.Controls.AddRange(new System.Windows.Forms.Control[] { label, textBox, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();

            value = textBox.Text;
            return dialogResult;

        }
    }
}

