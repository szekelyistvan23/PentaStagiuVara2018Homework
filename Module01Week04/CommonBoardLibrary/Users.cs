using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBoardLibrary
{
    class Users
    {
        List<Account> users;
        public void AddUser(Account user)
        {
            users.Add(user);
        }

        public bool FindUser(Account user)
        {
            foreach (Account member in users)
            {
                if (member.Equals(user)){
                    return true;
                }
            }
            return false;
        }

        public void RemoveUser(Account user)
        {
            if (FindUser(user) == true)
            {
                users.Remove(user);
                Console.WriteLine("The user's account was removed.");
            } else
            {
                Console.WriteLine("There is no user with this name.");
            }
        }
    } 
}
