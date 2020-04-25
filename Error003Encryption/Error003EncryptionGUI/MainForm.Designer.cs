namespace Error003EncryptionGUI
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpEncDec = new System.Windows.Forms.GroupBox();
            this.radDecrypt = new System.Windows.Forms.RadioButton();
            this.radEncrypt = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblInputFilePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEncryptionTypes = new System.Windows.Forms.GroupBox();
            this.lstEncryptionTypes = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.grpEncDec.SuspendLayout();
            this.grpEncryptionTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 204);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(562, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.btnSubmit);
            this.grpInput.Controls.Add(this.grpEncDec);
            this.grpInput.Controls.Add(this.label2);
            this.grpInput.Controls.Add(this.txtPassword);
            this.grpInput.Controls.Add(this.btnBrowse);
            this.grpInput.Controls.Add(this.lblInputFilePath);
            this.grpInput.Controls.Add(this.label1);
            this.grpInput.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(329, 184);
            this.grpInput.TabIndex = 1;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(6, 131);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(176, 39);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // grpEncDec
            // 
            this.grpEncDec.Controls.Add(this.radDecrypt);
            this.grpEncDec.Controls.Add(this.radEncrypt);
            this.grpEncDec.Location = new System.Drawing.Point(208, 83);
            this.grpEncDec.Name = "grpEncDec";
            this.grpEncDec.Size = new System.Drawing.Size(115, 89);
            this.grpEncDec.TabIndex = 3;
            this.grpEncDec.TabStop = false;
            this.grpEncDec.Text = "Encrypt/Decrypt";
            // 
            // radDecrypt
            // 
            this.radDecrypt.AutoSize = true;
            this.radDecrypt.Location = new System.Drawing.Point(6, 42);
            this.radDecrypt.Name = "radDecrypt";
            this.radDecrypt.Size = new System.Drawing.Size(69, 20);
            this.radDecrypt.TabIndex = 1;
            this.radDecrypt.TabStop = true;
            this.radDecrypt.Text = "Decrypt";
            this.radDecrypt.UseVisualStyleBackColor = true;
            // 
            // radEncrypt
            // 
            this.radEncrypt.AutoSize = true;
            this.radEncrypt.Location = new System.Drawing.Point(6, 19);
            this.radEncrypt.Name = "radEncrypt";
            this.radEncrypt.Size = new System.Drawing.Size(68, 20);
            this.radEncrypt.TabIndex = 0;
            this.radEncrypt.TabStop = true;
            this.radEncrypt.Text = "Encrypt";
            this.radEncrypt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(7, 102);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(175, 23);
            this.txtPassword.TabIndex = 6;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(207, 49);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblInputFilePath
            // 
            this.lblInputFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInputFilePath.Location = new System.Drawing.Point(6, 50);
            this.lblInputFilePath.Name = "lblInputFilePath";
            this.lblInputFilePath.Size = new System.Drawing.Size(176, 21);
            this.lblInputFilePath.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input File:";
            // 
            // grpEncryptionTypes
            // 
            this.grpEncryptionTypes.Controls.Add(this.lstEncryptionTypes);
            this.grpEncryptionTypes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEncryptionTypes.Location = new System.Drawing.Point(347, 12);
            this.grpEncryptionTypes.Name = "grpEncryptionTypes";
            this.grpEncryptionTypes.Size = new System.Drawing.Size(203, 184);
            this.grpEncryptionTypes.TabIndex = 2;
            this.grpEncryptionTypes.TabStop = false;
            this.grpEncryptionTypes.Text = "Encryption Types";
            // 
            // lstEncryptionTypes
            // 
            this.lstEncryptionTypes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEncryptionTypes.FormattingEnabled = true;
            this.lstEncryptionTypes.ItemHeight = 16;
            this.lstEncryptionTypes.Location = new System.Drawing.Point(6, 22);
            this.lstEncryptionTypes.Name = "lstEncryptionTypes";
            this.lstEncryptionTypes.Size = new System.Drawing.Size(188, 148);
            this.lstEncryptionTypes.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 226);
            this.Controls.Add(this.grpEncryptionTypes);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "EasyEncrypt";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpEncDec.ResumeLayout(false);
            this.grpEncDec.PerformLayout();
            this.grpEncryptionTypes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpEncryptionTypes;
        private System.Windows.Forms.ListBox lstEncryptionTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblInputFilePath;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grpEncDec;
        private System.Windows.Forms.RadioButton radDecrypt;
        private System.Windows.Forms.RadioButton radEncrypt;
    }
}