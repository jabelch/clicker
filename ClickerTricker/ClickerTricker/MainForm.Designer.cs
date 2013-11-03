namespace ClickerTricker
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
            this.SelectAllOrNone = new System.Windows.Forms.Button();
            this.MACListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScanForMACs = new System.Windows.Forms.Button();
            this.transmitMessage = new System.Windows.Forms.Button();
            this.TransOptGroupBox = new System.Windows.Forms.GroupBox();
            this.TransOptSendSelected = new System.Windows.Forms.RadioButton();
            this.TransOptSendRandom = new System.Windows.Forms.RadioButton();
            this.StartStat = new System.Windows.Forms.Button();
            this.SurveyTextBox = new System.Windows.Forms.RichTextBox();
            this.StopStats = new System.Windows.Forms.Button();
            this.RefreshStat = new System.Windows.Forms.Button();
            this.SaveAndRefreshStat = new System.Windows.Forms.Button();
            this.AnswerHighStat = new System.Windows.Forms.Button();
            this.AnswerGroupBox = new System.Windows.Forms.GroupBox();
            this.Answer9 = new System.Windows.Forms.RadioButton();
            this.Answer8 = new System.Windows.Forms.RadioButton();
            this.Answer7 = new System.Windows.Forms.RadioButton();
            this.Answer6 = new System.Windows.Forms.RadioButton();
            this.Answer5 = new System.Windows.Forms.RadioButton();
            this.Answer4 = new System.Windows.Forms.RadioButton();
            this.Answer3 = new System.Windows.Forms.RadioButton();
            this.Answer2 = new System.Windows.Forms.RadioButton();
            this.Answer1 = new System.Windows.Forms.RadioButton();
            this.Answer0 = new System.Windows.Forms.RadioButton();
            this.AnswerF = new System.Windows.Forms.RadioButton();
            this.AnswerE = new System.Windows.Forms.RadioButton();
            this.AnswerD = new System.Windows.Forms.RadioButton();
            this.AnswerC = new System.Windows.Forms.RadioButton();
            this.AnswerB = new System.Windows.Forms.RadioButton();
            this.AnswerA = new System.Windows.Forms.RadioButton();
            this.UseDefaultMAC = new System.Windows.Forms.CheckBox();
            this.DefaultMACAddress = new System.Windows.Forms.TextBox();
            this.TransOptGroupBox.SuspendLayout();
            this.AnswerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectAllOrNone
            // 
            this.SelectAllOrNone.Location = new System.Drawing.Point(647, 64);
            this.SelectAllOrNone.Name = "SelectAllOrNone";
            this.SelectAllOrNone.Size = new System.Drawing.Size(75, 34);
            this.SelectAllOrNone.TabIndex = 0;
            this.SelectAllOrNone.Text = "Select\r\nAll / None";
            this.SelectAllOrNone.UseVisualStyleBackColor = true;
            this.SelectAllOrNone.Click += new System.EventHandler(this.SelectAllOrNone_Click);
            // 
            // MACListBox
            // 
            this.MACListBox.CheckOnClick = true;
            this.MACListBox.FormattingEnabled = true;
            this.MACListBox.Items.AddRange(new object[] {
            "mac1",
            "mac2",
            "mac3",
            "mac4",
            "mac5"});
            this.MACListBox.Location = new System.Drawing.Point(524, 141);
            this.MACListBox.Name = "MACListBox";
            this.MACListBox.Size = new System.Drawing.Size(203, 214);
            this.MACListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAC(s) To Send On";
            // 
            // ScanForMACs
            // 
            this.ScanForMACs.Location = new System.Drawing.Point(524, 64);
            this.ScanForMACs.Name = "ScanForMACs";
            this.ScanForMACs.Size = new System.Drawing.Size(90, 23);
            this.ScanForMACs.TabIndex = 3;
            this.ScanForMACs.Text = "Scan For MACs";
            this.ScanForMACs.UseVisualStyleBackColor = true;
            // 
            // transmitMessage
            // 
            this.transmitMessage.Location = new System.Drawing.Point(322, 9);
            this.transmitMessage.Name = "transmitMessage";
            this.transmitMessage.Size = new System.Drawing.Size(159, 23);
            this.transmitMessage.TabIndex = 4;
            this.transmitMessage.Text = "Transmit";
            this.transmitMessage.UseVisualStyleBackColor = true;
            this.transmitMessage.Click += new System.EventHandler(this.transmitMessage_Click);
            // 
            // TransOptGroupBox
            // 
            this.TransOptGroupBox.Controls.Add(this.TransOptSendSelected);
            this.TransOptGroupBox.Controls.Add(this.TransOptSendRandom);
            this.TransOptGroupBox.Location = new System.Drawing.Point(309, 39);
            this.TransOptGroupBox.Name = "TransOptGroupBox";
            this.TransOptGroupBox.Size = new System.Drawing.Size(185, 67);
            this.TransOptGroupBox.TabIndex = 5;
            this.TransOptGroupBox.TabStop = false;
            this.TransOptGroupBox.Text = "Transmit Options";
            // 
            // TransOptSendSelected
            // 
            this.TransOptSendSelected.AutoSize = true;
            this.TransOptSendSelected.Location = new System.Drawing.Point(6, 42);
            this.TransOptSendSelected.Name = "TransOptSendSelected";
            this.TransOptSendSelected.Size = new System.Drawing.Size(176, 17);
            this.TransOptSendSelected.TabIndex = 7;
            this.TransOptSendSelected.TabStop = true;
            this.TransOptSendSelected.Text = "Send out selected same answer";
            this.TransOptSendSelected.UseVisualStyleBackColor = true;
            // 
            // TransOptSendRandom
            // 
            this.TransOptSendRandom.AutoSize = true;
            this.TransOptSendRandom.Location = new System.Drawing.Point(6, 19);
            this.TransOptSendRandom.Name = "TransOptSendRandom";
            this.TransOptSendRandom.Size = new System.Drawing.Size(143, 17);
            this.TransOptSendRandom.TabIndex = 6;
            this.TransOptSendRandom.TabStop = true;
            this.TransOptSendRandom.Text = "Send out random answer";
            this.TransOptSendRandom.UseVisualStyleBackColor = true;
            // 
            // StartStat
            // 
            this.StartStat.Location = new System.Drawing.Point(12, 9);
            this.StartStat.Name = "StartStat";
            this.StartStat.Size = new System.Drawing.Size(98, 23);
            this.StartStat.TabIndex = 6;
            this.StartStat.Text = "Start Statistics";
            this.StartStat.UseVisualStyleBackColor = true;
            // 
            // SurveyTextBox
            // 
            this.SurveyTextBox.Location = new System.Drawing.Point(12, 38);
            this.SurveyTextBox.Name = "SurveyTextBox";
            this.SurveyTextBox.Size = new System.Drawing.Size(149, 96);
            this.SurveyTextBox.TabIndex = 7;
            this.SurveyTextBox.Text = "A =\nB =\nC =\nD =\nE =\nF =";
            // 
            // StopStats
            // 
            this.StopStats.Location = new System.Drawing.Point(116, 9);
            this.StopStats.Name = "StopStats";
            this.StopStats.Size = new System.Drawing.Size(98, 23);
            this.StopStats.TabIndex = 8;
            this.StopStats.Text = "Stop Statistics";
            this.StopStats.UseVisualStyleBackColor = true;
            // 
            // RefreshStat
            // 
            this.RefreshStat.Location = new System.Drawing.Point(12, 140);
            this.RefreshStat.Name = "RefreshStat";
            this.RefreshStat.Size = new System.Drawing.Size(75, 23);
            this.RefreshStat.TabIndex = 9;
            this.RefreshStat.Text = "Refresh";
            this.RefreshStat.UseVisualStyleBackColor = true;
            // 
            // SaveAndRefreshStat
            // 
            this.SaveAndRefreshStat.Location = new System.Drawing.Point(93, 140);
            this.SaveAndRefreshStat.Name = "SaveAndRefreshStat";
            this.SaveAndRefreshStat.Size = new System.Drawing.Size(109, 23);
            this.SaveAndRefreshStat.TabIndex = 10;
            this.SaveAndRefreshStat.Text = "Save then Refresh";
            this.SaveAndRefreshStat.UseVisualStyleBackColor = true;
            // 
            // AnswerHighStat
            // 
            this.AnswerHighStat.Location = new System.Drawing.Point(167, 69);
            this.AnswerHighStat.Name = "AnswerHighStat";
            this.AnswerHighStat.Size = new System.Drawing.Size(75, 41);
            this.AnswerHighStat.TabIndex = 11;
            this.AnswerHighStat.Text = "Answer\r\nHighest";
            this.AnswerHighStat.UseVisualStyleBackColor = true;
            // 
            // AnswerGroupBox
            // 
            this.AnswerGroupBox.Controls.Add(this.Answer9);
            this.AnswerGroupBox.Controls.Add(this.Answer8);
            this.AnswerGroupBox.Controls.Add(this.Answer7);
            this.AnswerGroupBox.Controls.Add(this.Answer6);
            this.AnswerGroupBox.Controls.Add(this.Answer5);
            this.AnswerGroupBox.Controls.Add(this.Answer4);
            this.AnswerGroupBox.Controls.Add(this.Answer3);
            this.AnswerGroupBox.Controls.Add(this.Answer2);
            this.AnswerGroupBox.Controls.Add(this.Answer1);
            this.AnswerGroupBox.Controls.Add(this.Answer0);
            this.AnswerGroupBox.Controls.Add(this.AnswerF);
            this.AnswerGroupBox.Controls.Add(this.AnswerE);
            this.AnswerGroupBox.Controls.Add(this.AnswerD);
            this.AnswerGroupBox.Controls.Add(this.AnswerC);
            this.AnswerGroupBox.Controls.Add(this.AnswerB);
            this.AnswerGroupBox.Controls.Add(this.AnswerA);
            this.AnswerGroupBox.Location = new System.Drawing.Point(350, 112);
            this.AnswerGroupBox.Name = "AnswerGroupBox";
            this.AnswerGroupBox.Size = new System.Drawing.Size(102, 231);
            this.AnswerGroupBox.TabIndex = 12;
            this.AnswerGroupBox.TabStop = false;
            this.AnswerGroupBox.Text = "Answer To Send";
            // 
            // Answer9
            // 
            this.Answer9.AutoSize = true;
            this.Answer9.Location = new System.Drawing.Point(54, 180);
            this.Answer9.Name = "Answer9";
            this.Answer9.Size = new System.Drawing.Size(31, 17);
            this.Answer9.TabIndex = 15;
            this.Answer9.TabStop = true;
            this.Answer9.Text = "9";
            this.Answer9.UseVisualStyleBackColor = true;
            // 
            // Answer8
            // 
            this.Answer8.AutoSize = true;
            this.Answer8.Location = new System.Drawing.Point(54, 157);
            this.Answer8.Name = "Answer8";
            this.Answer8.Size = new System.Drawing.Size(31, 17);
            this.Answer8.TabIndex = 15;
            this.Answer8.TabStop = true;
            this.Answer8.Text = "8";
            this.Answer8.UseVisualStyleBackColor = true;
            // 
            // Answer7
            // 
            this.Answer7.AutoSize = true;
            this.Answer7.Location = new System.Drawing.Point(54, 134);
            this.Answer7.Name = "Answer7";
            this.Answer7.Size = new System.Drawing.Size(31, 17);
            this.Answer7.TabIndex = 15;
            this.Answer7.TabStop = true;
            this.Answer7.Text = "7";
            this.Answer7.UseVisualStyleBackColor = true;
            // 
            // Answer6
            // 
            this.Answer6.AutoSize = true;
            this.Answer6.Location = new System.Drawing.Point(54, 111);
            this.Answer6.Name = "Answer6";
            this.Answer6.Size = new System.Drawing.Size(31, 17);
            this.Answer6.TabIndex = 15;
            this.Answer6.TabStop = true;
            this.Answer6.Text = "6";
            this.Answer6.UseVisualStyleBackColor = true;
            // 
            // Answer5
            // 
            this.Answer5.AutoSize = true;
            this.Answer5.Location = new System.Drawing.Point(54, 88);
            this.Answer5.Name = "Answer5";
            this.Answer5.Size = new System.Drawing.Size(31, 17);
            this.Answer5.TabIndex = 14;
            this.Answer5.TabStop = true;
            this.Answer5.Text = "5";
            this.Answer5.UseVisualStyleBackColor = true;
            // 
            // Answer4
            // 
            this.Answer4.AutoSize = true;
            this.Answer4.Location = new System.Drawing.Point(54, 65);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(31, 17);
            this.Answer4.TabIndex = 14;
            this.Answer4.TabStop = true;
            this.Answer4.Text = "4";
            this.Answer4.UseVisualStyleBackColor = true;
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.Location = new System.Drawing.Point(54, 42);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(31, 17);
            this.Answer3.TabIndex = 14;
            this.Answer3.TabStop = true;
            this.Answer3.Text = "3";
            this.Answer3.UseVisualStyleBackColor = true;
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.Location = new System.Drawing.Point(54, 19);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(31, 17);
            this.Answer2.TabIndex = 14;
            this.Answer2.TabStop = true;
            this.Answer2.Text = "2";
            this.Answer2.UseVisualStyleBackColor = true;
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.Location = new System.Drawing.Point(6, 180);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(31, 17);
            this.Answer1.TabIndex = 18;
            this.Answer1.TabStop = true;
            this.Answer1.Text = "1";
            this.Answer1.UseVisualStyleBackColor = true;
            // 
            // Answer0
            // 
            this.Answer0.AutoSize = true;
            this.Answer0.Location = new System.Drawing.Point(6, 157);
            this.Answer0.Name = "Answer0";
            this.Answer0.Size = new System.Drawing.Size(31, 17);
            this.Answer0.TabIndex = 13;
            this.Answer0.TabStop = true;
            this.Answer0.Text = "0";
            this.Answer0.UseVisualStyleBackColor = true;
            // 
            // AnswerF
            // 
            this.AnswerF.AutoSize = true;
            this.AnswerF.Location = new System.Drawing.Point(6, 134);
            this.AnswerF.Name = "AnswerF";
            this.AnswerF.Size = new System.Drawing.Size(31, 17);
            this.AnswerF.TabIndex = 17;
            this.AnswerF.TabStop = true;
            this.AnswerF.Text = "F";
            this.AnswerF.UseVisualStyleBackColor = true;
            // 
            // AnswerE
            // 
            this.AnswerE.AutoSize = true;
            this.AnswerE.Location = new System.Drawing.Point(6, 111);
            this.AnswerE.Name = "AnswerE";
            this.AnswerE.Size = new System.Drawing.Size(32, 17);
            this.AnswerE.TabIndex = 16;
            this.AnswerE.TabStop = true;
            this.AnswerE.Text = "E";
            this.AnswerE.UseVisualStyleBackColor = true;
            // 
            // AnswerD
            // 
            this.AnswerD.AutoSize = true;
            this.AnswerD.Location = new System.Drawing.Point(6, 88);
            this.AnswerD.Name = "AnswerD";
            this.AnswerD.Size = new System.Drawing.Size(33, 17);
            this.AnswerD.TabIndex = 15;
            this.AnswerD.TabStop = true;
            this.AnswerD.Text = "D";
            this.AnswerD.UseVisualStyleBackColor = true;
            // 
            // AnswerC
            // 
            this.AnswerC.AutoSize = true;
            this.AnswerC.Location = new System.Drawing.Point(6, 65);
            this.AnswerC.Name = "AnswerC";
            this.AnswerC.Size = new System.Drawing.Size(32, 17);
            this.AnswerC.TabIndex = 14;
            this.AnswerC.TabStop = true;
            this.AnswerC.Text = "C";
            this.AnswerC.UseVisualStyleBackColor = true;
            // 
            // AnswerB
            // 
            this.AnswerB.AutoSize = true;
            this.AnswerB.Location = new System.Drawing.Point(6, 42);
            this.AnswerB.Name = "AnswerB";
            this.AnswerB.Size = new System.Drawing.Size(32, 17);
            this.AnswerB.TabIndex = 13;
            this.AnswerB.TabStop = true;
            this.AnswerB.Text = "B";
            this.AnswerB.UseVisualStyleBackColor = true;
            // 
            // AnswerA
            // 
            this.AnswerA.AutoSize = true;
            this.AnswerA.Location = new System.Drawing.Point(6, 19);
            this.AnswerA.Name = "AnswerA";
            this.AnswerA.Size = new System.Drawing.Size(32, 17);
            this.AnswerA.TabIndex = 0;
            this.AnswerA.TabStop = true;
            this.AnswerA.Text = "A";
            this.AnswerA.UseVisualStyleBackColor = true;
            // 
            // UseDefaultMAC
            // 
            this.UseDefaultMAC.AutoSize = true;
            this.UseDefaultMAC.Location = new System.Drawing.Point(571, 15);
            this.UseDefaultMAC.Name = "UseDefaultMAC";
            this.UseDefaultMAC.Size = new System.Drawing.Size(108, 17);
            this.UseDefaultMAC.TabIndex = 13;
            this.UseDefaultMAC.Text = "Use Default MAC";
            this.UseDefaultMAC.UseVisualStyleBackColor = true;
            // 
            // DefaultMACAddress
            // 
            this.DefaultMACAddress.Location = new System.Drawing.Point(554, 38);
            this.DefaultMACAddress.Name = "DefaultMACAddress";
            this.DefaultMACAddress.Size = new System.Drawing.Size(142, 20);
            this.DefaultMACAddress.TabIndex = 14;
            this.DefaultMACAddress.Text = "ABCDEF";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 362);
            this.Controls.Add(this.DefaultMACAddress);
            this.Controls.Add(this.UseDefaultMAC);
            this.Controls.Add(this.AnswerGroupBox);
            this.Controls.Add(this.AnswerHighStat);
            this.Controls.Add(this.SaveAndRefreshStat);
            this.Controls.Add(this.RefreshStat);
            this.Controls.Add(this.StopStats);
            this.Controls.Add(this.SurveyTextBox);
            this.Controls.Add(this.StartStat);
            this.Controls.Add(this.TransOptGroupBox);
            this.Controls.Add(this.transmitMessage);
            this.Controls.Add(this.ScanForMACs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MACListBox);
            this.Controls.Add(this.SelectAllOrNone);
            this.Name = "MainForm";
            this.Text = "Clicker Tricker";
            this.TransOptGroupBox.ResumeLayout(false);
            this.TransOptGroupBox.PerformLayout();
            this.AnswerGroupBox.ResumeLayout(false);
            this.AnswerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectAllOrNone;
        private System.Windows.Forms.CheckedListBox MACListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ScanForMACs;
        private System.Windows.Forms.Button transmitMessage;
        private System.Windows.Forms.GroupBox TransOptGroupBox;
        private System.Windows.Forms.RadioButton TransOptSendSelected;
        private System.Windows.Forms.RadioButton TransOptSendRandom;
        private System.Windows.Forms.Button StartStat;
        private System.Windows.Forms.RichTextBox SurveyTextBox;
        private System.Windows.Forms.Button StopStats;
        private System.Windows.Forms.Button RefreshStat;
        private System.Windows.Forms.Button SaveAndRefreshStat;
        private System.Windows.Forms.Button AnswerHighStat;
        private System.Windows.Forms.GroupBox AnswerGroupBox;
        private System.Windows.Forms.RadioButton Answer9;
        private System.Windows.Forms.RadioButton Answer8;
        private System.Windows.Forms.RadioButton Answer7;
        private System.Windows.Forms.RadioButton Answer6;
        private System.Windows.Forms.RadioButton Answer5;
        private System.Windows.Forms.RadioButton Answer4;
        private System.Windows.Forms.RadioButton Answer3;
        private System.Windows.Forms.RadioButton Answer2;
        private System.Windows.Forms.RadioButton Answer1;
        private System.Windows.Forms.RadioButton Answer0;
        private System.Windows.Forms.RadioButton AnswerF;
        private System.Windows.Forms.RadioButton AnswerE;
        private System.Windows.Forms.RadioButton AnswerD;
        private System.Windows.Forms.RadioButton AnswerC;
        private System.Windows.Forms.RadioButton AnswerB;
        private System.Windows.Forms.RadioButton AnswerA;
        private System.Windows.Forms.CheckBox UseDefaultMAC;
        private System.Windows.Forms.TextBox DefaultMACAddress;
    }
}

