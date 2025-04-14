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
    public partial class createaccount : Form
    {
        public createaccount()
        {
            InitializeComponent();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string accountType = cmbAccType.Text;
            string depositText=txtInitialDeposit.Text.Trim() ;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(accountType) || string.IsNullOrEmpty(depositText))
            {
                MessageBox.Show("Please fill out all the fields.");
                return;
            }

            if(!decimal.TryParse(depositText, out decimal deposit) || deposit <0)
            {
                MessageBox.Show("Please enter a valid deposit amount.");
                return;
            }
            BankAccount account = new BankAccount(name, accountType, deposit);
            BankData.Accounts.Add(account);

            MessageBox.Show($"Account created!\nAccount Number: {account.AccountNumber}");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
