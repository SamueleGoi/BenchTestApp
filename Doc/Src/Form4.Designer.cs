namespace ProceduraCollaudo
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            panelMenu = new Panel();
            labelRev = new Label();
            labelDate = new Label();
            labelTime = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            labelTitle = new Label();
            label1 = new Label();
            iconButtonToForm5 = new FontAwesome.Sharp.IconButton();
            textBoxInfo = new TextBox();
            label4 = new Label();
            labelCom = new Label();
            buttonCom = new Button();
            label2 = new Label();
            checkBoxCtrl = new CheckBox();
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
            labelTitle.TabIndex = 6;
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
            label1.TabIndex = 7;
            label1.Text = "04. Verifica parametri e preparazione per prima accensione";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconButtonToForm5
            // 
            iconButtonToForm5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iconButtonToForm5.FlatAppearance.BorderColor = Color.White;
            iconButtonToForm5.FlatAppearance.BorderSize = 0;
            iconButtonToForm5.FlatAppearance.MouseDownBackColor = Color.White;
            iconButtonToForm5.FlatAppearance.MouseOverBackColor = Color.White;
            iconButtonToForm5.FlatStyle = FlatStyle.Flat;
            iconButtonToForm5.IconChar = FontAwesome.Sharp.IconChar.CircleChevronRight;
            iconButtonToForm5.IconColor = Color.FromArgb(45, 86, 160);
            iconButtonToForm5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonToForm5.IconSize = 64;
            iconButtonToForm5.Location = new Point(1276, 574);
            iconButtonToForm5.Name = "iconButtonToForm5";
            iconButtonToForm5.Size = new Size(96, 75);
            iconButtonToForm5.TabIndex = 9;
            iconButtonToForm5.UseVisualStyleBackColor = true;
            iconButtonToForm5.Click += iconButtonToForm5_Click;
            // 
            // textBoxInfo
            // 
            textBoxInfo.AcceptsTab = true;
            textBoxInfo.BackColor = Color.White;
            textBoxInfo.BorderStyle = BorderStyle.FixedSingle;
            textBoxInfo.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxInfo.ForeColor = Color.FromArgb(45, 86, 160);
            textBoxInfo.Location = new Point(331, 138);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(477, 192);
            textBoxInfo.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(45, 86, 160);
            label4.Location = new Point(331, 333);
            label4.Name = "label4";
            label4.Size = new Size(439, 33);
            label4.TabIndex = 17;
            label4.Text = "04.01. Abilita controllo COM";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCom
            // 
            labelCom.Anchor = AnchorStyles.Left;
            labelCom.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCom.ForeColor = Color.White;
            labelCom.Location = new Point(425, 375);
            labelCom.Name = "labelCom";
            labelCom.Size = new Size(123, 23);
            labelCom.TabIndex = 46;
            labelCom.Text = "ERR";
            labelCom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonCom
            // 
            buttonCom.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCom.ForeColor = Color.FromArgb(45, 86, 160);
            buttonCom.Location = new Point(331, 369);
            buttonCom.Name = "buttonCom";
            buttonCom.Size = new Size(88, 33);
            buttonCom.TabIndex = 45;
            buttonCom.Text = "COM";
            buttonCom.UseVisualStyleBackColor = true;
            buttonCom.Click += buttonCom_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(45, 86, 160);
            label2.Location = new Point(331, 405);
            label2.Name = "label2";
            label2.Size = new Size(439, 33);
            label2.TabIndex = 47;
            label2.Text = "Verificare sul display Ctrl \"COM\" e Mode \"CAL\"";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxCtrl
            // 
            checkBoxCtrl.AutoSize = true;
            checkBoxCtrl.FlatStyle = FlatStyle.Flat;
            checkBoxCtrl.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxCtrl.ForeColor = Color.FromArgb(45, 86, 160);
            checkBoxCtrl.Location = new Point(726, 407);
            checkBoxCtrl.Name = "checkBoxCtrl";
            checkBoxCtrl.Size = new Size(59, 29);
            checkBoxCtrl.TabIndex = 48;
            checkBoxCtrl.Text = "OK";
            checkBoxCtrl.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1384, 661);
            Controls.Add(checkBoxCtrl);
            Controls.Add(label2);
            Controls.Add(labelCom);
            Controls.Add(buttonCom);
            Controls.Add(label4);
            Controls.Add(textBoxInfo);
            Controls.Add(iconButtonToForm5);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "COLLAUDO BDS.ARC V2";
            Load += Form4_Load;
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
        private System.Windows.Forms.Timer timer1;
        private Label labelTitle;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButtonToForm5;
        private Label labelRev;
        private TextBox textBoxInfo;
        private Label label4;
        private Label labelCom;
        private Button buttonCom;
        private Label label2;
        private CheckBox checkBoxCtrl;
    }
}