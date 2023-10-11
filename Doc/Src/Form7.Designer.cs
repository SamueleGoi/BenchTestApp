namespace ProceduraCollaudo
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            panelMenu = new Panel();
            labelRev = new Label();
            labelDate = new Label();
            labelTime = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            iconButtonToForm6 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            labelTitle = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            labelStart = new Label();
            labelSpa = new Label();
            buttonSpa = new Button();
            label3 = new Label();
            buttonCen0 = new Button();
            labelCen1 = new Label();
            buttonCen1 = new Button();
            label2 = new Label();
            textBoxOperatore = new TextBox();
            label7 = new Label();
            button1 = new Button();
            label4 = new Label();
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
            panelMenu.TabIndex = 3;
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
            iconButtonToForm6.TabIndex = 18;
            iconButtonToForm6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(45, 86, 160);
            label1.Location = new Point(320, 63);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(1039, 60);
            label1.TabIndex = 17;
            label1.Text = "07. Calibrazioni";
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
            labelTitle.TabIndex = 16;
            labelTitle.Text = "Procedura di collaudo BDS.ARC V2";
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // labelStart
            // 
            labelStart.Anchor = AnchorStyles.Left;
            labelStart.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelStart.ForeColor = Color.FromArgb(45, 86, 160);
            labelStart.Location = new Point(324, 146);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(859, 33);
            labelStart.TabIndex = 19;
            labelStart.Text = "07.01. Impostare un setpoint di 200A e verificare il corretto setpoint sul display ";
            labelStart.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSpa
            // 
            labelSpa.Anchor = AnchorStyles.Left;
            labelSpa.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSpa.ForeColor = Color.White;
            labelSpa.Location = new Point(418, 188);
            labelSpa.Name = "labelSpa";
            labelSpa.Size = new Size(123, 23);
            labelSpa.TabIndex = 61;
            labelSpa.Text = "ERR";
            labelSpa.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonSpa
            // 
            buttonSpa.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSpa.ForeColor = Color.FromArgb(45, 86, 160);
            buttonSpa.Location = new Point(324, 182);
            buttonSpa.Name = "buttonSpa";
            buttonSpa.Size = new Size(88, 33);
            buttonSpa.TabIndex = 60;
            buttonSpa.Text = "SPA200";
            buttonSpa.UseVisualStyleBackColor = true;
            buttonSpa.Click += buttonSpa_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(45, 86, 160);
            label3.Location = new Point(324, 218);
            label3.Name = "label3";
            label3.Size = new Size(859, 33);
            label3.TabIndex = 62;
            label3.Text = "07.02. Abilitare l'uscita (CEN1 per accendere)";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonCen0
            // 
            buttonCen0.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCen0.ForeColor = Color.FromArgb(45, 86, 160);
            buttonCen0.Location = new Point(418, 254);
            buttonCen0.Name = "buttonCen0";
            buttonCen0.Size = new Size(88, 33);
            buttonCen0.TabIndex = 70;
            buttonCen0.Text = "CEN0";
            buttonCen0.UseVisualStyleBackColor = true;
            buttonCen0.Click += buttonCen0_Click;
            // 
            // labelCen1
            // 
            labelCen1.Anchor = AnchorStyles.Left;
            labelCen1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCen1.ForeColor = Color.White;
            labelCen1.Location = new Point(514, 260);
            labelCen1.Name = "labelCen1";
            labelCen1.Size = new Size(123, 23);
            labelCen1.TabIndex = 69;
            labelCen1.Text = "ERR";
            labelCen1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonCen1
            // 
            buttonCen1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCen1.ForeColor = Color.FromArgb(45, 86, 160);
            buttonCen1.Location = new Point(324, 254);
            buttonCen1.Name = "buttonCen1";
            buttonCen1.Size = new Size(88, 33);
            buttonCen1.TabIndex = 68;
            buttonCen1.Text = "CEN1";
            buttonCen1.UseVisualStyleBackColor = true;
            buttonCen1.Click += buttonCen1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(45, 86, 160);
            label2.Location = new Point(324, 290);
            label2.Name = "label2";
            label2.Size = new Size(859, 33);
            label2.TabIndex = 71;
            label2.Text = "07.03. Tarare PWM e riletture";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxOperatore
            // 
            textBoxOperatore.BorderStyle = BorderStyle.FixedSingle;
            textBoxOperatore.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOperatore.ForeColor = Color.FromArgb(45, 86, 160);
            textBoxOperatore.Location = new Point(324, 326);
            textBoxOperatore.Name = "textBoxOperatore";
            textBoxOperatore.Size = new Size(223, 33);
            textBoxOperatore.TabIndex = 73;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(45, 86, 160);
            label7.Location = new Point(554, 326);
            label7.Name = "label7";
            label7.Size = new Size(310, 33);
            label7.TabIndex = 72;
            label7.Text = "Inserire parametro";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(45, 86, 160);
            button1.Location = new Point(324, 365);
            button1.Name = "button1";
            button1.Size = new Size(88, 33);
            button1.TabIndex = 75;
            button1.Text = "INVIA";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(420, 371);
            label4.Name = "label4";
            label4.Size = new Size(123, 23);
            label4.TabIndex = 74;
            label4.Text = "ERR";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1384, 661);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBoxOperatore);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(buttonCen0);
            Controls.Add(labelCen1);
            Controls.Add(buttonCen1);
            Controls.Add(label3);
            Controls.Add(labelSpa);
            Controls.Add(buttonSpa);
            Controls.Add(labelStart);
            Controls.Add(iconButtonToForm6);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "COLLAUDO BDS.ARC V2";
            Load += Form7_Load;
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
        private FontAwesome.Sharp.IconButton iconButtonToForm6;
        private Label label1;
        private Label labelTitle;
        private System.Windows.Forms.Timer timer1;
        private Label labelStart;
        private Label labelSpa;
        private Button buttonSpa;
        private Label label3;
        private Button buttonCen0;
        private Label labelCen1;
        private Button buttonCen1;
        private Label label2;
        private TextBox textBoxOperatore;
        private Label label7;
        private Button button1;
        private Label label4;
    }
}