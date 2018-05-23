namespace BarCodeTyper
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Oklabel = new System.Windows.Forms.Label();
            this.panelMenuCamera = new System.Windows.Forms.Panel();
            this.EscolhaCameraPanel = new System.Windows.Forms.Panel();
            this.btnRefreshCamera = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbResolutions = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxCameraSource = new System.Windows.Forms.ComboBox();
            this.lblUltimoStatus = new System.Windows.Forms.Label();
            this.cameraconfigbtn = new System.Windows.Forms.Button();
            this.btnInvertY = new System.Windows.Forms.Button();
            this.btnInvertX = new System.Windows.Forms.Button();
            this.pictureBoxSource = new System.Windows.Forms.PictureBox();
            this.tbAfterTextSend = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAfterString = new System.Windows.Forms.TextBox();
            this.tbBeforeString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.panelMenuCamera.SuspendLayout();
            this.EscolhaCameraPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(327, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Oklabel
            // 
            this.Oklabel.AutoSize = true;
            this.Oklabel.BackColor = System.Drawing.Color.Transparent;
            this.Oklabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oklabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(199)))), ((int)(((byte)(42)))));
            this.Oklabel.Location = new System.Drawing.Point(7, 216);
            this.Oklabel.Name = "Oklabel";
            this.Oklabel.Size = new System.Drawing.Size(128, 86);
            this.Oklabel.TabIndex = 14;
            this.Oklabel.Text = "OK";
            this.Oklabel.Visible = false;
            // 
            // panelMenuCamera
            // 
            this.panelMenuCamera.BackColor = System.Drawing.Color.Black;
            this.panelMenuCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenuCamera.Controls.Add(this.EscolhaCameraPanel);
            this.panelMenuCamera.Controls.Add(this.Oklabel);
            this.panelMenuCamera.Controls.Add(this.lblUltimoStatus);
            this.panelMenuCamera.Location = new System.Drawing.Point(5, 27);
            this.panelMenuCamera.Name = "panelMenuCamera";
            this.panelMenuCamera.Size = new System.Drawing.Size(342, 302);
            this.panelMenuCamera.TabIndex = 41;
            this.panelMenuCamera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenuCamera_MouseDown);
            // 
            // EscolhaCameraPanel
            // 
            this.EscolhaCameraPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(217)))), ((int)(((byte)(223)))));
            this.EscolhaCameraPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EscolhaCameraPanel.Controls.Add(this.btnRefreshCamera);
            this.EscolhaCameraPanel.Controls.Add(this.label1);
            this.EscolhaCameraPanel.Controls.Add(this.cbResolutions);
            this.EscolhaCameraPanel.Controls.Add(this.Start);
            this.EscolhaCameraPanel.Controls.Add(this.label8);
            this.EscolhaCameraPanel.Controls.Add(this.comboBoxCameraSource);
            this.EscolhaCameraPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EscolhaCameraPanel.Location = new System.Drawing.Point(58, 75);
            this.EscolhaCameraPanel.Name = "EscolhaCameraPanel";
            this.EscolhaCameraPanel.Size = new System.Drawing.Size(227, 146);
            this.EscolhaCameraPanel.TabIndex = 7;
            // 
            // btnRefreshCamera
            // 
            this.btnRefreshCamera.BackColor = System.Drawing.Color.Gray;
            this.btnRefreshCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshCamera.FlatAppearance.BorderSize = 0;
            this.btnRefreshCamera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRefreshCamera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefreshCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCamera.Location = new System.Drawing.Point(136, 3);
            this.btnRefreshCamera.Name = "btnRefreshCamera";
            this.btnRefreshCamera.Size = new System.Drawing.Size(71, 26);
            this.btnRefreshCamera.TabIndex = 9;
            this.btnRefreshCamera.Text = "Atualizar";
            this.btnRefreshCamera.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Configuração:";
            // 
            // cbResolutions
            // 
            this.cbResolutions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbResolutions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbResolutions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbResolutions.FormattingEnabled = true;
            this.cbResolutions.Location = new System.Drawing.Point(17, 75);
            this.cbResolutions.Name = "cbResolutions";
            this.cbResolutions.Size = new System.Drawing.Size(194, 21);
            this.cbResolutions.TabIndex = 7;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(136, 105);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 25);
            this.Start.TabIndex = 5;
            this.Start.Text = "Iniciar";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Escolha a camera:";
            // 
            // comboBoxCameraSource
            // 
            this.comboBoxCameraSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCameraSource.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCameraSource.FormattingEnabled = true;
            this.comboBoxCameraSource.Location = new System.Drawing.Point(17, 35);
            this.comboBoxCameraSource.Name = "comboBoxCameraSource";
            this.comboBoxCameraSource.Size = new System.Drawing.Size(194, 21);
            this.comboBoxCameraSource.TabIndex = 3;
            this.comboBoxCameraSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxCameraSource_SelectedIndexChanged);
            // 
            // lblUltimoStatus
            // 
            this.lblUltimoStatus.AutoSize = true;
            this.lblUltimoStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblUltimoStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoStatus.ForeColor = System.Drawing.Color.Red;
            this.lblUltimoStatus.Location = new System.Drawing.Point(5, 272);
            this.lblUltimoStatus.Name = "lblUltimoStatus";
            this.lblUltimoStatus.Size = new System.Drawing.Size(148, 16);
            this.lblUltimoStatus.TabIndex = 42;
            this.lblUltimoStatus.Text = "Mensagem de aviso";
            // 
            // cameraconfigbtn
            // 
            this.cameraconfigbtn.BackColor = System.Drawing.Color.Gray;
            this.cameraconfigbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cameraconfigbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cameraconfigbtn.FlatAppearance.BorderSize = 0;
            this.cameraconfigbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cameraconfigbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cameraconfigbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cameraconfigbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameraconfigbtn.ForeColor = System.Drawing.Color.Black;
            this.cameraconfigbtn.Location = new System.Drawing.Point(164, 7);
            this.cameraconfigbtn.Name = "cameraconfigbtn";
            this.cameraconfigbtn.Size = new System.Drawing.Size(93, 20);
            this.cameraconfigbtn.TabIndex = 37;
            this.cameraconfigbtn.Text = "Settings";
            this.cameraconfigbtn.UseVisualStyleBackColor = false;
            this.cameraconfigbtn.Click += new System.EventHandler(this.cameraconfigbtn_Click);
            // 
            // btnInvertY
            // 
            this.btnInvertY.BackColor = System.Drawing.Color.Gray;
            this.btnInvertY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInvertY.FlatAppearance.BorderSize = 0;
            this.btnInvertY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvertY.Location = new System.Drawing.Point(84, 7);
            this.btnInvertY.Name = "btnInvertY";
            this.btnInvertY.Size = new System.Drawing.Size(84, 20);
            this.btnInvertY.TabIndex = 21;
            this.btnInvertY.Text = "Vertical";
            this.btnInvertY.UseVisualStyleBackColor = false;
            this.btnInvertY.Visible = false;
            // 
            // btnInvertX
            // 
            this.btnInvertX.BackColor = System.Drawing.Color.Gray;
            this.btnInvertX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInvertX.FlatAppearance.BorderSize = 0;
            this.btnInvertX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvertX.Location = new System.Drawing.Point(5, 7);
            this.btnInvertX.Name = "btnInvertX";
            this.btnInvertX.Size = new System.Drawing.Size(84, 20);
            this.btnInvertX.TabIndex = 20;
            this.btnInvertX.Text = "horizontal";
            this.btnInvertX.UseVisualStyleBackColor = false;
            this.btnInvertX.Visible = false;
            // 
            // pictureBoxSource
            // 
            this.pictureBoxSource.BackColor = System.Drawing.Color.Black;
            this.pictureBoxSource.Location = new System.Drawing.Point(5, 27);
            this.pictureBoxSource.Name = "pictureBoxSource";
            this.pictureBoxSource.Size = new System.Drawing.Size(342, 303);
            this.pictureBoxSource.TabIndex = 42;
            this.pictureBoxSource.TabStop = false;
            this.pictureBoxSource.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSource_Paint);
            this.pictureBoxSource.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSource_MouseDown);
            // 
            // tbAfterTextSend
            // 
            this.tbAfterTextSend.Location = new System.Drawing.Point(16, 106);
            this.tbAfterTextSend.Name = "tbAfterTextSend";
            this.tbAfterTextSend.Size = new System.Drawing.Size(301, 20);
            this.tbAfterTextSend.TabIndex = 43;
            this.tbAfterTextSend.Text = "{TAB}{TAB}{ENTER}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "After Text Send:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbAfterString
            // 
            this.tbAfterString.Location = new System.Drawing.Point(6, 37);
            this.tbAfterString.Name = "tbAfterString";
            this.tbAfterString.Size = new System.Drawing.Size(134, 20);
            this.tbAfterString.TabIndex = 45;
            // 
            // tbBeforeString
            // 
            this.tbBeforeString.Location = new System.Drawing.Point(146, 37);
            this.tbBeforeString.Name = "tbBeforeString";
            this.tbBeforeString.Size = new System.Drawing.Size(140, 20);
            this.tbBeforeString.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Até:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAfterString);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbBeforeString);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 76);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obtenha o texto do QRCode entre";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(5, 328);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(342, 121);
            this.listBox1.TabIndex = 50;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlSettings.Controls.Add(this.groupBox1);
            this.pnlSettings.Controls.Add(this.label2);
            this.pnlSettings.Controls.Add(this.tbAfterTextSend);
            this.pnlSettings.Location = new System.Drawing.Point(5, 328);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(342, 148);
            this.pnlSettings.TabIndex = 51;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(361, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cameraconfigbtn);
            this.Controls.Add(this.panelMenuCamera);
            this.Controls.Add(this.pictureBoxSource);
            this.Controls.Add(this.btnInvertY);
            this.Controls.Add(this.btnInvertX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "QR To Text -Alpha 0.1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.panelMenuCamera.ResumeLayout(false);
            this.panelMenuCamera.PerformLayout();
            this.EscolhaCameraPanel.ResumeLayout(false);
            this.EscolhaCameraPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Oklabel;
        private System.Windows.Forms.Panel panelMenuCamera;
        private System.Windows.Forms.Panel EscolhaCameraPanel;
        private System.Windows.Forms.Button btnRefreshCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbResolutions;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxCameraSource;
        private System.Windows.Forms.Button btnInvertY;
        private System.Windows.Forms.Button cameraconfigbtn;
        private System.Windows.Forms.Button btnInvertX;
        private System.Windows.Forms.PictureBox pictureBoxSource;
        private System.Windows.Forms.Label lblUltimoStatus;
        private System.Windows.Forms.TextBox tbAfterTextSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAfterString;
        private System.Windows.Forms.TextBox tbBeforeString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel pnlSettings;
    }
}

