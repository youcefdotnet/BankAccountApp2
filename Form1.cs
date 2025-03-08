namespace BankAccountApp2
{
    public partial class Form1 : Form
    {
        List<BankAccount> bankaccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerTxt.Text))
            {
                MessageBox.Show("Owner is empty or null");
                return;
            }
            else
                bankaccounts.Add(new BankAccount(OwnerTxt.Text));
            RefreshGrid();
            OwnerTxt.Text = string.Empty;
        }

        public void RefreshGrid()
        {
            AccountsGrid.DataSource = null;
            AccountsGrid.DataSource = bankaccounts;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (AccountsGrid.SelectedRows.Count == 1 && NumAmount.Value > 0)
            {
                BankAccount SelectedAccount = AccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string msg = SelectedAccount.Deposit(NumAmount.Value);
                MessageBox.Show(msg);
            }

            RefreshGrid();
            NumAmount.Value = 0;
            
        }
    }
}
