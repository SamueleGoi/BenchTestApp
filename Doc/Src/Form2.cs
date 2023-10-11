using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProceduraCollaudo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelRev.Text = "Rev. " + Collaudo.rev;

            timer1.Start();
            labelDate.Text = DateTime.Now.ToShortDateString();
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToShortDateString();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void iconButtonToForm3_Click(object sender, EventArgs e)
        {
            if (checkBoxCarico.Checked && checkBoxAD.Checked && checkBoxUSB.Checked && checkBoxJIG.Checked && checkBoxSetup.Checked && checkBox400Vac.Checked && checkBoxPowerOn.Checked && checkBoxDisplay.Checked)
            {
                this.Hide();
                var form3 = new Form3();
                form3.Closed += (s, args) => this.Close();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Verificare prima di proseguire", Collaudo.msgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
