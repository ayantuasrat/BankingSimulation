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
    public partial class ViewBalanceForm : Form
    {
        public ViewBalanceForm()
        {
            InitializeComponent();
            lstAccounts.Items.Clear();
            if(BankData.Accounts.Count == 0)
            {
                lstAccounts.Items.Add("No accounts found.");
                return;
            }
            foreach (var acc in BankData.Accounts)
            {
                lstAccounts.Items.Add($"Name;{acc.Name} | Account Number:{acc.AccountNumber} | Type: {acc.AccountType} | Balance: ${acc.Balance:F2}");
            }
    }

        private void lblAcountNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
