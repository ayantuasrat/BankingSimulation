using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSimulation
{
    public partial class LoanRequestForm : Form
    {
        public LoanRequestForm()
        {
            InitializeComponent();
            foreach(var acc in BankData.Accounts)
            {
                cmbAccounts.Items.Add($"{acc.AccountNumber}-{acc.Name}");
            }
            if(cmbAccounts.Items.Count > 0) 
                cmbAccounts.SelectedIndex = 0;
        }

        private void LoanRequestForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRequestLoan_Click(object sender, EventArgs e)
        {
            if(cmbAccounts.SelectedItem == null)
            {
                MessageBox.Show("Please Select an account.");
                return;

            }
            decimal loanAmount;
            if(!decimal.TryParse(txtLoanAmount.Text.Trim(), out loanAmount) || loanAmount <= 0)
            {
                MessageBox.Show("Enter valid loan amount.");
                return;
            }
            string selected=cmbAccounts.SelectedItem.ToString();
            string accNum=selected.Split(',')[0].Trim();

            Loan loan = new Loan(accNum, loanAmount);
            BankData.Loans.Add(loan);

            var account = BankData.Accounts.FirstOrDefault(a => a.AccountNumber == accNum);
            if(account != null)
            {
                account.Balance += loanAmount;
            }
            MessageBox.Show($"Loan of ${loanAmount} approved.\n Account{accNum} new balance: ${account.Balance:F2}");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
