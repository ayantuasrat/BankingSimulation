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
            MessageBox.Show("Deposit button was clicked");
            if(cmbAccountNumber.SelectedItem == null)
            {
                MessageBox.Show("Please select an account.");
                return;
            }
            string input = txtAmount.Text.Trim();

            if( !decimal.TryParse(input,out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Enter a valid deposit amount.");
                return;
            }
            string selected=cmbAccountNumber.SelectedItem.ToString();
            string accNumber=selected.Split(',')[0].Trim();

            var account=BankData.Accounts.FirstOrDefault(a=>a.AccountNumber == accNumber);
            if (account !=null)
            {
                account.Balance += amount;
                MessageBox.Show($"Successfully deposited ${amount} to account {account.AccountNumber}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Account not found!");
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
