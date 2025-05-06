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
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
            foreach (var acc in BankData.Accounts)
            {
                string display = $"{acc.AccountNumber} - {acc.Name}";
                cmbFromAccount.Items.Add(display);
                cmbToAccount.Items.Add(display);
            }

            if(cmbFromAccount.Items.Count > 0)
            {
                cmbFromAccount.SelectedIndex = 0;
                cmbToAccount.SelectedIndex = 0;
            }
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            cmbFromAccount.Items.Clear();
            cmbToAccount.Items.Clear();

            foreach (var acc in BankData.Accounts)
            {
                string display = $"{acc.AccountNumber} - {acc.Name}";
                cmbFromAccount.Items.Add(display);
                cmbToAccount.Items.Add(display);
            }

            if (cmbFromAccount.Items.Count > 0) cmbFromAccount.SelectedIndex = 0;
            if (cmbToAccount.Items.Count > 0) cmbToAccount.SelectedIndex = 0;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (cmbFromAccount.SelectedItem == null || cmbToAccount.SelectedItem == null)
            {
                MessageBox.Show("Please select both source and destination accounts.");
                return;
            }

            if (cmbFromAccount.SelectedItem == cmbToAccount.SelectedItem)
            {
                MessageBox.Show("Source and destination accounts must be different.");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.");
                return;
            }

            string fromAccNum = cmbFromAccount.SelectedItem.ToString().Split('-')[0].Trim();
            string toAccNum = cmbToAccount.SelectedItem.ToString().Split('-')[0].Trim();

            var fromAccount = BankData.Accounts.FirstOrDefault(a => a.AccountNumber == fromAccNum);
            var toAccount = BankData.Accounts.FirstOrDefault(a => a.AccountNumber == toAccNum);

            if (fromAccount == null || toAccount == null)
            {
                MessageBox.Show("Account not found.");
                return;
            }

            if (fromAccount.Balance < amount)
            {
                MessageBox.Show("Insufficient funds in the source account.");
                return;
            }

            // Perform the transfer
            fromAccount.Balance -= amount;
            toAccount.Balance += amount;

            // Log transactions
            BankData.Transactions.Add(new Transaction(
                fromAccNum, "Transfer Out", amount, $"Transferred to {toAccNum}"));

            BankData.Transactions.Add(new Transaction(
                toAccNum, "Transfer In", amount, $"Received from {fromAccNum}"));

            MessageBox.Show($"Transfer successful!\nNew balance:\nFrom: {fromAccount.Balance:C}\nTo: {toAccount.Balance:C}");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
