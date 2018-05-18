using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBoardLibrary
{
    class Account : Person
    {
        private string username;
        private string password;
        private string email;
        private DateTime registrationDate;

        public Account (string username, string password, string email, DateTime registrationDate, string firstName, string lastName, DateTime birthDate)
            : base (firstName, lastName, birthDate)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.registrationDate = registrationDate;
    }
        public void NewAccount()
        {

        }

        public void DeleteAccount()
        {

        }

        public void ModifyPasssword()
        {

        }

        public void ModifyEmail()
        {

        }
    }
}
