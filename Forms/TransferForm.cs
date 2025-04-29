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

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (cmbFromAccount.SelectedIndex == -1 || cmbToAccount.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both source and destiantion accounts.");
                return;
            }
            if (cmbFromAccount.SelectedIndex == cmbToAccount.SelectedIndex)
            {
                MessageBox.Show("Cannot transfer to the same account");
                return;
            }
            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Enter a valid positive amount.");
                return;
            }
            string fromAccountNumber = cmbFromAccount.SelectedItem.ToString().Split('-')[0].Trim();
            string toAccountNumber = cmbToAccount.SelectedItem.ToString().Split('-')[0].Trim();

            var fromAccount = BankData.Accounts.FirstOrDefault(a => a.AccountNumber == fromAccountNumber);
            var toAccount = BankData.Accounts.FirstOrDefault(a => a.AccountNumber == toAccountNumber);

            if (fromAccount != null || toAccount != null)
            {
                MessageBox.Show("Accounts not found");
                return;
            }
            if(fromAccount.Balance < amount)
            {
                MessageBox.Show("Insufficient Funds.");
                return;
            }
            fromAccount.Balance -= amount;
            toAccount.Balance += amount;

            MessageBox.Show($"Transferred ${amount} from {fromAccount.AccountNumber} to {toAccount.AccountNumber}");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
