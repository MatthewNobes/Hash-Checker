namespace Hash_Checker
{
    partial class mainForm
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
            this.grbHashInfo = new System.Windows.Forms.GroupBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.cmbAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblAlgorithm = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txtOriginalHash = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblOriginalHash = new System.Windows.Forms.Label();
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.txtSafeToUse = new System.Windows.Forms.TextBox();
            this.lblSafeToUse = new System.Windows.Forms.Label();
            this.lblResultHash = new System.Windows.Forms.Label();
            this.txtResultHash = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtSelectFile = new System.Windows.Forms.Button();
            this.grbHashInfo.SuspendLayout();
            this.grbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbHashInfo
            // 
            this.grbHashInfo.Controls.Add(this.txtSelectFile);
            this.grbHashInfo.Controls.Add(this.btnGo);
            this.grbHashInfo.Controls.Add(this.cmbAlgorithm);
            this.grbHashInfo.Controls.Add(this.lblAlgorithm);
            this.grbHashInfo.Controls.Add(this.lblFilePath);
            this.grbHashInfo.Controls.Add(this.txtOriginalHash);
            this.grbHashInfo.Controls.Add(this.txtFilePath);
            this.grbHashInfo.Controls.Add(this.lblOriginalHash);
            this.grbHashInfo.Location = new System.Drawing.Point(13, 13);
            this.grbHashInfo.Name = "grbHashInfo";
            this.grbHashInfo.Size = new System.Drawing.Size(358, 210);
            this.grbHashInfo.TabIndex = 0;
            this.grbHashInfo.TabStop = false;
            this.grbHashInfo.Text = "Hash Information";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(277, 181);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // cmbAlgorithm
            // 
            this.cmbAlgorithm.FormattingEnabled = true;
            this.cmbAlgorithm.Items.AddRange(new object[] {
            "MD5",
            "SHA-1",
            "SHA-256",
            "SHA-384",
            "SHA-512"});
            this.cmbAlgorithm.Location = new System.Drawing.Point(83, 149);
            this.cmbAlgorithm.Name = "cmbAlgorithm";
            this.cmbAlgorithm.Size = new System.Drawing.Size(269, 24);
            this.cmbAlgorithm.TabIndex = 4;
            // 
            // lblAlgorithm
            // 
            this.lblAlgorithm.AutoSize = true;
            this.lblAlgorithm.Location = new System.Drawing.Point(10, 152);
            this.lblAlgorithm.Name = "lblAlgorithm";
            this.lblAlgorithm.Size = new System.Drawing.Size(71, 17);
            this.lblAlgorithm.TabIndex = 3;
            this.lblAlgorithm.Text = "Algorithm:";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(10, 124);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(67, 17);
            this.lblFilePath.TabIndex = 2;
            this.lblFilePath.Text = "File Path:";
            // 
            // txtOriginalHash
            // 
            this.txtOriginalHash.Location = new System.Drawing.Point(10, 42);
            this.txtOriginalHash.Multiline = true;
            this.txtOriginalHash.Name = "txtOriginalHash";
            this.txtOriginalHash.Size = new System.Drawing.Size(342, 73);
            this.txtOriginalHash.TabIndex = 6;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(83, 121);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(269, 22);
            this.txtFilePath.TabIndex = 1;
            // 
            // lblOriginalHash
            // 
            this.lblOriginalHash.AutoSize = true;
            this.lblOriginalHash.Location = new System.Drawing.Point(7, 22);
            this.lblOriginalHash.Name = "lblOriginalHash";
            this.lblOriginalHash.Size = new System.Drawing.Size(98, 17);
            this.lblOriginalHash.TabIndex = 0;
            this.lblOriginalHash.Text = "Original Hash:";
            // 
            // grbResult
            // 
            this.grbResult.Controls.Add(this.txtSafeToUse);
            this.grbResult.Controls.Add(this.lblSafeToUse);
            this.grbResult.Controls.Add(this.lblResultHash);
            this.grbResult.Controls.Add(this.txtResultHash);
            this.grbResult.Location = new System.Drawing.Point(13, 229);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(358, 157);
            this.grbResult.TabIndex = 2;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "Result";
            // 
            // txtSafeToUse
            // 
            this.txtSafeToUse.Location = new System.Drawing.Point(98, 22);
            this.txtSafeToUse.Name = "txtSafeToUse";
            this.txtSafeToUse.Size = new System.Drawing.Size(254, 22);
            this.txtSafeToUse.TabIndex = 5;
            // 
            // lblSafeToUse
            // 
            this.lblSafeToUse.AutoSize = true;
            this.lblSafeToUse.Location = new System.Drawing.Point(7, 22);
            this.lblSafeToUse.Name = "lblSafeToUse";
            this.lblSafeToUse.Size = new System.Drawing.Size(84, 17);
            this.lblSafeToUse.TabIndex = 4;
            this.lblSafeToUse.Text = "Safe to use:";
            // 
            // lblResultHash
            // 
            this.lblResultHash.AutoSize = true;
            this.lblResultHash.Location = new System.Drawing.Point(10, 52);
            this.lblResultHash.Name = "lblResultHash";
            this.lblResultHash.Size = new System.Drawing.Size(89, 17);
            this.lblResultHash.TabIndex = 3;
            this.lblResultHash.Text = "Result Hash:";
            // 
            // txtResultHash
            // 
            this.txtResultHash.Location = new System.Drawing.Point(10, 75);
            this.txtResultHash.Multiline = true;
            this.txtResultHash.Name = "txtResultHash";
            this.txtResultHash.Size = new System.Drawing.Size(342, 73);
            this.txtResultHash.TabIndex = 2;
            // 
            // txtSelectFile
            // 
            this.txtSelectFile.Location = new System.Drawing.Point(13, 181);
            this.txtSelectFile.Name = "txtSelectFile";
            this.txtSelectFile.Size = new System.Drawing.Size(99, 23);
            this.txtSelectFile.TabIndex = 3;
            this.txtSelectFile.Text = "Select File";
            this.txtSelectFile.UseVisualStyleBackColor = true;
            this.txtSelectFile.Click += new System.EventHandler(this.TxtSelectFile_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 398);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.grbHashInfo);
            this.Name = "mainForm";
            this.Text = "Hash Checker";
            this.grbHashInfo.ResumeLayout(false);
            this.grbHashInfo.PerformLayout();
            this.grbResult.ResumeLayout(false);
            this.grbResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHashInfo;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox txtOriginalHash;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblOriginalHash;
        private System.Windows.Forms.GroupBox grbResult;
        private System.Windows.Forms.TextBox txtResultHash;
        private System.Windows.Forms.ComboBox cmbAlgorithm;
        private System.Windows.Forms.Label lblAlgorithm;
        private System.Windows.Forms.TextBox txtSafeToUse;
        private System.Windows.Forms.Label lblSafeToUse;
        private System.Windows.Forms.Label lblResultHash;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button txtSelectFile;
    }
}

