using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBoardLibrary
{
    class Post
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

        private void CreatePost()
        {

        }

        private void ModifyPost()
        {

        }

        private void DeletePost()
        {

        }
    }
}
