using System.Collections.Generic;

namespace ATMApp
{
    public class Customer
    {

        private string? name;

        private int pinCode;

        private int accountNr;

        private double balance { get; set; }

        public List<Customer> customer = new List<Customer>();
        public List<Customer> CustomerList()
        {
            customer.Add(new Customer() { name = "Poor Peggy", accountNr = 999, pinCode = 999, balance = 1000 });
            customer.Add(new Customer() { name = "Sleepy Joe", accountNr = 888, pinCode = 888, balance = 43000 });
            customer.Add(new Customer() { name = "Lucky Luke", accountNr = 777, pinCode = 777, balance = 155210.70 });
            return customer;
        }
        public int GetAccountNr() { return accountNr; }
        public string? GetName() => name;
        public int GetPinCode() { return pinCode; }
        public double GetBalance() { return balance; }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
    }
}