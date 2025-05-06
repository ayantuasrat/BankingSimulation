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
    public partial class WithdrawForm : Form
    {
        public WithdrawForm()
        {
            InitializeComponent();
            foreach (var acc in BankData.Accounts)
            {
                cmbAccountNumber.Items.Add($"{acc.AccountNumber}-{acc.Name}");
            }
            if (cmbAccountNumber.Items.Count > 0)
            {
                cmbAccountNumber.SelectedIndex = 0;
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
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

            string selected = cmbAccountNumber.SelectedItem.ToString();
            string accNum = selected.Split('-')[0].Trim();

            var account = BankData.Accounts.FirstOrDefault(a => a.AccountNumber == accNum);
            if (account != null)
            {
                if (account.Balance >= amount)
                {
                    account.Balance -= amount;

                    Transaction withdrawTransaction = new Transaction(
                        accNum,
                        "Withdraw",
                        amount,
                        "Withdrawal made"
                    );
                    BankData.Transactions.Add(withdrawTransaction);

                    MessageBox.Show($"Withdrawal successful! New balance: {account.Balance:C}");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Insufficient balance.");
                }
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
    }
}
