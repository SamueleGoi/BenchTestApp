namespace ProceduraCollaudo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            labelRev = new Label();
            labelDate = new Label();
            labelTime = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            iconButtonToForm2 = new FontAwesome.Sharp.IconButton();
            labelTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            textBoxOperatore = new TextBox();
            label3 = new Label();
            textBoxMatricola = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            checkBox150A = new CheckBox();
            checkBox250A = new CheckBox();
            checkBoxProfiYes = new CheckBox();
            checkBoxIgnitionYes = new CheckBox();
            checkBox1 = new CheckBox();
            checkBoxIgnitionNo = new CheckBox();
            checkBoxProfiNo = new CheckBox();
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
            panelMenu.TabIndex = 0;
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
            // iconButtonToForm2
            // 
            iconButtonToForm2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iconButtonToForm2.FlatAppearance.BorderColor = Color.White;
            iconButtonToForm2.FlatAppearance.BorderSize = 0;
            iconButtonToForm2.FlatAppearance.MouseDownBackColor = Color.White;
            iconButtonToForm2.FlatAppearance.MouseOverBackColor = Color.White;
            iconButtonToForm2.FlatStyle = FlatStyle.Flat;
            iconButtonToForm2.IconChar = FontAwesome.Sharp.IconChar.CircleChevronRight;
            iconButtonToForm2.IconColor = Color.FromArgb(45, 86, 160);
            iconButtonToForm2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonToForm2.IconSize = 64;
            iconButtonToForm2.Location = new Point(1276, 574);
            iconButtonToForm2.Name = "iconButtonToForm2";
            iconButtonToForm2.Size = new Size(96, 75);
            iconButtonToForm2.TabIndex = 1;
            iconButtonToForm2.UseVisualStyleBackColor = true;
            iconButtonToForm2.Click += iconButtonToForm2_Click;
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(45, 86, 160);
            labelTitle.Location = new Point(315, 3);
            labelTitle.Margin = new Padding(0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(868, 60);
            labelTitle.TabIndex = 2;
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
            label1.Size = new Size(354, 60);
            label1.TabIndex = 2;
            label1.Text = "01. Inserimento dati";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(45, 86, 160);
            label2.Location = new Point(324, 146);
            label2.Name = "label2";
            label2.Size = new Size(310, 33);
            label2.TabIndex = 2;
            label2.Text = "Operatore:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxOperatore
            // 
            textBoxOperatore.BorderStyle = BorderStyle.FixedSingle;
            textBoxOperatore.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOperatore.ForeColor = Color.FromArgb(45, 86, 160);
            textBoxOperatore.Location = new Point(324, 182);
            textBoxOperatore.Name = "textBoxOperatore";
            textBoxOperatore.PlaceholderText = "Nome Cognome";
            textBoxOperatore.Size = new Size(223, 33);
            textBoxOperatore.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(45, 86, 160);
            label3.Location = new Point(324, 239);
            label3.Name = "label3";
            label3.Size = new Size(310, 33);
            label3.TabIndex = 2;
            label3.Text = "Matricola:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxMatricola
            // 
            textBoxMatricola.BorderStyle = BorderStyle.FixedSingle;
            textBoxMatricola.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMatricola.ForeColor = Color.FromArgb(45, 86, 160);
            textBoxMatricola.Location = new Point(324, 275);
            textBoxMatricola.Name = "textBoxMatricola";
            textBoxMatricola.PlaceholderText = "YYMM.V.XXYYYY";
            textBoxMatricola.Size = new Size(223, 33);
            textBoxMatricola.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(45, 86, 160);
            label4.Location = new Point(324, 335);
            label4.Name = "label4";
            label4.Size = new Size(310, 33);
            label4.TabIndex = 2;
            label4.Text = "Modello:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(45, 86, 160);
            label5.Location = new Point(324, 431);
            label5.Name = "label5";
            label5.Size = new Size(310, 33);
            label5.TabIndex = 2;
            label5.Text = "Profibus:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(45, 86, 160);
            label6.Location = new Point(324, 518);
            label6.Name = "label6";
            label6.Size = new Size(310, 33);
            label6.TabIndex = 2;
            label6.Text = "Ignition:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(45, 86, 160);
            label7.Location = new Point(554, 182);
            label7.Name = "label7";
            label7.Size = new Size(310, 33);
            label7.TabIndex = 2;
            label7.Text = "Inserire il nome dell'operatore";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(45, 86, 160);
            label8.Location = new Point(554, 275);
            label8.Name = "label8";
            label8.Size = new Size(412, 33);
            label8.TabIndex = 2;
            label8.Text = "Inserire il numero di matricola del generatore";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(45, 86, 160);
            label9.Location = new Point(554, 364);
            label9.Name = "label9";
            label9.Size = new Size(310, 33);
            label9.TabIndex = 2;
            label9.Text = "Inserire il modello del generatore";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(45, 86, 160);
            label10.Location = new Point(554, 457);
            label10.Name = "label10";
            label10.Size = new Size(310, 33);
            label10.TabIndex = 2;
            label10.Text = "Modulo Profibus installato?";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(45, 86, 160);
            label11.Location = new Point(554, 550);
            label11.Name = "label11";
            label11.Size = new Size(310, 33);
            label11.TabIndex = 2;
            label11.Text = "Modulo ignition installato?";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBox150A
            // 
            checkBox150A.AutoSize = true;
            checkBox150A.FlatStyle = FlatStyle.Flat;
            checkBox150A.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox150A.ForeColor = Color.FromArgb(45, 86, 160);
            checkBox150A.Location = new Point(324, 368);
            checkBox150A.Name = "checkBox150A";
            checkBox150A.Size = new Size(80, 29);
            checkBox150A.TabIndex = 4;
            checkBox150A.Text = "150A";
            checkBox150A.UseVisualStyleBackColor = true;
            checkBox150A.CheckedChanged += checkBox150A_CheckedChanged;
            // 
            // checkBox250A
            // 
            checkBox250A.AutoSize = true;
            checkBox250A.FlatStyle = FlatStyle.Flat;
            checkBox250A.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox250A.ForeColor = Color.FromArgb(45, 86, 160);
            checkBox250A.Location = new Point(467, 368);
            checkBox250A.Name = "checkBox250A";
            checkBox250A.Size = new Size(80, 29);
            checkBox250A.TabIndex = 4;
            checkBox250A.Text = "250A";
            checkBox250A.UseVisualStyleBackColor = true;
            checkBox250A.CheckedChanged += checkBox250A_CheckedChanged;
            // 
            // checkBoxProfiYes
            // 
            checkBoxProfiYes.AutoSize = true;
            checkBoxProfiYes.FlatStyle = FlatStyle.Flat;
            checkBoxProfiYes.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxProfiYes.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxProfiYes.Location = new Point(324, 461);
            checkBoxProfiYes.Name = "checkBoxProfiYes";
            checkBoxProfiYes.Size = new Size(44, 29);
            checkBoxProfiYes.TabIndex = 4;
            checkBoxProfiYes.Text = "Si";
            checkBoxProfiYes.UseVisualStyleBackColor = true;
            checkBoxProfiYes.CheckedChanged += checkBoxProfiYes_CheckedChanged;
            // 
            // checkBoxIgnitionYes
            // 
            checkBoxIgnitionYes.AutoSize = true;
            checkBoxIgnitionYes.FlatStyle = FlatStyle.Flat;
            checkBoxIgnitionYes.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxIgnitionYes.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxIgnitionYes.Location = new Point(324, 554);
            checkBoxIgnitionYes.Name = "checkBoxIgnitionYes";
            checkBoxIgnitionYes.Size = new Size(44, 29);
            checkBoxIgnitionYes.TabIndex = 4;
            checkBoxIgnitionYes.Text = "Si";
            checkBoxIgnitionYes.UseVisualStyleBackColor = true;
            checkBoxIgnitionYes.CheckedChanged += checkBoxIgnitionYes_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.FromArgb(45, 86, 160);
            checkBox1.Location = new Point(467, 461);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(57, 29);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "No";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBoxIgnitionNo
            // 
            checkBoxIgnitionNo.AutoSize = true;
            checkBoxIgnitionNo.FlatStyle = FlatStyle.Flat;
            checkBoxIgnitionNo.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxIgnitionNo.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxIgnitionNo.Location = new Point(467, 554);
            checkBoxIgnitionNo.Name = "checkBoxIgnitionNo";
            checkBoxIgnitionNo.Size = new Size(57, 29);
            checkBoxIgnitionNo.TabIndex = 4;
            checkBoxIgnitionNo.Text = "No";
            checkBoxIgnitionNo.UseVisualStyleBackColor = true;
            checkBoxIgnitionNo.CheckedChanged += checkBoxIgnitionNo_CheckedChanged;
            // 
            // checkBoxProfiNo
            // 
            checkBoxProfiNo.AutoSize = true;
            checkBoxProfiNo.FlatStyle = FlatStyle.Flat;
            checkBoxProfiNo.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxProfiNo.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxProfiNo.Location = new Point(467, 461);
            checkBoxProfiNo.Name = "checkBoxProfiNo";
            checkBoxProfiNo.Size = new Size(57, 29);
            checkBoxProfiNo.TabIndex = 4;
            checkBoxProfiNo.Text = "No";
            checkBoxProfiNo.UseVisualStyleBackColor = true;
            checkBoxProfiNo.CheckedChanged += checkBoxProfiNo_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1384, 661);
            Controls.Add(checkBox250A);
            Controls.Add(checkBoxIgnitionYes);
            Controls.Add(checkBoxIgnitionNo);
            Controls.Add(checkBoxProfiNo);
            Controls.Add(checkBox1);
            Controls.Add(checkBoxProfiYes);
            Controls.Add(checkBox150A);
            Controls.Add(textBoxMatricola);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxOperatore);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Controls.Add(iconButtonToForm2);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "COLLAUDO BDS.ARC V2";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private Label labelDate;
        private FontAwesome.Sharp.IconButton iconButtonToForm2;
        private Label labelTitle;
        private Label label1;
        private Label label2;
        private TextBox textBoxOperatore;
        private Label label3;
        private TextBox textBoxMatricola;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private CheckBox checkBox150A;
        private CheckBox checkBox250A;
        private CheckBox checkBoxProfiYes;
        private CheckBox checkBoxIgnitionYes;
        private CheckBox checkBox1;
        private CheckBox checkBoxIgnitionNo;
        private CheckBox checkBoxProfiNo;
        private Label labelRev;
    }
}