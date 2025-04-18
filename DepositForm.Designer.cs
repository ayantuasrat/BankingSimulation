namespace BankingSimulation
{
    partial class DepositForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAcountnumber = new System.Windows.Forms.Label();
            this.cmbAccountNumber = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1381, 127);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(542, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 64);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "   A.N.T DEPOSIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(567, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Deposit Form";
            // 
            // lblAcountnumber
            // 
            this.lblAcountnumber.AutoSize = true;
            this.lblAcountnumber.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAcountnumber.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcountnumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAcountnumber.Location = new System.Drawing.Point(28, 285);
            this.lblAcountnumber.Name = "lblAcountnumber";
            this.lblAcountnumber.Size = new System.Drawing.Size(369, 44);
            this.lblAcountnumber.TabIndex = 2;
            this.lblAcountnumber.Text = "Account Number:";
            // 
            // cmbAccountNumber
            // 
            this.cmbAccountNumber.FormattingEnabled = true;
            this.cmbAccountNumber.Location = new System.Drawing.Point(518, 285);
            this.cmbAccountNumber.Name = "cmbAccountNumber";
            this.cmbAccountNumber.Size = new System.Drawing.Size(741, 28);
            this.cmbAccountNumber.TabIndex = 3;
            this.cmbAccountNumber.SelectedIndexChanged += new System.EventHandler(this.cmbAccountNumber_SelectedIndexChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAmount.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAmount.Location = new System.Drawing.Point(28, 389);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(410, 44);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount to Deposit:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(518, 389);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(741, 44);
            this.txtAmount.TabIndex = 5;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDeposit.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(653, 515);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(202, 65);
            this.btnDeposit.TabIndex = 6;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(653, 623);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(202, 65);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankingSimulation.Properties.Resources.Registering_pic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1380, 838);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cmbAccountNumber);
            this.Controls.Add(this.lblAcountnumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "DepositForm";
            this.Text = "DepositForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAcountnumber;
        private System.Windows.Forms.ComboBox cmbAccountNumber;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnCancel;
    }
}