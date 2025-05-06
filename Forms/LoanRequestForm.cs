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
            cmbAccounts.Items.Clear();
            foreach (var acc in BankData.Accounts)
            {
                cmbAccounts.Items.Add($"{acc.AccountNumber} - {acc.Name}");
            }

            if (cmbAccounts.Items.Count > 0)
                cmbAccounts.SelectedIndex = 0;

        }

        private void btnRequestLoan_Click(object sender, EventArgs e)
        {
            if (cmbAccounts.SelectedItem == null)
            {
                MessageBox.Show("Please select an account.");
                return;
            }

            if (!decimal.TryParse(txtLoanAmount.Text.Trim(), out decimal loanAmount) || loanAmount <= 0)
            {
                MessageBox.Show("Enter a valid loan amount.");
                return;
            }

            string selected = cmbAccounts.SelectedItem.ToString();
            string accNum = selected.Split('-')[0].Trim();

            var account = BankData.Accounts.FirstOrDefault(a => a.AccountNumber == accNum);
            if (account == null)
            {
                MessageBox.Show("Account not found.");
                return;
            }

            // Update balance
            account.Balance += loanAmount;

            // Log the loan
            Loan loan = new Loan
            {
                AccountNumber = accNum,
                Amount = loanAmount,
                InterestRate = 0.05, // or set your preferred rate
                IsApproved = true
            };
            BankData.Loans.Add(loan);

            // Log the transaction
            Transaction loanTransaction = new Transaction(
                accNum,
                "Loan",
                loanAmount,
                "Loan credited to account"
            );
            BankData.Transactions.Add(loanTransaction);

            MessageBox.Show($"Loan of {loanAmount:C} approved.\nAccount {accNum} new balance: {account.Balance:C}");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
