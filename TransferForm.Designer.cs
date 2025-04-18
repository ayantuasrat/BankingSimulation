namespace BankingSimulation
{
    partial class TransferForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccountTransfer = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.cmbFromAccount = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.cmbToAccount = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 118);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(507, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "A.N.T TRANSFER";
            // 
            // lblAccountTransfer
            // 
            this.lblAccountTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccountTransfer.AutoSize = true;
            this.lblAccountTransfer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccountTransfer.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountTransfer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAccountTransfer.Location = new System.Drawing.Point(497, 215);
            this.lblAccountTransfer.Name = "lblAccountTransfer";
            this.lblAccountTransfer.Size = new System.Drawing.Size(365, 44);
            this.lblAccountTransfer.TabIndex = 5;
            this.lblAccountTransfer.Text = "Account Transfer";
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFrom.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFrom.Location = new System.Drawing.Point(80, 323);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(280, 38);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "From Account:";
            // 
            // cmbFromAccount
            // 
            this.cmbFromAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFromAccount.FormattingEnabled = true;
            this.cmbFromAccount.Location = new System.Drawing.Point(413, 323);
            this.cmbFromAccount.Name = "cmbFromAccount";
            this.cmbFromAccount.Size = new System.Drawing.Size(799, 28);
            this.cmbFromAccount.TabIndex = 7;
            // 
            // lblTo
            // 
            this.lblTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTo.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTo.Location = new System.Drawing.Point(80, 394);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(231, 38);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "To Account:";
            // 
            // cmbToAccount
            // 
            this.cmbToAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbToAccount.FormattingEnabled = true;
            this.cmbToAccount.Location = new System.Drawing.Point(413, 394);
            this.cmbToAccount.Name = "cmbToAccount";
            this.cmbToAccount.Size = new System.Drawing.Size(799, 28);
            this.cmbToAccount.TabIndex = 9;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAmount.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAmount.Location = new System.Drawing.Point(80, 459);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(172, 38);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Location = new System.Drawing.Point(413, 459);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(799, 38);
            this.txtAmount.TabIndex = 11;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTransfer.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(626, 535);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(166, 55);
            this.btnTransfer.TabIndex = 12;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(626, 625);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(166, 55);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankingSimulation.Properties.Resources.Registering_pic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1341, 797);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cmbToAccount);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.cmbFromAccount);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblAccountTransfer);
            this.Controls.Add(this.panel1);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccountTransfer;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ComboBox cmbFromAccount;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ComboBox cmbToAccount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnCancel;
    }
}