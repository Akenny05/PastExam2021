using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastExam2021
{
    internal class SavingsAccount:Account
    {
        // constants
        private const decimal INTEREST_RATE = 0.06M;

        public SavingsAccount(string firstName, string lastName, decimal balance, DateTime interestDate , string accountNumber)
            : base(firstName, lastName, balance, interestDate , accountNumber) { }

        //methods
        public override void CalculateInterest()
        {
            // check if interest has been set in the previous year
            DateTime allowedDate = DateTime.Now.AddYears(-1);
            if (allowedDate >= InterestDate)
            {
                Balance = Balance + (Balance * INTEREST_RATE);
                InterestDate = DateTime.Now;
            }

        }
    }
}
