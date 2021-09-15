using System;


/*
 *Author: Tiffanie Wong
 *CPRG 200 Lab Assignment 2
 *Date: Sept 7th 2021
 * Purpose: Code for Electricity Bill Application; this file defines
 * Customer class.
 */

namespace CustomerData
{
    public class Customer
    {
        //declaring private data
        private int accountno;
        private string fname;
        private string lname;
        private decimal kwhamt;
        private decimal billamt;

        //constant for admin fee
        const decimal ADMIN_FEE = 12m;

        //constant for kwh rate
        const decimal KWH_RATE = 0.07m;


        //public properties
        public int AccountNumber { get; set; }

        public string FName { get; set; } // auto-implemented property
                                          // compiler automatically private unnamed (anonymous) data for it

        public string LName { get; set; }

        public decimal kwhAmount
        {
            get { return kwhamt; }
            set
            {
                if (value >= 0) kwhamt = value;
                //else do nothing
            }
        }

        public decimal BillAmount
        {
            get { return billamt; }
            set
            {
                if (value >= 0) billamt = value;
            }
        }

        //define constructor & parameters for customer class 
        public Customer(int an, string fn = "Unknown", string ln = "Unknown", 
            decimal k = 0)
        {
            AccountNumber = an;
            FName = fn;
            LName = ln;
            kwhAmount = k;
            BillAmount = CalculateCharge();
        }

        //public methods 

        /// <summary>
        /// Method to calculate bill amount per customer
        /// </summary>
        /// <returns></returns>
        public decimal CalculateCharge()
        {
            //method to calculate the bill amount of customer
            BillAmount = ADMIN_FEE + (kwhamt * KWH_RATE);
            return BillAmount;
        }

        //display the account number in the form
        public string DisplayAccountNo()
        {
            return $"Account No.: {AccountNumber} | {FName} | {LName} | {kwhAmount} | {BillAmount.ToString("c")}";
        }


    }//end class
}//end namespace 
