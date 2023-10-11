namespace ProceduraCollaudo
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panelMenu = new Panel();
            labelRev = new Label();
            labelDate = new Label();
            labelTime = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            labelTitle = new Label();
            label1 = new Label();
            comboBoxCOM = new ComboBox();
            iconButtonToForm4 = new FontAwesome.Sharp.IconButton();
            buttonOpen = new Button();
            label2 = new Label();
            label7 = new Label();
            labelStatusCOM = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonInviaMatricola = new Button();
            buttonInviaModel = new Button();
            buttonInviaIgnition = new Button();
            labelMatricola = new Label();
            labelModel = new Label();
            labelIgnition = new Label();
            labelMatricolaOk = new Label();
            labelModelloOk = new Label();
            labelIgnitionOk = new Label();
            labelProfibusOk = new Label();
            labelProfi = new Label();
            buttonInviaProfibus = new Button();
            buttonModificaMatricola = new Button();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(45, 86, 160);
            panelMenu.Controls.Add(labelRev);
            panelMenu.Controls.Add(labelDate);
            panelMenu.Controls.Add(labelTime);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(300, 661);
            panelMenu.TabIndex = 2;
            // 
            // labelRev
            // 
            labelRev.Dock = DockStyle.Top;
            labelRev.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelRev.ForeColor = Color.White;
            labelRev.Location = new Point(0, 58);
            labelRev.Name = "labelRev";
            labelRev.Size = new Size(300, 60);
            labelRev.TabIndex = 3;
            labelRev.Text = "Rev.";
            labelRev.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDate
            // 
            labelDate.Dock = DockStyle.Bottom;
            labelDate.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDate.ForeColor = Color.White;
            labelDate.Location = new Point(0, 541);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(300, 60);
            labelDate.TabIndex = 2;
            labelDate.Text = "Date";
            labelDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTime
            // 
            labelTime.Dock = DockStyle.Bottom;
            labelTime.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTime.ForeColor = Color.White;
            labelTime.Location = new Point(0, 601);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(300, 60);
            labelTime.TabIndex = 1;
            labelTime.Text = "Time";
            labelTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 58);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(45, 86, 160);
            labelTitle.Location = new Point(315, 3);
            labelTitle.Margin = new Padding(0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(868, 60);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Procedura di collaudo BDS.ARC V2";
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(45, 86, 160);
            label1.Location = new Point(320, 63);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(709, 60);
            label1.TabIndex = 6;
            label1.Text = "03. Apertura e verifica porta COM";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxCOM
            // 
            comboBoxCOM.FormattingEnabled = true;
            comboBoxCOM.Location = new Point(324, 215);
            comboBoxCOM.Name = "comboBoxCOM";
            comboBoxCOM.Size = new Size(153, 23);
            comboBoxCOM.TabIndex = 7;
            comboBoxCOM.SelectedIndexChanged += comboBoxCOM_SelectedIndexChanged;
            comboBoxCOM.Click += comboBoxCOM_Click;
            // 
            // iconButtonToForm4
            // 
            iconButtonToForm4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iconButtonToForm4.FlatAppearance.BorderColor = Color.White;
            iconButtonToForm4.FlatAppearance.BorderSize = 0;
            iconButtonToForm4.FlatAppearance.MouseDownBackColor = Color.White;
            iconButtonToForm4.FlatAppearance.MouseOverBackColor = Color.White;
            iconButtonToForm4.FlatStyle = FlatStyle.Flat;
            iconButtonToForm4.IconChar = FontAwesome.Sharp.IconChar.CircleChevronRight;
            iconButtonToForm4.IconColor = Color.FromArgb(45, 86, 160);
            iconButtonToForm4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonToForm4.IconSize = 64;
            iconButtonToForm4.Location = new Point(1276, 574);
            iconButtonToForm4.Name = "iconButtonToForm4";
            iconButtonToForm4.Size = new Size(96, 75);
            iconButtonToForm4.TabIndex = 8;
            iconButtonToForm4.UseVisualStyleBackColor = true;
            iconButtonToForm4.Click += iconButtonToForm4_Click_1;
            // 
            // buttonOpen
            // 
            buttonOpen.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOpen.ForeColor = Color.FromArgb(45, 86, 160);
            buttonOpen.Location = new Point(483, 215);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(88, 23);
            buttonOpen.TabIndex = 9;
            buttonOpen.Text = "APRI";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(45, 86, 160);
            label2.Location = new Point(324, 179);
            label2.Name = "label2";
            label2.Size = new Size(310, 33);
            label2.TabIndex = 10;
            label2.Text = "COM:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(45, 86, 160);
            label7.Location = new Point(588, 215);
            label7.Name = "label7";
            label7.Size = new Size(190, 23);
            label7.TabIndex = 11;
            label7.Text = "Stato comunicazione:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelStatusCOM
            // 
            labelStatusCOM.Anchor = AnchorStyles.Left;
            labelStatusCOM.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStatusCOM.ForeColor = Color.FromArgb(192, 0, 0);
            labelStatusCOM.Location = new Point(774, 215);
            labelStatusCOM.Name = "labelStatusCOM";
            labelStatusCOM.Size = new Size(123, 23);
            labelStatusCOM.TabIndex = 13;
            labelStatusCOM.Text = "CHIUSA";
            labelStatusCOM.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(45, 86, 160);
            label3.Location = new Point(324, 146);
            label3.Name = "label3";
            label3.Size = new Size(395, 33);
            label3.TabIndex = 14;
            label3.Text = "03.01. Selezionare la porta COM";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(45, 86, 160);
            label4.Location = new Point(324, 301);
            label4.Name = "label4";
            label4.Size = new Size(439, 33);
            label4.TabIndex = 16;
            label4.Text = "03.02. Controllo e invio dati per il collaudo";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonInviaMatricola
            // 
            buttonInviaMatricola.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInviaMatricola.ForeColor = Color.FromArgb(45, 86, 160);
            buttonInviaMatricola.Location = new Point(483, 349);
            buttonInviaMatricola.Name = "buttonInviaMatricola";
            buttonInviaMatricola.Size = new Size(88, 33);
            buttonInviaMatricola.TabIndex = 31;
            buttonInviaMatricola.Text = "INVIA";
            buttonInviaMatricola.UseVisualStyleBackColor = true;
            buttonInviaMatricola.Click += buttonInviaMatricola_Click;
            // 
            // buttonInviaModel
            // 
            buttonInviaModel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInviaModel.ForeColor = Color.FromArgb(45, 86, 160);
            buttonInviaModel.Location = new Point(483, 394);
            buttonInviaModel.Name = "buttonInviaModel";
            buttonInviaModel.Size = new Size(88, 33);
            buttonInviaModel.TabIndex = 33;
            buttonInviaModel.Text = "INVIA";
            buttonInviaModel.UseVisualStyleBackColor = true;
            buttonInviaModel.Click += buttonInviaModel_Click;
            // 
            // buttonInviaIgnition
            // 
            buttonInviaIgnition.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInviaIgnition.ForeColor = Color.FromArgb(45, 86, 160);
            buttonInviaIgnition.Location = new Point(483, 439);
            buttonInviaIgnition.Name = "buttonInviaIgnition";
            buttonInviaIgnition.Size = new Size(88, 33);
            buttonInviaIgnition.TabIndex = 39;
            buttonInviaIgnition.Text = "INVIA";
            buttonInviaIgnition.UseVisualStyleBackColor = true;
            buttonInviaIgnition.Click += buttonInviaIgnition_Click;
            // 
            // labelMatricola
            // 
            labelMatricola.Anchor = AnchorStyles.Left;
            labelMatricola.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelMatricola.ForeColor = Color.FromArgb(45, 86, 160);
            labelMatricola.Location = new Point(324, 349);
            labelMatricola.Name = "labelMatricola";
            labelMatricola.Size = new Size(153, 33);
            labelMatricola.TabIndex = 40;
            labelMatricola.Text = "Matricola";
            labelMatricola.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelModel
            // 
            labelModel.Anchor = AnchorStyles.Left;
            labelModel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelModel.ForeColor = Color.FromArgb(45, 86, 160);
            labelModel.Location = new Point(324, 394);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(153, 33);
            labelModel.TabIndex = 41;
            labelModel.Text = "Modello";
            labelModel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelIgnition
            // 
            labelIgnition.Anchor = AnchorStyles.Left;
            labelIgnition.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelIgnition.ForeColor = Color.FromArgb(45, 86, 160);
            labelIgnition.Location = new Point(324, 439);
            labelIgnition.Name = "labelIgnition";
            labelIgnition.Size = new Size(153, 33);
            labelIgnition.TabIndex = 42;
            labelIgnition.Text = "Ignition";
            labelIgnition.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelMatricolaOk
            // 
            labelMatricolaOk.Anchor = AnchorStyles.Left;
            labelMatricolaOk.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMatricolaOk.ForeColor = Color.White;
            labelMatricolaOk.Location = new Point(671, 355);
            labelMatricolaOk.Name = "labelMatricolaOk";
            labelMatricolaOk.Size = new Size(123, 23);
            labelMatricolaOk.TabIndex = 43;
            labelMatricolaOk.Text = "ERR";
            labelMatricolaOk.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelModelloOk
            // 
            labelModelloOk.Anchor = AnchorStyles.Left;
            labelModelloOk.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelModelloOk.ForeColor = Color.White;
            labelModelloOk.Location = new Point(577, 400);
            labelModelloOk.Name = "labelModelloOk";
            labelModelloOk.Size = new Size(123, 23);
            labelModelloOk.TabIndex = 44;
            labelModelloOk.Text = "ERR";
            labelModelloOk.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelIgnitionOk
            // 
            labelIgnitionOk.Anchor = AnchorStyles.Left;
            labelIgnitionOk.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelIgnitionOk.ForeColor = Color.White;
            labelIgnitionOk.Location = new Point(577, 445);
            labelIgnitionOk.Name = "labelIgnitionOk";
            labelIgnitionOk.Size = new Size(123, 23);
            labelIgnitionOk.TabIndex = 45;
            labelIgnitionOk.Text = "ERR";
            labelIgnitionOk.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelProfibusOk
            // 
            labelProfibusOk.Anchor = AnchorStyles.Left;
            labelProfibusOk.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelProfibusOk.ForeColor = Color.White;
            labelProfibusOk.Location = new Point(577, 490);
            labelProfibusOk.Name = "labelProfibusOk";
            labelProfibusOk.Size = new Size(123, 23);
            labelProfibusOk.TabIndex = 48;
            labelProfibusOk.Text = "ERR";
            labelProfibusOk.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelProfi
            // 
            labelProfi.Anchor = AnchorStyles.Left;
            labelProfi.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelProfi.ForeColor = Color.FromArgb(45, 86, 160);
            labelProfi.Location = new Point(324, 484);
            labelProfi.Name = "labelProfi";
            labelProfi.Size = new Size(153, 33);
            labelProfi.TabIndex = 47;
            labelProfi.Text = "Profibus";
            labelProfi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonInviaProfibus
            // 
            buttonInviaProfibus.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInviaProfibus.ForeColor = Color.FromArgb(45, 86, 160);
            buttonInviaProfibus.Location = new Point(483, 484);
            buttonInviaProfibus.Name = "buttonInviaProfibus";
            buttonInviaProfibus.Size = new Size(88, 33);
            buttonInviaProfibus.TabIndex = 46;
            buttonInviaProfibus.Text = "INVIA";
            buttonInviaProfibus.UseVisualStyleBackColor = true;
            buttonInviaProfibus.Click += buttonInviaProfibus_Click;
            // 
            // buttonModificaMatricola
            // 
            buttonModificaMatricola.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonModificaMatricola.ForeColor = Color.FromArgb(45, 86, 160);
            buttonModificaMatricola.Location = new Point(577, 349);
            buttonModificaMatricola.Name = "buttonModificaMatricola";
            buttonModificaMatricola.Size = new Size(88, 33);
            buttonModificaMatricola.TabIndex = 49;
            buttonModificaMatricola.Text = "MODIFICA";
            buttonModificaMatricola.UseVisualStyleBackColor = true;
            buttonModificaMatricola.Click += buttonModificaMatricola_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1384, 661);
            Controls.Add(buttonModificaMatricola);
            Controls.Add(labelProfibusOk);
            Controls.Add(labelProfi);
            Controls.Add(buttonInviaProfibus);
            Controls.Add(labelIgnitionOk);
            Controls.Add(labelModelloOk);
            Controls.Add(labelMatricolaOk);
            Controls.Add(labelIgnition);
            Controls.Add(labelModel);
            Controls.Add(labelMatricola);
            Controls.Add(buttonInviaIgnition);
            Controls.Add(buttonInviaModel);
            Controls.Add(buttonInviaMatricola);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelStatusCOM);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(buttonOpen);
            Controls.Add(iconButtonToForm4);
            Controls.Add(comboBoxCOM);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "COLLAUDO BDS.ARC V2";
            Load += Form3_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Label labelDate;
        private Label labelTime;
        private Panel panel1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label labelTitle;
        private Label label1;
        private ComboBox comboBoxCOM;
        private FontAwesome.Sharp.IconButton iconButtonToForm4;
        private Button buttonOpen;
        private Label label2;
        private Label label7;
        private Label labelStatusCOM;
        private Label label3;
        private Label label4;
        private Button buttonInviaMatricola;
        private Button buttonInviaModel;
        private Button buttonInviaIgnition;
        private Label labelMatricola;
        private Label labelModel;
        private Label labelIgnition;
        private Label labelMatricolaOk;
        private Label labelModelloOk;
        private Label labelIgnitionOk;
        private Label labelProfibusOk;
        private Label labelProfi;
        private Button buttonInviaProfibus;
        private Label labelRev;
        private Button buttonModificaMatricola;
    }
}