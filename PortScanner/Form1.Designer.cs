namespace PortScanner
{
    partial class MainForm
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
            this.btnStartScan = new System.Windows.Forms.Button();
            this.richTxtScreen = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLoadedHosts = new System.Windows.Forms.Label();
            this.lblCheckedHosts = new System.Windows.Forms.Label();
            this.txtPortNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoadTxtFile = new System.Windows.Forms.Button();
            this.rdnBtnTCP = new System.Windows.Forms.RadioButton();
            this.rdnBtnUDP = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnStartScan
            // 
            this.btnStartScan.Location = new System.Drawing.Point(12, 39);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(99, 21);
            this.btnStartScan.TabIndex = 0;
            this.btnStartScan.Text = "Start Scan";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // richTxtScreen
            // 
            this.richTxtScreen.Location = new System.Drawing.Point(12, 72);
            this.richTxtScreen.Name = "richTxtScreen";
            this.richTxtScreen.Size = new System.Drawing.Size(270, 181);
            this.richTxtScreen.TabIndex = 2;
            this.richTxtScreen.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // lblLoadedHosts
            // 
            this.lblLoadedHosts.AutoSize = true;
            this.lblLoadedHosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadedHosts.Location = new System.Drawing.Point(412, 27);
            this.lblLoadedHosts.Name = "lblLoadedHosts";
            this.lblLoadedHosts.Size = new System.Drawing.Size(0, 17);
            this.lblLoadedHosts.TabIndex = 5;
            // 
            // lblCheckedHosts
            // 
            this.lblCheckedHosts.AutoSize = true;
            this.lblCheckedHosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckedHosts.Location = new System.Drawing.Point(412, 42);
            this.lblCheckedHosts.Name = "lblCheckedHosts";
            this.lblCheckedHosts.Size = new System.Drawing.Size(0, 17);
            this.lblCheckedHosts.TabIndex = 6;
            // 
            // txtPortNumber
            // 
            this.txtPortNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPortNumber.Location = new System.Drawing.Point(196, 38);
            this.txtPortNumber.Name = "txtPortNumber";
            this.txtPortNumber.Size = new System.Drawing.Size(86, 23);
            this.txtPortNumber.TabIndex = 7;
            this.txtPortNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPortNumber.TextChanged += new System.EventHandler(this.txtPortNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port:";
            // 
            // btnLoadTxtFile
            // 
            this.btnLoadTxtFile.Location = new System.Drawing.Point(12, 12);
            this.btnLoadTxtFile.Name = "btnLoadTxtFile";
            this.btnLoadTxtFile.Size = new System.Drawing.Size(99, 21);
            this.btnLoadTxtFile.TabIndex = 9;
            this.btnLoadTxtFile.Text = "Load txt file...";
            this.btnLoadTxtFile.UseVisualStyleBackColor = true;
            this.btnLoadTxtFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdnBtnTCP
            // 
            this.rdnBtnTCP.AutoSize = true;
            this.rdnBtnTCP.Checked = true;
            this.rdnBtnTCP.Location = new System.Drawing.Point(161, 12);
            this.rdnBtnTCP.Name = "rdnBtnTCP";
            this.rdnBtnTCP.Size = new System.Drawing.Size(46, 17);
            this.rdnBtnTCP.TabIndex = 0;
            this.rdnBtnTCP.TabStop = true;
            this.rdnBtnTCP.Text = "TCP";
            this.rdnBtnTCP.UseVisualStyleBackColor = true;
            this.rdnBtnTCP.CheckedChanged += new System.EventHandler(this.rdnBtnTCP_CheckedChanged);
            // 
            // rdnBtnUDP
            // 
            this.rdnBtnUDP.AutoSize = true;
            this.rdnBtnUDP.Location = new System.Drawing.Point(235, 12);
            this.rdnBtnUDP.Name = "rdnBtnUDP";
            this.rdnBtnUDP.Size = new System.Drawing.Size(48, 17);
            this.rdnBtnUDP.TabIndex = 1;
            this.rdnBtnUDP.Text = "UDP";
            this.rdnBtnUDP.UseVisualStyleBackColor = true;
            this.rdnBtnUDP.CheckedChanged += new System.EventHandler(this.rdnBtnUDP_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 265);
            this.Controls.Add(this.rdnBtnUDP);
            this.Controls.Add(this.rdnBtnTCP);
            this.Controls.Add(this.btnLoadTxtFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPortNumber);
            this.Controls.Add(this.lblCheckedHosts);
            this.Controls.Add(this.lblLoadedHosts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTxtScreen);
            this.Controls.Add(this.btnStartScan);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Port Scanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.RichTextBox richTxtScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLoadedHosts;
        private System.Windows.Forms.Label lblCheckedHosts;
        private System.Windows.Forms.TextBox txtPortNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoadTxtFile;
        private System.Windows.Forms.RadioButton rdnBtnTCP;
        private System.Windows.Forms.RadioButton rdnBtnUDP;
    }
}

