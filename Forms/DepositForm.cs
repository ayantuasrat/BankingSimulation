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
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
            foreach (var acc in BankData.Accounts)
            {
                cmbAccountNumber.Items.Add($"{acc.AccountNumber}-{acc.Name}");
            }
            if(cmbAccountNumber.Items.Count > 0)
            {
                cmbAccountNumber.SelectedIndex = 0;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbAccountNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            
            if (cmbAccountNumber.SelectedItem == null)
            {
                MessageBox.Show("Please select an account.");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.");
                return;
            }

            // Extract account number from combo box item
            string selected = cmbAccountNumber.SelectedItem.ToString();
            string accNum = selected.Split('-')[0].Trim(); // e.g. "12345 - Checking"

            // Find the account
            var account = BankData.Accounts.FirstOrDefault(a => a.AccountNumber == accNum);
            if (account != null)
            {
                account.Balance += amount;

                // Add a transaction log
                Transaction depositTransaction = new Transaction
                {
                    AccountNumber = accNum,
                    Type = "Deposit",
                    Amount = amount,
                    Date = DateTime.Now,
                    Note = "Deposit made"
                };
                BankData.Transactions.Add(depositTransaction);

                MessageBox.Show($"Deposit successful! New balance: {account.Balance:C}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Account not found.");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
