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
            string input = txtAmount.Text.Trim();
            if (!decimal.TryParse(input, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Enter a valid withdrawal amount.");
                return;
            }
            string selected=cmbAccountNumber.SelectedItem.ToString();
            string accNumber=selected.Split(',')[0].Trim();

            var account=BankData.Accounts.FirstOrDefault(a=>a.AccountNumber == accNumber);
            if (account != null)
            {
                if (account.Balance >= amount)
                {
                    account.Balance -= amount;
                    MessageBox.Show($"Withdraw ${amount} from account {account.AccountNumber}");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Insufficient Balance.");
                }
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
