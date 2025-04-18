namespace BankingSimulation
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnViewBalance = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnTransactionHistory = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1396, 111);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(176, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1027, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO A.N.T BANKING";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(442, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 83);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(97, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Banking System Menu";
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateAcc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateAcc.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateAcc.Location = new System.Drawing.Point(194, 262);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(358, 77);
            this.btnCreateAcc.TabIndex = 2;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeposit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeposit.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeposit.Location = new System.Drawing.Point(194, 385);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(358, 77);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Deposit Money";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWithdraw.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWithdraw.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWithdraw.Location = new System.Drawing.Point(194, 505);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(358, 77);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Withdraw Money";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnViewBalance
            // 
            this.btnViewBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewBalance.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewBalance.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBalance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewBalance.Location = new System.Drawing.Point(194, 621);
            this.btnViewBalance.Name = "btnViewBalance";
            this.btnViewBalance.Size = new System.Drawing.Size(358, 77);
            this.btnViewBalance.TabIndex = 5;
            this.btnViewBalance.Text = "View Balance";
            this.btnViewBalance.UseVisualStyleBackColor = false;
            this.btnViewBalance.Click += new System.EventHandler(this.btnViewBalance_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTransfer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTransfer.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTransfer.Location = new System.Drawing.Point(873, 262);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(358, 77);
            this.btnTransfer.TabIndex = 6;
            this.btnTransfer.Text = "Transfer Money";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoan.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoan.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoan.Location = new System.Drawing.Point(873, 385);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(358, 77);
            this.btnLoan.TabIndex = 7;
            this.btnLoan.Text = "Request Loan";
            this.btnLoan.UseVisualStyleBackColor = false;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnTransactionHistory
            // 
            this.btnTransactionHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTransactionHistory.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTransactionHistory.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionHistory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTransactionHistory.Location = new System.Drawing.Point(873, 505);
            this.btnTransactionHistory.Name = "btnTransactionHistory";
            this.btnTransactionHistory.Size = new System.Drawing.Size(358, 77);
            this.btnTransactionHistory.TabIndex = 8;
            this.btnTransactionHistory.Text = "Transaction History";
            this.btnTransactionHistory.UseVisualStyleBackColor = false;
            this.btnTransactionHistory.Click += new System.EventHandler(this.btnTransactionHistory_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(873, 621);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(358, 77);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::BankingSimulation.Properties.Resources.istockphoto_1221471613_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1391, 844);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnTransactionHistory);
            this.Controls.Add(this.btnLoan);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnViewBalance);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnViewBalance;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button btnTransactionHistory;
        private System.Windows.Forms.Button btnLogout;
    }
}