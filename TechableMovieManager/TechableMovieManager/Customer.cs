using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    class Customer
    {
        string firstName;
        string lastName;
        int customerId;

        public Customer (int customerId, string firstName, string lastName)
        {
            this.customerId = customerId;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int getCustomerId()
        {
            return customerId;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }
    }
}
