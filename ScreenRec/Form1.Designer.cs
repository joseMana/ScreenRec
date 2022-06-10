using System;

namespace ScreenRec
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.txtRecordingTitle = new System.Windows.Forms.TextBox();
            this.isAudioEnabled = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isInputDeviceEnabled = new System.Windows.Forms.CheckBox();
            this.txtFrameRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recording Title:";
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(280, 140);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(121, 19);
            this.btnRecord.TabIndex = 4;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.OnBtnRecordClick);
            // 
            // txtRecordingTitle
            // 
            this.txtRecordingTitle.Location = new System.Drawing.Point(118, 8);
            this.txtRecordingTitle.Name = "txtRecordingTitle";
            this.txtRecordingTitle.Size = new System.Drawing.Size(283, 20);
            this.txtRecordingTitle.TabIndex = 5;
            this.txtRecordingTitle.TextChanged += new System.EventHandler(this.txtRecordingTitle_TextChanged);
            this.txtRecordingTitle.Text = Guid.NewGuid().ToString();
            this.txtRecordingTitle.GotFocus += new System.EventHandler(this.txtRecordingTitle_onFocus);
            this.txtRecordingTitle.LostFocus += new System.EventHandler(this.txtRecordingTitle_onLostFocus);
            // 
            // isAudioEnabled
            // 
            this.isAudioEnabled.AutoSize = true;
            this.isAudioEnabled.Checked = true;
            this.isAudioEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isAudioEnabled.Location = new System.Drawing.Point(118, 34);
            this.isAudioEnabled.Name = "isAudioEnabled";
            this.isAudioEnabled.Size = new System.Drawing.Size(15, 14);
            this.isAudioEnabled.TabIndex = 6;
            this.isAudioEnabled.UseVisualStyleBackColor = true;
            this.isAudioEnabled.CheckedChanged += new System.EventHandler(this.isAudioEnabled_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enable Audio?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enable Audio Input?";
            // 
            // isInputDeviceEnabled
            // 
            this.isInputDeviceEnabled.AutoSize = true;
            this.isInputDeviceEnabled.Checked = true;
            this.isInputDeviceEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isInputDeviceEnabled.Location = new System.Drawing.Point(118, 54);
            this.isInputDeviceEnabled.Name = "isInputDeviceEnabled";
            this.isInputDeviceEnabled.Size = new System.Drawing.Size(15, 14);
            this.isInputDeviceEnabled.TabIndex = 8;
            this.isInputDeviceEnabled.UseVisualStyleBackColor = true;
            this.isInputDeviceEnabled.CheckedChanged += new System.EventHandler(this.isAudioInputEnabled_CheckedChanged);
            // 
            // txtFrameRate
            // 
            this.txtFrameRate.Location = new System.Drawing.Point(118, 74);
            this.txtFrameRate.Name = "txtFrameRate";
            this.txtFrameRate.Size = new System.Drawing.Size(33, 20);
            this.txtFrameRate.TabIndex = 10;
            this.txtFrameRate.Text = "35";
            this.txtFrameRate.TextChanged += new System.EventHandler(this.txtFrameRate_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Framerate:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 168);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFrameRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isInputDeviceEnabled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isAudioEnabled);
            this.Controls.Add(this.txtRecordingTitle);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Daily Tasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.TextBox txtRecordingTitle;
        private System.Windows.Forms.CheckBox isAudioEnabled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox isInputDeviceEnabled;


        #region Events
        private void txtRecordingTitle_TextChanged(object sender, EventArgs e)
        {
            var senderAsTxtbox = sender as System.Windows.Forms.TextBox;

            _recordingTitle = senderAsTxtbox.Text;
        }

        private void isAudioEnabled_CheckedChanged(object sender, EventArgs e)
        {
            var senderAsChkBox = sender as System.Windows.Forms.CheckBox;

            _isAudioEnabled = senderAsChkBox.Checked;
        }

        private void isAudioInputEnabled_CheckedChanged(object sender, EventArgs e)
        {
            var senderAsChkBox = sender as System.Windows.Forms.CheckBox;

            _isInputDeviceEnabled = senderAsChkBox.Checked;
        }
        private void txtFrameRate_TextChanged(object sender, EventArgs e)
        {
            var senderAsTxtbox = sender as System.Windows.Forms.TextBox;

            _frameRate = int.Parse(senderAsTxtbox.Text);
        }
        private void txtRecordingTitle_onFocus(object sender, EventArgs e)
        {
            var senderAsTxtbox = sender as System.Windows.Forms.TextBox;
            string recordingTitle = senderAsTxtbox.Text;

            if (Guid.TryParse(recordingTitle, out Guid parsedRecordingTitleGuid))
                this.txtRecordingTitle.Text = "";

        }
        private void txtRecordingTitle_onLostFocus(object sender, EventArgs e)
        {
            var senderAsTxtbox = sender as System.Windows.Forms.TextBox;
            string recordingTitle = senderAsTxtbox.Text;

            if (recordingTitle == "")
                this.txtRecordingTitle.Text = Guid.NewGuid().ToString();
        }
        #endregion

        private System.Windows.Forms.TextBox txtFrameRate;
        private System.Windows.Forms.Label label4;
    }
}

