namespace DanskateAnnouncer
{
    partial class Configuration
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
            this.showMessageCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IsuCalcGB = new System.Windows.Forms.GroupBox();
            this.IpIfIsuCalcCB = new System.Windows.Forms.ComboBox();
            this.IpPortIsuCalcNUD = new System.Windows.Forms.NumericUpDown();
            this.IsuCalcGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpPortIsuCalcNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // showMessageCheckBox
            // 
            this.showMessageCheckBox.AutoSize = true;
            this.showMessageCheckBox.Checked = true;
            this.showMessageCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showMessageCheckBox.Location = new System.Drawing.Point(28, 202);
            this.showMessageCheckBox.Name = "showMessageCheckBox";
            this.showMessageCheckBox.Size = new System.Drawing.Size(179, 17);
            this.showMessageCheckBox.TabIndex = 0;
            this.showMessageCheckBox.Text = "Show Message On Double-Click";
            this.showMessageCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(353, 202);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(272, 202);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Interface";
            // 
            // IsuCalcGB
            // 
            this.IsuCalcGB.BackColor = System.Drawing.SystemColors.Control;
            this.IsuCalcGB.Controls.Add(this.IpPortIsuCalcNUD);
            this.IsuCalcGB.Controls.Add(this.IpIfIsuCalcCB);
            this.IsuCalcGB.Controls.Add(this.label2);
            this.IsuCalcGB.Controls.Add(this.label1);
            this.IsuCalcGB.Location = new System.Drawing.Point(31, 33);
            this.IsuCalcGB.Name = "IsuCalcGB";
            this.IsuCalcGB.Size = new System.Drawing.Size(336, 51);
            this.IsuCalcGB.TabIndex = 5;
            this.IsuCalcGB.TabStop = false;
            this.IsuCalcGB.Text = "ISUCalcFs Link";
            // 
            // IpIfIsuCalcCB
            // 
            this.IpIfIsuCalcCB.AllowDrop = true;
            this.IpIfIsuCalcCB.FormattingEnabled = true;
            this.IpIfIsuCalcCB.Items.AddRange(new object[] {
            "localhost"});
            this.IpIfIsuCalcCB.Location = new System.Drawing.Point(61, 17);
            this.IpIfIsuCalcCB.Name = "IpIfIsuCalcCB";
            this.IpIfIsuCalcCB.Size = new System.Drawing.Size(121, 21);
            this.IpIfIsuCalcCB.TabIndex = 6;
            // 
            // IpPortIsuCalcNUD
            // 
            this.IpPortIsuCalcNUD.Location = new System.Drawing.Point(229, 17);
            this.IpPortIsuCalcNUD.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.IpPortIsuCalcNUD.Name = "IpPortIsuCalcNUD";
            this.IpPortIsuCalcNUD.Size = new System.Drawing.Size(73, 20);
            this.IpPortIsuCalcNUD.TabIndex = 7;
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 237);
            this.Controls.Add(this.IsuCalcGB);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.showMessageCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveSettings);
            this.Shown += new System.EventHandler(this.LoadSettings);
            this.IsuCalcGB.ResumeLayout(false);
            this.IsuCalcGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpPortIsuCalcNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox showMessageCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox IsuCalcGB;
        private System.Windows.Forms.ComboBox IpIfIsuCalcCB;
        private System.Windows.Forms.NumericUpDown IpPortIsuCalcNUD;
    }
}

