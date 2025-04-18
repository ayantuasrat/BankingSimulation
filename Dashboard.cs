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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            createaccount createForm = new createaccount();
            createForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login=new LoginForm();
            login.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            LoanRequestForm loanForm = new LoanRequestForm();
            loanForm.ShowDialog();
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            TransactionHistoryForm transactionForm=new TransactionHistoryForm();
            transactionForm.ShowDialog();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositForm deposit=new DepositForm();
            deposit.ShowDialog();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawForm Form=new WithdrawForm();
            Form.ShowDialog();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            TransferForm transfer=new TransferForm();
            transfer.ShowDialog();
        }

        private void btnViewBalance_Click(object sender, EventArgs e)
        {
            ViewBalanceForm balanceForm = new ViewBalanceForm();
            balanceForm.ShowDialog();
        }
    }
}
