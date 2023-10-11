namespace ProceduraCollaudo
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panelMenu = new Panel();
            labelRev = new Label();
            labelDate = new Label();
            labelTime = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            labelTitle = new Label();
            iconButtonToForm3 = new FontAwesome.Sharp.IconButton();
            timer1 = new System.Windows.Forms.Timer(components);
            label7 = new Label();
            checkBoxCarico = new CheckBox();
            checkBoxAD = new CheckBox();
            label2 = new Label();
            checkBoxUSB = new CheckBox();
            label3 = new Label();
            checkBoxJIG = new CheckBox();
            label4 = new Label();
            checkBoxSetup = new CheckBox();
            label5 = new Label();
            checkBox400Vac = new CheckBox();
            label6 = new Label();
            checkBoxPowerOn = new CheckBox();
            label8 = new Label();
            checkBoxDisplay = new CheckBox();
            label9 = new Label();
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
            // label1
            // 
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(45, 86, 160);
            label1.Location = new Point(320, 63);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(537, 60);
            label1.TabIndex = 3;
            label1.Text = "02. Collegamenti e verifiche";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(45, 86, 160);
            labelTitle.Location = new Point(315, 3);
            labelTitle.Margin = new Padding(0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(868, 60);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Procedura di collaudo BDS.ARC V2";
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconButtonToForm3
            // 
            iconButtonToForm3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iconButtonToForm3.FlatAppearance.BorderColor = Color.White;
            iconButtonToForm3.FlatAppearance.BorderSize = 0;
            iconButtonToForm3.FlatAppearance.MouseDownBackColor = Color.White;
            iconButtonToForm3.FlatAppearance.MouseOverBackColor = Color.White;
            iconButtonToForm3.FlatStyle = FlatStyle.Flat;
            iconButtonToForm3.IconChar = FontAwesome.Sharp.IconChar.CircleChevronRight;
            iconButtonToForm3.IconColor = Color.FromArgb(45, 86, 160);
            iconButtonToForm3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonToForm3.IconSize = 64;
            iconButtonToForm3.Location = new Point(1276, 574);
            iconButtonToForm3.Name = "iconButtonToForm3";
            iconButtonToForm3.Size = new Size(96, 75);
            iconButtonToForm3.TabIndex = 5;
            iconButtonToForm3.UseVisualStyleBackColor = true;
            iconButtonToForm3.Click += iconButtonToForm3_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(45, 86, 160);
            label7.Location = new Point(324, 146);
            label7.Name = "label7";
            label7.Size = new Size(395, 33);
            label7.TabIndex = 6;
            label7.Text = "02.01. Collegare il generatore al carico";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxCarico
            // 
            checkBoxCarico.AutoSize = true;
            checkBoxCarico.FlatStyle = FlatStyle.Flat;
            checkBoxCarico.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxCarico.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxCarico.Location = new Point(774, 148);
            checkBoxCarico.Name = "checkBoxCarico";
            checkBoxCarico.Size = new Size(59, 29);
            checkBoxCarico.TabIndex = 7;
            checkBoxCarico.Text = "OK";
            checkBoxCarico.UseVisualStyleBackColor = true;
            // 
            // checkBoxAD
            // 
            checkBoxAD.AutoSize = true;
            checkBoxAD.FlatStyle = FlatStyle.Flat;
            checkBoxAD.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxAD.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxAD.Location = new Point(774, 181);
            checkBoxAD.Name = "checkBoxAD";
            checkBoxAD.Size = new Size(59, 29);
            checkBoxAD.TabIndex = 9;
            checkBoxAD.Text = "OK";
            checkBoxAD.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(45, 86, 160);
            label2.Location = new Point(324, 179);
            label2.Name = "label2";
            label2.Size = new Size(395, 33);
            label2.TabIndex = 8;
            label2.Text = "02.02. Collegare interfaccia A/D";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxUSB
            // 
            checkBoxUSB.AutoSize = true;
            checkBoxUSB.FlatStyle = FlatStyle.Flat;
            checkBoxUSB.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxUSB.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxUSB.Location = new Point(774, 214);
            checkBoxUSB.Name = "checkBoxUSB";
            checkBoxUSB.Size = new Size(59, 29);
            checkBoxUSB.TabIndex = 11;
            checkBoxUSB.Text = "OK";
            checkBoxUSB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(45, 86, 160);
            label3.Location = new Point(324, 212);
            label3.Name = "label3";
            label3.Size = new Size(395, 33);
            label3.TabIndex = 10;
            label3.Text = "02.03. Collegare il cavo USB";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxJIG
            // 
            checkBoxJIG.AutoSize = true;
            checkBoxJIG.FlatStyle = FlatStyle.Flat;
            checkBoxJIG.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxJIG.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxJIG.Location = new Point(774, 247);
            checkBoxJIG.Name = "checkBoxJIG";
            checkBoxJIG.Size = new Size(59, 29);
            checkBoxJIG.TabIndex = 13;
            checkBoxJIG.Text = "OK";
            checkBoxJIG.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(45, 86, 160);
            label4.Location = new Point(324, 245);
            label4.Name = "label4";
            label4.Size = new Size(395, 33);
            label4.TabIndex = 12;
            label4.Text = "02.04. Verificare ILK e ON disabilitati sul JIG";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxSetup
            // 
            checkBoxSetup.AutoSize = true;
            checkBoxSetup.FlatStyle = FlatStyle.Flat;
            checkBoxSetup.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxSetup.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxSetup.Location = new Point(774, 280);
            checkBoxSetup.Name = "checkBoxSetup";
            checkBoxSetup.Size = new Size(59, 29);
            checkBoxSetup.TabIndex = 15;
            checkBoxSetup.Text = "OK";
            checkBoxSetup.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(45, 86, 160);
            label5.Location = new Point(324, 278);
            label5.Name = "label5";
            label5.Size = new Size(444, 33);
            label5.TabIndex = 14;
            label5.Text = "02.05. Collegare oscilloscopio e impostare setup ARC0";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBox400Vac
            // 
            checkBox400Vac.AutoSize = true;
            checkBox400Vac.FlatStyle = FlatStyle.Flat;
            checkBox400Vac.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox400Vac.ForeColor = Color.FromArgb(45, 86, 160);
            checkBox400Vac.Location = new Point(774, 313);
            checkBox400Vac.Name = "checkBox400Vac";
            checkBox400Vac.Size = new Size(59, 29);
            checkBox400Vac.TabIndex = 17;
            checkBox400Vac.Text = "OK";
            checkBox400Vac.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(45, 86, 160);
            label6.Location = new Point(324, 311);
            label6.Name = "label6";
            label6.Size = new Size(395, 33);
            label6.TabIndex = 16;
            label6.Text = "02.06. Collegare il generatore alla rete 400Vac";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxPowerOn
            // 
            checkBoxPowerOn.AutoSize = true;
            checkBoxPowerOn.FlatStyle = FlatStyle.Flat;
            checkBoxPowerOn.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxPowerOn.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxPowerOn.Location = new Point(774, 346);
            checkBoxPowerOn.Name = "checkBoxPowerOn";
            checkBoxPowerOn.Size = new Size(59, 29);
            checkBoxPowerOn.TabIndex = 19;
            checkBoxPowerOn.Text = "OK";
            checkBoxPowerOn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(45, 86, 160);
            label8.Location = new Point(324, 344);
            label8.Name = "label8";
            label8.Size = new Size(395, 33);
            label8.TabIndex = 18;
            label8.Text = "02.07. Accendere il generatore";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxDisplay
            // 
            checkBoxDisplay.AutoSize = true;
            checkBoxDisplay.FlatStyle = FlatStyle.Flat;
            checkBoxDisplay.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxDisplay.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxDisplay.Location = new Point(774, 379);
            checkBoxDisplay.Name = "checkBoxDisplay";
            checkBoxDisplay.Size = new Size(59, 29);
            checkBoxDisplay.TabIndex = 21;
            checkBoxDisplay.Text = "OK";
            checkBoxDisplay.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(45, 86, 160);
            label9.Location = new Point(324, 377);
            label9.Name = "label9";
            label9.Size = new Size(395, 33);
            label9.TabIndex = 20;
            label9.Text = "02.08. Verificare la luminosità del display (P1)";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1384, 661);
            Controls.Add(checkBoxDisplay);
            Controls.Add(label9);
            Controls.Add(checkBoxPowerOn);
            Controls.Add(label8);
            Controls.Add(checkBox400Vac);
            Controls.Add(label6);
            Controls.Add(checkBoxSetup);
            Controls.Add(label5);
            Controls.Add(checkBoxJIG);
            Controls.Add(label4);
            Controls.Add(checkBoxUSB);
            Controls.Add(label3);
            Controls.Add(checkBoxAD);
            Controls.Add(label2);
            Controls.Add(checkBoxCarico);
            Controls.Add(label7);
            Controls.Add(iconButtonToForm3);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "COLLAUDO BDS.ARC V2";
            Load += Form2_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Label labelDate;
        private Label labelTime;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label labelTitle;
        private FontAwesome.Sharp.IconButton iconButtonToForm3;
        private System.Windows.Forms.Timer timer1;
        private Label label7;
        private CheckBox checkBoxCarico;
        private CheckBox checkBoxAD;
        private Label label2;
        private CheckBox checkBoxUSB;
        private Label label3;
        private CheckBox checkBoxJIG;
        private Label label4;
        private CheckBox checkBoxSetup;
        private Label label5;
        private CheckBox checkBox400Vac;
        private Label label6;
        private Label labelRev;
        private CheckBox checkBoxPowerOn;
        private Label label8;
        private CheckBox checkBoxDisplay;
        private Label label9;
    }
}