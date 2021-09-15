using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CustomerData; //class library

/*
 *Author: Tiffanie Wong
 *CPRG 200 Lab Assignment 2
 *Date: Sept 7th 2021
 * Purpose: Code for Electricity Bill GUI. Application calculates and displays customer data
 * in addition to statistics of accounts listed.
 */


namespace TWong_Lab2_CPRG006
{
    public partial class frmElectricBilling : Form
    {
        //list of customers
        List<Customer> accounts = new List<Customer>();
        
        const int ACCT_NO_SEED = 1000;

        public frmElectricBilling()
        {
            InitializeComponent();
        }

        //mock up accounts to display in list box
        private void frmElectricBilling_Load(object sender, EventArgs e)
        {
            Customer cust;
            cust = new Customer(ACCT_NO_SEED, "Sally", "Sailboat", 225.5m);
            accounts.Add(cust);
            cust = new Customer(ACCT_NO_SEED + 1, "Wendy", "Wombat", 534m);
            accounts.Add(cust);
            cust = new Customer(ACCT_NO_SEED + 2, "Simon", "Lodestone", 328m);
            accounts.Add(cust);

            DisplayAccounts();
            CalcStatistics();
        }



        //method to display list of customer accounts on the form
        private void DisplayAccounts()
        {
            lstCustomer.Items.Clear(); //start from scratch
            foreach (Customer c in accounts)
                lstCustomer.Items.Add(c.DisplayAccountNo()); 
 
        }
        

        //Event handler for exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CalcStatistics()
        {
            //declare variables for statistics
            int custCount = 0;
            decimal totalKwh = 0;
            decimal totalBills = 0;
            decimal avgBill = 0m;

            for (int i = 0; i < accounts.Count; i++)
            {
                // count number of customers processed
                custCount++;

                // calculation for total/sum of Kwh from all customers
                totalKwh += accounts[i].kwhAmount;

                // calc for total bill amount from all customers
                totalBills += accounts[i].BillAmount;
            }
            //calculate average for bill amount of all customers
            avgBill = totalBills / custCount;

            /*use ToString method to return display strings for customers processed,
            total kWh used and average bill amount*/
            lblCustAmt.Text = custCount.ToString();
            lblKWHUsed.Text = totalKwh.ToString();
            lblAvgBillAmt.Text = Math.Round(avgBill, 2).ToString("c");

        }

        //event handler to add a customer to list
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer newCust;
            int AcctNum = 0;

            //validate input first before adding data to the list
            if (Validator.IsPresent(txtFname) &&
            Validator.IsValidString(txtFname) &&
            Validator.IsPresent(txtLname) &&
            Validator.IsValidString(txtLname) &&
            Validator.IsPresent(txtKWHUsed) &&
            Validator.IsNonNegativeInt(txtKWHUsed))
            {
                DialogResult result = MessageBox.Show($"Confirm new customer account creation",
                "Please confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    foreach (Customer cust in accounts)
                        if (cust.AccountNumber > AcctNum)
                            AcctNum = cust.AccountNumber;
                    {
                        int newAcctNum = AcctNum + 1;
                        newCust = new Customer(newAcctNum, txtFname.Text, txtLname.Text, Convert.ToInt32(txtKWHUsed.Text));
                        accounts.Add(newCust);
                        lstCustomer.SelectedIndex = lstCustomer.Items.Count - 1;
                        
                    }
                    DisplayAccounts();
                    CalcStatistics();
                }
                else
                {
                    lstCustomer.SelectedIndex = -1; // make nothing selected
                    txtFname.Focus();
                }
            }
            ClearFields();
        }

        //event handler for when a customer account is selected in list box
        //when selected, the customer data is shown
        private void lstCustomer_Click(object sender, EventArgs e)
        {
            int idx = lstCustomer.SelectedIndex;
            btnAdd.Enabled = true;
            lblAcctNoDisplay.Text = accounts[idx].AccountNumber.ToString();
            lblBillAmt.Text = accounts[idx].BillAmount.ToString("c");
            txtFname.Text = accounts[idx].FName.ToString();
            txtLname.Text = accounts[idx].LName.ToString();
            txtKWHUsed.Text = accounts[idx].kwhAmount.ToString();

            //input fields disabled while customer account is selected from list and data displayed
            txtFname.Enabled = false;
            txtLname.Enabled = false;
            txtKWHUsed.Enabled = false;
        }

        //event handler to clear form fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        //method to clear clear all fields in form and focus on the first name field
        private void ClearFields()
        {
            txtFname.Text = String.Empty;
            txtLname.Text = String.Empty;
            txtKWHUsed.Text = String.Empty;
            lblAcctNoDisplay.Text = String.Empty;
            lblBillAmt.Text = String.Empty;

            //enable text boxes for input and focus is on first name
            txtFname.Enabled = true;
            txtLname.Enabled = true;
            txtKWHUsed.Enabled = true;
            txtFname.Focus();
        }
    }//end class
}//end namespace
