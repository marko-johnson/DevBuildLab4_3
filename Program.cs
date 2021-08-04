using System;

namespace Lab4_3
{
    class Customer
    {
        private string Company;
        private string ContactName;
        private string ContactEmail;
        private string Phone;


        public Customer(string _Company, string _ContactName, string _ContactEmail, string _Phone)
        {
            SetCompany(_Company);
            SetContactName(_ContactName);
            SetContactEmail(_ContactEmail);
            SetPhone(_Phone);

        }

        // Getters and Setters for Company
        public string GetCompany()
        {
            return Company;
        }

        public void SetCompany(string _Company)
        {
            Company = _Company;
        }

        // Getters and Setters for ContactName
        public string GetContactName()
        {
            return ContactName;
        }

        public void SetContactName(string _ContactName)
        {
            ContactName = _ContactName;
        }

        // Getters and Setters for ContactEmail
        public string GetContactEmail()
        {
            return ContactEmail;
        }

        public void SetContactEmail(string _ContactEmail)
        {
            ContactEmail = _ContactEmail;
        }


        // Getters and Setters for Phone
        public string GetPhone()
        {
            return Phone;
        }

        public void SetPhone(string _Phone)
        {
            Phone = _Phone;
        }


        public override string ToString()
        {
            return $"{Company} {ContactName} {ContactEmail} {Phone}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("\nRocket Mortgage", "\nMarko Johnson", "\nmarkojohnson@rocketmortgage.com", "\n(555) 555-1234");
            //Console.WriteLine(c1);
            //Console.WriteLine(c1.GetContactEmail());
            //Console.WriteLine(c1.GetPhone());
            //Console.WriteLine(c1.GetContactName());
            //Console.WriteLine(c1.GetCompany());

            string contacts = c1.ToString();
            Console.WriteLine(contacts);
        }
    }
}
