using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBoardLibrary
{
    public class Post
    {
        private int id;
        private DateTime creationDate;
        private string content;
        private Account user;

        public Post(int id, DateTime creationDate, string content, Account user)
        {
            this.id = id;
            this.creationDate = creationDate;
            this.content = content;
            this.user = user;
        }

        public void ListPost()
        {
            Console.WriteLine("#{0} {1} Message: {2} Username: {3} e-mail: {4}", id, creationDate.ToString(), content, user.getUsername(), user.getEmail());
        }

        public int getId()
        {
            return id;
        }

    }
}
