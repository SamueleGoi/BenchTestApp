using Microsoft.VisualBasic;

namespace ProceduraCollaudo
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            Collaudo.location = @"C:\Users\s.goi\Desktop"; //Commentare in release
            //Collaudo.location = @"R:\COLLAUDI\BDS_ARC"; //Decommentare in release
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        //TODO: Aggiungere metodo per verificare numero di serie
        private void iconButtonToForm2_Click(object sender, EventArgs e)
        {

            if (textBoxOperatore.Text == "")
            {
                MessageBox.Show("Inserire l'operatore", Collaudo.msgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxMatricola.Text == "")
            {
                MessageBox.Show("Inserire la matricola", Collaudo.msgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!checkBox150A.Checked && !checkBox250A.Checked)
            {
                MessageBox.Show("Selezionare il modello (150A o 250A)", Collaudo.msgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!checkBoxProfiYes.Checked && !checkBoxProfiNo.Checked)
            {
                MessageBox.Show("Selezionare se è installato o no il modulo Profibus", Collaudo.msgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!checkBoxIgnitionYes.Checked && !checkBoxIgnitionNo.Checked)
            {
                MessageBox.Show("Selezionare se è installato o no il modulo Ignition", Collaudo.msgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkBox150A.Checked)
                {
                    Collaudo.model = "150";
                }
                else if (checkBox250A.Checked)
                {
                    Collaudo.model = "250";
                }

                Collaudo.matricola = textBoxMatricola.Text;
                Collaudo.operatore = textBoxOperatore.Text;

                if (checkBoxIgnitionYes.Checked)
                {
                    Collaudo.modelIgnition = "1";
                }
                else
                {
                    Collaudo.modelIgnition = "0";
                }

                //creazione cartella in path
                Collaudo.folderName = textBoxMatricola.Text + "_" + "BDS_ARC" + "_" + Collaudo.model;
                Collaudo.folderPath = System.IO.Path.Combine(Collaudo.location, Collaudo.folderName);
                System.IO.Directory.CreateDirectory(Collaudo.folderPath);

                //creazione file in path
                Collaudo.fileName = Collaudo.fileName + "_" + Collaudo.folderName + ".txt";
                Collaudo.filePath = System.IO.Path.Combine(Collaudo.folderPath, Collaudo.fileName);

                //if (!System.IO.File.Exists(Collaudo.filePath))
                //{
                //    //System.IO.File.Create(filePath);
                //    using (StreamWriter sw = File.CreateText(Collaudo.filePath))
                //    {
                //        sw.WriteLine("Collaudo BDS.ARC V2");
                //        sw.WriteLine("Data e ora:\t\t\t" + DateTime.Now.ToShortDateString() + "\t" + DateTime.Now.ToLongTimeString());
                //        sw.WriteLine("Operatore:\t\t\t" + textBoxOperatore.Text);
                //        sw.WriteLine("Matricola:\t\t\t" + textBoxMatricola.Text);
                //        sw.WriteLine("Modello:\t\t\t" + Collaudo.model + "A");

                //        if (checkBoxProfiYes.Checked)
                //        {
                //            Collaudo.modelProfi = "Si";
                //        }
                //        else
                //        {
                //            Collaudo.modelProfi = "No";
                //        }

                //        sw.WriteLine("Profibus:\t\t\t" + Collaudo.modelProfi);

                //        if (checkBoxIgnitionYes.Checked)
                //        {
                //            Collaudo.modelIgnition = "Si";
                //        }
                //        else
                //        {
                //            Collaudo.modelIgnition = "No";
                //        }

                //        sw.WriteLine("Ignition:\t\t\t" + Collaudo.modelIgnition);

                //    }
                //    MessageBox.Show("File di log creato correttamente", Collaudo.msgSuccess, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show("File di log già esistente", Collaudo.msgWarning, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

                this.Hide();
                var form2 = new Form2();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        private void checkBox150A_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox150A.Checked)
            {
                checkBox250A.Enabled = false;
            }
            else
            {
                checkBox250A.Enabled = true;
            }
        }

        private void checkBox250A_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox250A.Checked)
            {
                checkBox150A.Enabled = false;
            }
            else
            {
                checkBox150A.Enabled = true;
            }
        }

        private void checkBoxProfiYes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProfiYes.Checked)
            {
                checkBoxProfiNo.Enabled = false;
            }
            else
            {
                checkBoxProfiNo.Enabled = true;
            }
        }

        private void checkBoxProfiNo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProfiNo.Checked)
            {
                checkBoxProfiYes.Enabled = false;
            }
            else
            {
                checkBoxProfiYes.Enabled = true;
            }
        }

        private void checkBoxIgnitionYes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIgnitionYes.Checked)
            {
                checkBoxIgnitionNo.Enabled = false;
            }
            else
            {
                checkBoxIgnitionNo.Enabled = true;
            }
        }

        private void checkBoxIgnitionNo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIgnitionNo.Checked)
            {
                checkBoxIgnitionYes.Enabled = false;
            }
            else
            {
                checkBoxIgnitionYes.Enabled = true;
            }
        }
    }
}