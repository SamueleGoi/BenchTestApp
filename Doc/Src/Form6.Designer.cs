namespace ProceduraCollaudo
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            panelMenu = new Panel();
            labelRev = new Label();
            labelDate = new Label();
            labelTime = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            labelTitle = new Label();
            label1 = new Label();
            checkBoxIdle = new CheckBox();
            label7 = new Label();
            iconButtonToForm6 = new FontAwesome.Sharp.IconButton();
            labelCen1 = new Label();
            buttonCen1 = new Button();
            label8 = new Label();
            checkBoxSetOk = new CheckBox();
            label5 = new Label();
            checkBoxFunct = new CheckBox();
            label2 = new Label();
            checkBoxLed = new CheckBox();
            label3 = new Label();
            checkBoxJumper = new CheckBox();
            label4 = new Label();
            buttonCen0 = new Button();
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
            // timer1
            // 
            timer1.Enabled = true;
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
            labelTitle.TabIndex = 4;
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
            label1.TabIndex = 9;
            label1.Text = "06. Verifica BUS DC e accensione";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxIdle
            // 
            checkBoxIdle.AutoSize = true;
            checkBoxIdle.FlatStyle = FlatStyle.Flat;
            checkBoxIdle.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxIdle.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxIdle.Location = new Point(774, 148);
            checkBoxIdle.Name = "checkBoxIdle";
            checkBoxIdle.Size = new Size(59, 29);
            checkBoxIdle.TabIndex = 14;
            checkBoxIdle.Text = "OK";
            checkBoxIdle.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(45, 86, 160);
            label7.Location = new Point(324, 146);
            label7.Name = "label7";
            label7.Size = new Size(395, 33);
            label7.TabIndex = 13;
            label7.Text = "06.01. Verificare Mode IDLE sul display";
            label7.TextAlign = ContentAlignment.MiddleLeft;
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
            iconButtonToForm6.TabIndex = 15;
            iconButtonToForm6.UseVisualStyleBackColor = true;
            iconButtonToForm6.Click += iconButtonToForm6_Click;
            // 
            // labelCen1
            // 
            labelCen1.Anchor = AnchorStyles.Left;
            labelCen1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCen1.ForeColor = Color.White;
            labelCen1.Location = new Point(514, 287);
            labelCen1.Name = "labelCen1";
            labelCen1.Size = new Size(123, 23);
            labelCen1.TabIndex = 59;
            labelCen1.Text = "ERR";
            labelCen1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonCen1
            // 
            buttonCen1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCen1.ForeColor = Color.FromArgb(45, 86, 160);
            buttonCen1.Location = new Point(324, 281);
            buttonCen1.Name = "buttonCen1";
            buttonCen1.Size = new Size(88, 33);
            buttonCen1.TabIndex = 58;
            buttonCen1.Text = "CEN1";
            buttonCen1.UseVisualStyleBackColor = true;
            buttonCen1.Click += buttonCen1_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(45, 86, 160);
            label8.Location = new Point(324, 212);
            label8.Name = "label8";
            label8.Size = new Size(439, 33);
            label8.TabIndex = 57;
            label8.Text = "06.03. Rimuovere il jumper BUS OK (JP7) ";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxSetOk
            // 
            checkBoxSetOk.AutoSize = true;
            checkBoxSetOk.FlatStyle = FlatStyle.Flat;
            checkBoxSetOk.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxSetOk.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxSetOk.Location = new Point(774, 181);
            checkBoxSetOk.Name = "checkBoxSetOk";
            checkBoxSetOk.Size = new Size(59, 29);
            checkBoxSetOk.TabIndex = 56;
            checkBoxSetOk.Text = "OK";
            checkBoxSetOk.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(45, 86, 160);
            label5.Location = new Point(324, 179);
            label5.Name = "label5";
            label5.Size = new Size(413, 33);
            label5.TabIndex = 55;
            label5.Text = "06.02. Verificare 50A come setpoint";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxFunct
            // 
            checkBoxFunct.AutoSize = true;
            checkBoxFunct.FlatStyle = FlatStyle.Flat;
            checkBoxFunct.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxFunct.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxFunct.Location = new Point(774, 319);
            checkBoxFunct.Name = "checkBoxFunct";
            checkBoxFunct.Size = new Size(59, 29);
            checkBoxFunct.TabIndex = 61;
            checkBoxFunct.Text = "OK";
            checkBoxFunct.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(45, 86, 160);
            label2.Location = new Point(324, 317);
            label2.Name = "label2";
            label2.Size = new Size(413, 33);
            label2.TabIndex = 60;
            label2.Text = "06.05. Verificare il corretto funzionamento";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxLed
            // 
            checkBoxLed.AutoSize = true;
            checkBoxLed.FlatStyle = FlatStyle.Flat;
            checkBoxLed.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxLed.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxLed.Location = new Point(774, 352);
            checkBoxLed.Name = "checkBoxLed";
            checkBoxLed.Size = new Size(59, 29);
            checkBoxLed.TabIndex = 63;
            checkBoxLed.Text = "OK";
            checkBoxLed.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(45, 86, 160);
            label3.Location = new Point(324, 350);
            label3.Name = "label3";
            label3.Size = new Size(413, 33);
            label3.TabIndex = 62;
            label3.Text = "06.06. Verificare LED accesi sull'inverter";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxJumper
            // 
            checkBoxJumper.AutoSize = true;
            checkBoxJumper.FlatStyle = FlatStyle.Flat;
            checkBoxJumper.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxJumper.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxJumper.Location = new Point(774, 216);
            checkBoxJumper.Name = "checkBoxJumper";
            checkBoxJumper.Size = new Size(59, 29);
            checkBoxJumper.TabIndex = 65;
            checkBoxJumper.Text = "OK";
            checkBoxJumper.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(45, 86, 160);
            label4.Location = new Point(324, 245);
            label4.Name = "label4";
            label4.Size = new Size(439, 33);
            label4.TabIndex = 66;
            label4.Text = "06.04. Abilitare l'uscita (CEN1 per accendere)";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonCen0
            // 
            buttonCen0.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCen0.ForeColor = Color.FromArgb(45, 86, 160);
            buttonCen0.Location = new Point(418, 281);
            buttonCen0.Name = "buttonCen0";
            buttonCen0.Size = new Size(88, 33);
            buttonCen0.TabIndex = 67;
            buttonCen0.Text = "CEN0";
            buttonCen0.UseVisualStyleBackColor = true;
            buttonCen0.Click += buttonCen0_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1384, 661);
            Controls.Add(buttonCen0);
            Controls.Add(label4);
            Controls.Add(checkBoxJumper);
            Controls.Add(checkBoxLed);
            Controls.Add(label3);
            Controls.Add(checkBoxFunct);
            Controls.Add(label2);
            Controls.Add(labelCen1);
            Controls.Add(buttonCen1);
            Controls.Add(label8);
            Controls.Add(checkBoxSetOk);
            Controls.Add(label5);
            Controls.Add(iconButtonToForm6);
            Controls.Add(checkBoxIdle);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "COLLAUDO BDS.ARC V2";
            Load += Form6_Load;
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
        private System.Windows.Forms.Timer timer1;
        private Label labelTitle;
        private Label label1;
        private CheckBox checkBoxIdle;
        private Label label7;
        private FontAwesome.Sharp.IconButton iconButtonToForm6;
        private Label labelCen1;
        private Button buttonCen1;
        private Label label8;
        private CheckBox checkBoxSetOk;
        private Label label5;
        private CheckBox checkBoxFunct;
        private Label label2;
        private CheckBox checkBoxLed;
        private Label label3;
        private CheckBox checkBoxJumper;
        private Label label4;
        private Button buttonCen0;
    }
}