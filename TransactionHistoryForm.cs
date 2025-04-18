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
    public partial class TransactionHistoryForm : Form
    {
        public TransactionHistoryForm()
        {
            InitializeComponent();
            foreach(var acc in BankData.Accounts)
            {
                cmbAccounts.Items.Add($"{acc.AccountNumber}-{acc.Name}");
            }
            if (cmbAccounts.Items.Count > 0)
                cmbAccounts.SelectedIndex = 0;
        }

        private void TransactionHistoryForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTransaction.Items.Clear();
            if (cmbAccounts.SelectedItem == null)
                return;

            string selected = cmbAccounts.SelectedItem.ToString();
            string accNum = selected.Split('-')[0].Trim();

            var transactions = BankData.Transactions.Where(t => t.AccountNumber == accNum).OrderByDescending(t => t.Date);
            if (!transactions.Any())
            {
                lstTransaction.Items.Add("No Transactions for this Account.");
                return;
            }
            foreach(var tx in transactions)
            {
                lstTransaction.Items.Add($"{tx.Date:g}-{tx.Type}: ${tx.Amount:F2} {tx.Note}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
