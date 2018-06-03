using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBoardLibrary
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }

        public void ModifyFirstName(String newFirstName)
        {
            firstName = newFirstName;
        }
       
        public void ModifyLastName(String newLastName)
        {
            lastName = newLastName;
        }
    }
}
