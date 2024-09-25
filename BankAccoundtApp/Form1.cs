using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccoundtApp
{
    public partial class Form1 : Form
    {
        //Create a list of CheckingAccounts
        List<CheckingAccount> accountList = new List<CheckingAccount>();
        public Form1()
        {
            InitializeComponent();

            //CheckingAccount ca1 = new CheckingAccount();

            //int accnum = ca1.AccountNumber;//read access of _accountNumber

            /*
             * build GUI lables and textboxes to enter accountNumber, balance and bankName
             * add bubtton to create a Checkingaccount object and saves it to a list
             * List<checkingAccount>
             * 
             * add a second button to display the list of checking account to a listbox or richTextbox (will show how to use a listview)
             */
            //CheckingAccount ca2 = new CheckingAccount(123567, 1200, "Chase");
            PreloadAccountList();
            DisplayAccountList();
        }

        //Method to preload accountList with few checkingaccounts objects
        private void PreloadAccountList()
        {
            Random random = new Random();
            string[] bankNames = {"JPMorgan Chase", "Bank of America","Wells Fargo",
            "Citibank", "U.S. Bank", "Goldman Sachs", "Trust Bank"};
            //make the checkingaccount random
            for(int i=1; i<=12; i++)
            {
                int accountNumber = random.Next(1111111, 99999999);
                decimal balance = random.Next(1000, 20000);
                int index = random.Next(bankNames.Length);
                String bankName = bankNames[index];
                //Create a random object
                CheckingAccount ca = new CheckingAccount(accountNumber, balance, bankName);
                //save to the list
                accountList.Add(ca);
            }
        }
        
        private void DisplayAccountList()
        {
            //clear the list
            lstCehckingAccount.Items.Clear();
            //sequence through the accountList and display every accounts saved
            foreach(CheckingAccount ca in accountList)
            {
                lstCehckingAccount.Items.Add(ca);//automatically calls the ToString
            }

            //=======================Display to th listview==================
            lsvCheckingAccount.Items.Clear();
            foreach(CheckingAccount ca in accountList)
            {
                //create a listviewitem: populate each column
                //listviewitem represents a sing row of data
                string[] rowData = {ca.BankName, ca.AccountNumber.ToString(), ca.Balance.ToString("c")};
                ListViewItem listViewItem = new ListViewItem(rowData);
                //add the new row (listViewItem) to the lstCheckingAccount (listview)
                lsvCheckingAccount.Items.Add(listViewItem);
            }
        }

        private void btndeposit_Click(object sender, EventArgs e)
        {
            //make sure the user has made a selection, count it greater than 0
            if(lsvCheckingAccount.SelectedIndices.Count > 0)
            {
                //give the frist row index selected
                int sIndex = lsvCheckingAccount.SelectedIndices[0];
                //use this index to the accountList to extract the real object (account)
                CheckingAccount ac = accountList[sIndex];
                //deposit
                decimal amount = decimal.Parse(txtAmount.Text);
                ac.Deposit(amount);
                //update the display the row/column within the listview
                DisplayAccountList(); //not the most practical way to do it.
            }
            
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            //make sure the user has made a selection, count it greater than 0
            if (lsvCheckingAccount.SelectedIndices.Count > 0)
            {
                //give the frist row index selected
                int sIndex = lsvCheckingAccount.SelectedIndices[0];
                //use this index to the accountList to extract the real object (account)
                CheckingAccount ac = accountList[sIndex];
                //withdraw
                decimal amount = decimal.Parse(txtAmount.Text);
                ac.Withdraw(amount);
                //update the display the row/column within the listview
                DisplayAccountList(); //not the most practical way to do it.
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            int accountNumber = int.Parse(txtAccountNumber.Text);
            decimal balance = decimal.Parse(txtBalance.Text);
            string bankName = txtBankName.Text; 
            CheckingAccount ca = new CheckingAccount(accountNumber, balance, bankName);
            //save to the list
            accountList.Add(ca);
            DisplayAccountList(); //not the most practical way to do it.
        }
    }
}
