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
            this.UseDefaultMACCheckBox = new System.Windows.Forms.CheckBox();
            this.DefaultMACAddressTextBox = new System.Windows.Forms.TextBox();
            this.MACRemoveFromList = new System.Windows.Forms.Button();
            this.JamButton = new System.Windows.Forms.Button();
            this.ComPortToUse = new System.Windows.Forms.TextBox();
            this.CommPortLabel = new System.Windows.Forms.Label();
            this.warningOutputBox = new System.Windows.Forms.TextBox();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.consoleEnter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.channelTextBox = new System.Windows.Forms.TextBox();
            this.randomAnswerTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            "abcdef",
            "bbcdef",
            "cbcdef"});
            this.MACListBox.Location = new System.Drawing.Point(524, 141);
            this.MACListBox.Name = "MACListBox";
            this.MACListBox.Size = new System.Drawing.Size(203, 409);
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
            this.ScanForMACs.Click += new System.EventHandler(this.ScanForMACs_Click);
            // 
            // transmitMessage
            // 
            this.transmitMessage.Location = new System.Drawing.Point(337, 9);
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
            this.TransOptGroupBox.Location = new System.Drawing.Point(324, 39);
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
            this.StartStat.Text = "Get Statistics";
            this.StartStat.UseVisualStyleBackColor = true;
            this.StartStat.Click += new System.EventHandler(this.StartStat_Click);
            // 
            // SurveyTextBox
            // 
            this.SurveyTextBox.Location = new System.Drawing.Point(12, 38);
            this.SurveyTextBox.Name = "SurveyTextBox";
            this.SurveyTextBox.Size = new System.Drawing.Size(113, 96);
            this.SurveyTextBox.TabIndex = 7;
            this.SurveyTextBox.Text = "Total: 0\nPopular answer: 1\n";
            // 
            // StopStats
            // 
            this.StopStats.BackColor = System.Drawing.SystemColors.Control;
            this.StopStats.Location = new System.Drawing.Point(116, 9);
            this.StopStats.Name = "StopStats";
            this.StopStats.Size = new System.Drawing.Size(98, 23);
            this.StopStats.TabIndex = 8;
            this.StopStats.Text = "Stop Statistics";
            this.StopStats.UseVisualStyleBackColor = false;
            this.StopStats.Visible = false;
            // 
            // RefreshStat
            // 
            this.RefreshStat.Location = new System.Drawing.Point(12, 140);
            this.RefreshStat.Name = "RefreshStat";
            this.RefreshStat.Size = new System.Drawing.Size(75, 23);
            this.RefreshStat.TabIndex = 9;
            this.RefreshStat.Text = "Refresh";
            this.RefreshStat.UseVisualStyleBackColor = true;
            this.RefreshStat.Click += new System.EventHandler(this.RefreshStat_Click);
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
            this.AnswerHighStat.Location = new System.Drawing.Point(139, 39);
            this.AnswerHighStat.Name = "AnswerHighStat";
            this.AnswerHighStat.Size = new System.Drawing.Size(75, 41);
            this.AnswerHighStat.TabIndex = 11;
            this.AnswerHighStat.Text = "Answer\r\nHighest";
            this.AnswerHighStat.UseVisualStyleBackColor = true;
            this.AnswerHighStat.Visible = false;
            this.AnswerHighStat.Click += new System.EventHandler(this.AnswerHighStat_Click);
            // 
            // AnswerGroupBox
            // 
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
            this.AnswerGroupBox.Location = new System.Drawing.Point(365, 112);
            this.AnswerGroupBox.Name = "AnswerGroupBox";
            this.AnswerGroupBox.Size = new System.Drawing.Size(102, 161);
            this.AnswerGroupBox.TabIndex = 12;
            this.AnswerGroupBox.TabStop = false;
            this.AnswerGroupBox.Text = "Answer To Send";
            // 
            // Answer4
            // 
            this.Answer4.AutoSize = true;
            this.Answer4.Location = new System.Drawing.Point(50, 111);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(31, 17);
            this.Answer4.TabIndex = 14;
            this.Answer4.TabStop = true;
            this.Answer4.Text = "?";
            this.Answer4.UseVisualStyleBackColor = true;
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.Location = new System.Drawing.Point(50, 88);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(38, 17);
            this.Answer3.TabIndex = 14;
            this.Answer3.TabStop = true;
            this.Answer3.Text = "0/j";
            this.Answer3.UseVisualStyleBackColor = true;
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.Location = new System.Drawing.Point(50, 65);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(38, 17);
            this.Answer2.TabIndex = 14;
            this.Answer2.TabStop = true;
            this.Answer2.Text = "9/i";
            this.Answer2.UseVisualStyleBackColor = true;
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.Location = new System.Drawing.Point(50, 42);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(42, 17);
            this.Answer1.TabIndex = 18;
            this.Answer1.TabStop = true;
            this.Answer1.Text = "8/h";
            this.Answer1.UseVisualStyleBackColor = true;
            // 
            // Answer0
            // 
            this.Answer0.AutoSize = true;
            this.Answer0.Location = new System.Drawing.Point(50, 19);
            this.Answer0.Name = "Answer0";
            this.Answer0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Answer0.Size = new System.Drawing.Size(42, 17);
            this.Answer0.TabIndex = 13;
            this.Answer0.TabStop = true;
            this.Answer0.Text = "7/g";
            this.Answer0.UseVisualStyleBackColor = true;
            // 
            // AnswerF
            // 
            this.AnswerF.AutoSize = true;
            this.AnswerF.Location = new System.Drawing.Point(6, 134);
            this.AnswerF.Name = "AnswerF";
            this.AnswerF.Size = new System.Drawing.Size(39, 17);
            this.AnswerF.TabIndex = 17;
            this.AnswerF.TabStop = true;
            this.AnswerF.Text = "6/f";
            this.AnswerF.UseVisualStyleBackColor = true;
            // 
            // AnswerE
            // 
            this.AnswerE.AutoSize = true;
            this.AnswerE.Location = new System.Drawing.Point(6, 111);
            this.AnswerE.Name = "AnswerE";
            this.AnswerE.Size = new System.Drawing.Size(42, 17);
            this.AnswerE.TabIndex = 16;
            this.AnswerE.TabStop = true;
            this.AnswerE.Text = "5/e";
            this.AnswerE.UseVisualStyleBackColor = true;
            // 
            // AnswerD
            // 
            this.AnswerD.AutoSize = true;
            this.AnswerD.Location = new System.Drawing.Point(6, 88);
            this.AnswerD.Name = "AnswerD";
            this.AnswerD.Size = new System.Drawing.Size(42, 17);
            this.AnswerD.TabIndex = 15;
            this.AnswerD.TabStop = true;
            this.AnswerD.Text = "4/d";
            this.AnswerD.UseVisualStyleBackColor = true;
            // 
            // AnswerC
            // 
            this.AnswerC.AutoSize = true;
            this.AnswerC.Location = new System.Drawing.Point(6, 65);
            this.AnswerC.Name = "AnswerC";
            this.AnswerC.Size = new System.Drawing.Size(42, 17);
            this.AnswerC.TabIndex = 14;
            this.AnswerC.TabStop = true;
            this.AnswerC.Text = "3/c";
            this.AnswerC.UseVisualStyleBackColor = true;
            // 
            // AnswerB
            // 
            this.AnswerB.AutoSize = true;
            this.AnswerB.Location = new System.Drawing.Point(6, 42);
            this.AnswerB.Name = "AnswerB";
            this.AnswerB.Size = new System.Drawing.Size(42, 17);
            this.AnswerB.TabIndex = 13;
            this.AnswerB.TabStop = true;
            this.AnswerB.Text = "2/b";
            this.AnswerB.UseVisualStyleBackColor = true;
            // 
            // AnswerA
            // 
            this.AnswerA.AutoSize = true;
            this.AnswerA.Location = new System.Drawing.Point(6, 19);
            this.AnswerA.Name = "AnswerA";
            this.AnswerA.Size = new System.Drawing.Size(42, 17);
            this.AnswerA.TabIndex = 0;
            this.AnswerA.TabStop = true;
            this.AnswerA.Text = "1/a";
            this.AnswerA.UseVisualStyleBackColor = true;
            // 
            // UseDefaultMACCheckBox
            // 
            this.UseDefaultMACCheckBox.AutoSize = true;
            this.UseDefaultMACCheckBox.Location = new System.Drawing.Point(571, 15);
            this.UseDefaultMACCheckBox.Name = "UseDefaultMACCheckBox";
            this.UseDefaultMACCheckBox.Size = new System.Drawing.Size(108, 17);
            this.UseDefaultMACCheckBox.TabIndex = 13;
            this.UseDefaultMACCheckBox.Text = "Use Default MAC";
            this.UseDefaultMACCheckBox.UseVisualStyleBackColor = true;
            // 
            // DefaultMACAddressTextBox
            // 
            this.DefaultMACAddressTextBox.Location = new System.Drawing.Point(554, 38);
            this.DefaultMACAddressTextBox.Name = "DefaultMACAddressTextBox";
            this.DefaultMACAddressTextBox.Size = new System.Drawing.Size(142, 20);
            this.DefaultMACAddressTextBox.TabIndex = 14;
            this.DefaultMACAddressTextBox.Text = "ABCDEF";
            // 
            // MACRemoveFromList
            // 
            this.MACRemoveFromList.Location = new System.Drawing.Point(524, 93);
            this.MACRemoveFromList.Name = "MACRemoveFromList";
            this.MACRemoveFromList.Size = new System.Drawing.Size(90, 25);
            this.MACRemoveFromList.TabIndex = 15;
            this.MACRemoveFromList.Text = "remove MACs";
            this.MACRemoveFromList.UseVisualStyleBackColor = true;
            this.MACRemoveFromList.Click += new System.EventHandler(this.MACRemoveFromList_Click);
            // 
            // JamButton
            // 
            this.JamButton.Location = new System.Drawing.Point(139, 93);
            this.JamButton.Name = "JamButton";
            this.JamButton.Size = new System.Drawing.Size(64, 25);
            this.JamButton.TabIndex = 16;
            this.JamButton.Text = "Jam";
            this.JamButton.UseVisualStyleBackColor = true;
            this.JamButton.Click += new System.EventHandler(this.JamButton_Click);
            // 
            // ComPortToUse
            // 
            this.ComPortToUse.Location = new System.Drawing.Point(234, 39);
            this.ComPortToUse.Name = "ComPortToUse";
            this.ComPortToUse.Size = new System.Drawing.Size(70, 20);
            this.ComPortToUse.TabIndex = 20;
            this.ComPortToUse.TextChanged += new System.EventHandler(this.ComPortToUse_TextChanged);
            // 
            // CommPortLabel
            // 
            this.CommPortLabel.AutoSize = true;
            this.CommPortLabel.Location = new System.Drawing.Point(236, 23);
            this.CommPortLabel.Name = "CommPortLabel";
            this.CommPortLabel.Size = new System.Drawing.Size(55, 13);
            this.CommPortLabel.TabIndex = 21;
            this.CommPortLabel.Text = "CommPort";
            // 
            // warningOutputBox
            // 
            this.warningOutputBox.Location = new System.Drawing.Point(12, 236);
            this.warningOutputBox.Multiline = true;
            this.warningOutputBox.Name = "warningOutputBox";
            this.warningOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.warningOutputBox.Size = new System.Drawing.Size(321, 314);
            this.warningOutputBox.TabIndex = 22;
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Location = new System.Drawing.Point(12, 197);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.Size = new System.Drawing.Size(249, 20);
            this.consoleTextBox.TabIndex = 23;
            this.consoleTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.consoleTextBox_KeyUp);
            // 
            // consoleEnter
            // 
            this.consoleEnter.Location = new System.Drawing.Point(267, 194);
            this.consoleEnter.Name = "consoleEnter";
            this.consoleEnter.Size = new System.Drawing.Size(75, 23);
            this.consoleEnter.TabIndex = 24;
            this.consoleEnter.Text = "Enter";
            this.consoleEnter.UseVisualStyleBackColor = true;
            this.consoleEnter.Click += new System.EventHandler(this.consoleEnter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "console Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "warning/output box";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Channel";
            // 
            // channelTextBox
            // 
            this.channelTextBox.Location = new System.Drawing.Point(234, 78);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.Size = new System.Drawing.Size(70, 20);
            this.channelTextBox.TabIndex = 28;
            this.channelTextBox.Leave += new System.EventHandler(this.channelTextBox_Leave);
            // 
            // randomAnswerTextBox
            // 
            this.randomAnswerTextBox.Location = new System.Drawing.Point(365, 313);
            this.randomAnswerTextBox.Name = "randomAnswerTextBox";
            this.randomAnswerTextBox.Size = new System.Drawing.Size(100, 20);
            this.randomAnswerTextBox.TabIndex = 29;
            this.randomAnswerTextBox.Text = "abcdefghij";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Random Answer choices";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.randomAnswerTextBox);
            this.Controls.Add(this.channelTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.consoleEnter);
            this.Controls.Add(this.consoleTextBox);
            this.Controls.Add(this.warningOutputBox);
            this.Controls.Add(this.CommPortLabel);
            this.Controls.Add(this.ComPortToUse);
            this.Controls.Add(this.JamButton);
            this.Controls.Add(this.MACRemoveFromList);
            this.Controls.Add(this.DefaultMACAddressTextBox);
            this.Controls.Add(this.UseDefaultMACCheckBox);
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
        private System.Windows.Forms.CheckBox UseDefaultMACCheckBox;
        private System.Windows.Forms.TextBox DefaultMACAddressTextBox;
        private System.Windows.Forms.Button MACRemoveFromList;
        private System.Windows.Forms.Button JamButton;
        private System.Windows.Forms.TextBox ComPortToUse;
        private System.Windows.Forms.Label CommPortLabel;
        private System.Windows.Forms.TextBox warningOutputBox;
        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.Button consoleEnter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox channelTextBox;
        private System.Windows.Forms.TextBox randomAnswerTextBox;
        private System.Windows.Forms.Label label5;
    }
}

