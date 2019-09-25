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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.grbHashInfo = new System.Windows.Forms.GroupBox();
            this.txtSelectFile = new System.Windows.Forms.Button();
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
            this.grbHashInfo.Location = new System.Drawing.Point(10, 11);
            this.grbHashInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbHashInfo.Name = "grbHashInfo";
            this.grbHashInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbHashInfo.Size = new System.Drawing.Size(354, 164);
            this.grbHashInfo.TabIndex = 0;
            this.grbHashInfo.TabStop = false;
            this.grbHashInfo.Text = "Hash Information";
            // 
            // txtSelectFile
            // 
            this.txtSelectFile.Location = new System.Drawing.Point(268, 98);
            this.txtSelectFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSelectFile.Name = "txtSelectFile";
            this.txtSelectFile.Size = new System.Drawing.Size(74, 26);
            this.txtSelectFile.TabIndex = 3;
            this.txtSelectFile.Text = "Select File";
            this.txtSelectFile.UseVisualStyleBackColor = true;
            this.txtSelectFile.Click += new System.EventHandler(this.TxtSelectFile_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(268, 129);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(74, 24);
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
            this.cmbAlgorithm.Location = new System.Drawing.Point(62, 132);
            this.cmbAlgorithm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbAlgorithm.Name = "cmbAlgorithm";
            this.cmbAlgorithm.Size = new System.Drawing.Size(203, 21);
            this.cmbAlgorithm.TabIndex = 4;
            this.cmbAlgorithm.Text = "MD5";
            // 
            // lblAlgorithm
            // 
            this.lblAlgorithm.AutoSize = true;
            this.lblAlgorithm.Location = new System.Drawing.Point(8, 135);
            this.lblAlgorithm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlgorithm.Name = "lblAlgorithm";
            this.lblAlgorithm.Size = new System.Drawing.Size(53, 13);
            this.lblAlgorithm.TabIndex = 3;
            this.lblAlgorithm.Text = "Algorithm:";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(8, 105);
            this.lblFilePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(51, 13);
            this.lblFilePath.TabIndex = 2;
            this.lblFilePath.Text = "File Path:";
            // 
            // txtOriginalHash
            // 
            this.txtOriginalHash.Location = new System.Drawing.Point(8, 34);
            this.txtOriginalHash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOriginalHash.Multiline = true;
            this.txtOriginalHash.Name = "txtOriginalHash";
            this.txtOriginalHash.Size = new System.Drawing.Size(336, 60);
            this.txtOriginalHash.TabIndex = 6;
            this.txtOriginalHash.TextChanged += new System.EventHandler(this.TxtOriginalHash_TextChanged);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(62, 102);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(203, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // lblOriginalHash
            // 
            this.lblOriginalHash.AutoSize = true;
            this.lblOriginalHash.Location = new System.Drawing.Point(5, 18);
            this.lblOriginalHash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOriginalHash.Name = "lblOriginalHash";
            this.lblOriginalHash.Size = new System.Drawing.Size(73, 13);
            this.lblOriginalHash.TabIndex = 0;
            this.lblOriginalHash.Text = "Original Hash:";
            // 
            // grbResult
            // 
            this.grbResult.Controls.Add(this.txtSafeToUse);
            this.grbResult.Controls.Add(this.lblSafeToUse);
            this.grbResult.Controls.Add(this.lblResultHash);
            this.grbResult.Controls.Add(this.txtResultHash);
            this.grbResult.Location = new System.Drawing.Point(10, 180);
            this.grbResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbResult.Name = "grbResult";
            this.grbResult.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbResult.Size = new System.Drawing.Size(354, 128);
            this.grbResult.TabIndex = 2;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "Result";
            // 
            // txtSafeToUse
            // 
            this.txtSafeToUse.Location = new System.Drawing.Point(74, 18);
            this.txtSafeToUse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSafeToUse.Name = "txtSafeToUse";
            this.txtSafeToUse.ReadOnly = true;
            this.txtSafeToUse.Size = new System.Drawing.Size(270, 20);
            this.txtSafeToUse.TabIndex = 5;
            // 
            // lblSafeToUse
            // 
            this.lblSafeToUse.AutoSize = true;
            this.lblSafeToUse.Location = new System.Drawing.Point(5, 18);
            this.lblSafeToUse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSafeToUse.Name = "lblSafeToUse";
            this.lblSafeToUse.Size = new System.Drawing.Size(64, 13);
            this.lblSafeToUse.TabIndex = 4;
            this.lblSafeToUse.Text = "Safe to use:";
            // 
            // lblResultHash
            // 
            this.lblResultHash.AutoSize = true;
            this.lblResultHash.Location = new System.Drawing.Point(8, 42);
            this.lblResultHash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultHash.Name = "lblResultHash";
            this.lblResultHash.Size = new System.Drawing.Size(68, 13);
            this.lblResultHash.TabIndex = 3;
            this.lblResultHash.Text = "Result Hash:";
            // 
            // txtResultHash
            // 
            this.txtResultHash.Location = new System.Drawing.Point(8, 61);
            this.txtResultHash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResultHash.Multiline = true;
            this.txtResultHash.Name = "txtResultHash";
            this.txtResultHash.ReadOnly = true;
            this.txtResultHash.Size = new System.Drawing.Size(336, 60);
            this.txtResultHash.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 313);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.grbHashInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

