namespace ProceduraCollaudo
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            panelMenu = new Panel();
            labelRev = new Label();
            labelDate = new Label();
            labelTime = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            labelTitle = new Label();
            label1 = new Label();
            iconButtonToForm6 = new FontAwesome.Sharp.IconButton();
            timer1 = new System.Windows.Forms.Timer(components);
            checkBoxInverter = new CheckBox();
            label7 = new Label();
            checkBoxInterlock = new CheckBox();
            label2 = new Label();
            checkBoxJumper = new CheckBox();
            label3 = new Label();
            labelSpa50 = new Label();
            buttonSpa50 = new Button();
            label4 = new Label();
            checkBoxSetOk = new CheckBox();
            label5 = new Label();
            labelCen1 = new Label();
            buttonCen1 = new Button();
            label8 = new Label();
            checkBoxLed = new CheckBox();
            label6 = new Label();
            checkBoxGate = new CheckBox();
            label9 = new Label();
            checkBoxPWM = new CheckBox();
            label11 = new Label();
            checkBoxMaxCurrent = new CheckBox();
            label12 = new Label();
            checkBoxFan = new CheckBox();
            label10 = new Label();
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
            panelMenu.TabIndex = 1;
            // 
            // labelRev
            // 
            labelRev.Dock = DockStyle.Top;
            labelRev.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelRev.ForeColor = Color.White;
            labelRev.Location = new Point(0, 58);
            labelRev.Name = "labelRev";
            labelRev.Size = new Size(300, 60);
            labelRev.TabIndex = 4;
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
            // labelTitle
            // 
            labelTitle.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(45, 86, 160);
            labelTitle.Location = new Point(315, 3);
            labelTitle.Margin = new Padding(0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(868, 60);
            labelTitle.TabIndex = 3;
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
            label1.Size = new Size(1039, 60);
            label1.TabIndex = 8;
            label1.Text = "05. Accensione e prime impostazioni / tarature";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconButtonToForm6
            // 
            iconButtonToForm6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iconButtonToForm6.FlatAppearance.BorderColor = Color.White;
            iconButtonToForm6.FlatAppearance.BorderSize = 0;
            iconButtonToForm6.FlatAppearance.MouseDownBackColor = Color.White;
            iconButtonToForm6.FlatAppearance.MouseOverBackColor = Color.White;
            iconButtonToForm6.FlatStyle = FlatStyle.Flat;
            iconButtonToForm6.IconChar = FontAwesome.Sharp.IconChar.CircleChevronRight;
            iconButtonToForm6.IconColor = Color.FromArgb(45, 86, 160);
            iconButtonToForm6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonToForm6.IconSize = 64;
            iconButtonToForm6.Location = new Point(1276, 574);
            iconButtonToForm6.Name = "iconButtonToForm6";
            iconButtonToForm6.Size = new Size(96, 75);
            iconButtonToForm6.TabIndex = 10;
            iconButtonToForm6.UseVisualStyleBackColor = true;
            iconButtonToForm6.Click += iconButtonToForm6_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // checkBoxInverter
            // 
            checkBoxInverter.AutoSize = true;
            checkBoxInverter.FlatStyle = FlatStyle.Flat;
            checkBoxInverter.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxInverter.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxInverter.Location = new Point(774, 148);
            checkBoxInverter.Name = "checkBoxInverter";
            checkBoxInverter.Size = new Size(59, 29);
            checkBoxInverter.TabIndex = 12;
            checkBoxInverter.Text = "OK";
            checkBoxInverter.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(45, 86, 160);
            label7.Location = new Point(324, 146);
            label7.Name = "label7";
            label7.Size = new Size(395, 33);
            label7.TabIndex = 11;
            label7.Text = "05.01. Verificare LED spenti sull'inverter";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxInterlock
            // 
            checkBoxInterlock.AutoSize = true;
            checkBoxInterlock.FlatStyle = FlatStyle.Flat;
            checkBoxInterlock.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxInterlock.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxInterlock.Location = new Point(774, 181);
            checkBoxInterlock.Name = "checkBoxInterlock";
            checkBoxInterlock.Size = new Size(59, 29);
            checkBoxInterlock.TabIndex = 14;
            checkBoxInterlock.Text = "OK";
            checkBoxInterlock.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(45, 86, 160);
            label2.Location = new Point(324, 179);
            label2.Name = "label2";
            label2.Size = new Size(395, 33);
            label2.TabIndex = 13;
            label2.Text = "05.02. Impostare Interlock ON sul JIG";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxJumper
            // 
            checkBoxJumper.AutoSize = true;
            checkBoxJumper.FlatStyle = FlatStyle.Flat;
            checkBoxJumper.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxJumper.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxJumper.Location = new Point(774, 214);
            checkBoxJumper.Name = "checkBoxJumper";
            checkBoxJumper.Size = new Size(59, 29);
            checkBoxJumper.TabIndex = 16;
            checkBoxJumper.Text = "OK";
            checkBoxJumper.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(45, 86, 160);
            label3.Location = new Point(324, 212);
            label3.Name = "label3";
            label3.Size = new Size(395, 33);
            label3.TabIndex = 15;
            label3.Text = "05.03. Inserire jumper BUS OK (JP7)";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSpa50
            // 
            labelSpa50.Anchor = AnchorStyles.Left;
            labelSpa50.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSpa50.ForeColor = Color.White;
            labelSpa50.Location = new Point(418, 320);
            labelSpa50.Name = "labelSpa50";
            labelSpa50.Size = new Size(123, 23);
            labelSpa50.TabIndex = 49;
            labelSpa50.Text = "ERR";
            labelSpa50.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonSpa50
            // 
            buttonSpa50.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSpa50.ForeColor = Color.FromArgb(45, 86, 160);
            buttonSpa50.Location = new Point(324, 314);
            buttonSpa50.Name = "buttonSpa50";
            buttonSpa50.Size = new Size(88, 33);
            buttonSpa50.TabIndex = 48;
            buttonSpa50.Text = "SPA50";
            buttonSpa50.UseVisualStyleBackColor = true;
            buttonSpa50.Click += buttonSpa50_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(45, 86, 160);
            label4.Location = new Point(324, 278);
            label4.Name = "label4";
            label4.Size = new Size(439, 33);
            label4.TabIndex = 47;
            label4.Text = "05.05. Impostare un setpoint di 50A";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxSetOk
            // 
            checkBoxSetOk.AutoSize = true;
            checkBoxSetOk.FlatStyle = FlatStyle.Flat;
            checkBoxSetOk.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxSetOk.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxSetOk.Location = new Point(774, 352);
            checkBoxSetOk.Name = "checkBoxSetOk";
            checkBoxSetOk.Size = new Size(59, 29);
            checkBoxSetOk.TabIndex = 51;
            checkBoxSetOk.Text = "OK";
            checkBoxSetOk.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(45, 86, 160);
            label5.Location = new Point(324, 350);
            label5.Name = "label5";
            label5.Size = new Size(413, 33);
            label5.TabIndex = 50;
            label5.Text = "05.06. Verificare il corretto setpoint sul display (Set)";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCen1
            // 
            labelCen1.Anchor = AnchorStyles.Left;
            labelCen1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCen1.ForeColor = Color.White;
            labelCen1.Location = new Point(418, 425);
            labelCen1.Name = "labelCen1";
            labelCen1.Size = new Size(123, 23);
            labelCen1.TabIndex = 54;
            labelCen1.Text = "ERR";
            labelCen1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonCen1
            // 
            buttonCen1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCen1.ForeColor = Color.FromArgb(45, 86, 160);
            buttonCen1.Location = new Point(324, 419);
            buttonCen1.Name = "buttonCen1";
            buttonCen1.Size = new Size(88, 33);
            buttonCen1.TabIndex = 53;
            buttonCen1.Text = "CEN1";
            buttonCen1.UseVisualStyleBackColor = true;
            buttonCen1.Click += buttonCen1_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(45, 86, 160);
            label8.Location = new Point(324, 383);
            label8.Name = "label8";
            label8.Size = new Size(439, 33);
            label8.TabIndex = 52;
            label8.Text = "05.07. Abilitare l'uscita";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxLed
            // 
            checkBoxLed.AutoSize = true;
            checkBoxLed.FlatStyle = FlatStyle.Flat;
            checkBoxLed.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxLed.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxLed.Location = new Point(774, 247);
            checkBoxLed.Name = "checkBoxLed";
            checkBoxLed.Size = new Size(59, 29);
            checkBoxLed.TabIndex = 56;
            checkBoxLed.Text = "OK";
            checkBoxLed.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(45, 86, 160);
            label6.Location = new Point(324, 245);
            label6.Name = "label6";
            label6.Size = new Size(395, 33);
            label6.TabIndex = 55;
            label6.Text = "05.04. Verificare LED D30";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxGate
            // 
            checkBoxGate.AutoSize = true;
            checkBoxGate.FlatStyle = FlatStyle.Flat;
            checkBoxGate.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxGate.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxGate.Location = new Point(774, 457);
            checkBoxGate.Name = "checkBoxGate";
            checkBoxGate.Size = new Size(59, 29);
            checkBoxGate.TabIndex = 58;
            checkBoxGate.Text = "OK";
            checkBoxGate.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(45, 86, 160);
            label9.Location = new Point(324, 455);
            label9.Name = "label9";
            label9.Size = new Size(413, 33);
            label9.TabIndex = 57;
            label9.Text = "05.08. Verificare accensione gate e LED D31";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxPWM
            // 
            checkBoxPWM.AutoSize = true;
            checkBoxPWM.FlatStyle = FlatStyle.Flat;
            checkBoxPWM.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxPWM.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxPWM.Location = new Point(774, 490);
            checkBoxPWM.Name = "checkBoxPWM";
            checkBoxPWM.Size = new Size(59, 29);
            checkBoxPWM.TabIndex = 62;
            checkBoxPWM.Text = "OK";
            checkBoxPWM.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(45, 86, 160);
            label11.Location = new Point(324, 488);
            label11.Name = "label11";
            label11.Size = new Size(413, 33);
            label11.TabIndex = 61;
            label11.Text = "05.09. Impostare frequenza di gate (TP60) a 34kHz";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxMaxCurrent
            // 
            checkBoxMaxCurrent.AutoSize = true;
            checkBoxMaxCurrent.FlatStyle = FlatStyle.Flat;
            checkBoxMaxCurrent.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxMaxCurrent.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxMaxCurrent.Location = new Point(774, 523);
            checkBoxMaxCurrent.Name = "checkBoxMaxCurrent";
            checkBoxMaxCurrent.Size = new Size(59, 29);
            checkBoxMaxCurrent.TabIndex = 64;
            checkBoxMaxCurrent.Text = "OK";
            checkBoxMaxCurrent.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(45, 86, 160);
            label12.Location = new Point(324, 521);
            label12.Name = "label12";
            label12.Size = new Size(413, 33);
            label12.TabIndex = 63;
            label12.Text = "05.10. Desensibilizzare massima corrente (P3)";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxFan
            // 
            checkBoxFan.AutoSize = true;
            checkBoxFan.FlatStyle = FlatStyle.Flat;
            checkBoxFan.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxFan.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxFan.Location = new Point(774, 556);
            checkBoxFan.Name = "checkBoxFan";
            checkBoxFan.Size = new Size(59, 29);
            checkBoxFan.TabIndex = 66;
            checkBoxFan.Text = "OK";
            checkBoxFan.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(45, 86, 160);
            label10.Location = new Point(324, 554);
            label10.Name = "label10";
            label10.Size = new Size(413, 33);
            label10.TabIndex = 65;
            label10.Text = "05.11. Verificare il funzionamento delle ventole";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1384, 661);
            Controls.Add(checkBoxFan);
            Controls.Add(label10);
            Controls.Add(checkBoxMaxCurrent);
            Controls.Add(label12);
            Controls.Add(checkBoxPWM);
            Controls.Add(label11);
            Controls.Add(checkBoxGate);
            Controls.Add(label9);
            Controls.Add(checkBoxLed);
            Controls.Add(label6);
            Controls.Add(labelCen1);
            Controls.Add(buttonCen1);
            Controls.Add(label8);
            Controls.Add(checkBoxSetOk);
            Controls.Add(label5);
            Controls.Add(labelSpa50);
            Controls.Add(buttonSpa50);
            Controls.Add(label4);
            Controls.Add(checkBoxJumper);
            Controls.Add(label3);
            Controls.Add(checkBoxInterlock);
            Controls.Add(label2);
            Controls.Add(checkBoxInverter);
            Controls.Add(label7);
            Controls.Add(iconButtonToForm6);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "COLLAUDO BDS.ARC V2";
            Load += Form5_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Label labelRev;
        private Label labelDate;
        private Label labelTime;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelTitle;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButtonToForm6;
        private System.Windows.Forms.Timer timer1;
        private CheckBox checkBoxInverter;
        private Label label7;
        private CheckBox checkBoxInterlock;
        private Label label2;
        private CheckBox checkBoxJumper;
        private Label label3;
        private Label labelSpa50;
        private Button buttonSpa50;
        private Label label4;
        private CheckBox checkBoxSetOk;
        private Label label5;
        private Label labelCen1;
        private Button buttonCen1;
        private Label label8;
        private CheckBox checkBoxLed;
        private Label label6;
        private CheckBox checkBoxGate;
        private Label label9;
        private CheckBox checkBoxPWM;
        private Label label11;
        private CheckBox checkBoxMaxCurrent;
        private Label label12;
        private CheckBox checkBoxFan;
        private Label label10;
    }
}