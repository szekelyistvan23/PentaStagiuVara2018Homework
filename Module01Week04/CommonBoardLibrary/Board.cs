using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBoardLibrary
{
     public class Board
    {
        List<Post> posts;

        public Board()
        {
            this.posts = new List<Post>();
        }

        public void AddMessage(string message, Account user)
        {
            posts.Add(new Post(posts.Count+1, DateTime.Now, message, user));
        }

        public bool DeleteMessage(int id)
        {
            foreach (Post post in posts)
            {
                if (post.getId() == id)
                {
                    posts.Remove(post);
                    return true;
                }
            }
            return false;
        }

        public void ListMessages()
        {
            if (posts.Count > 0)
            {
                for (int index = posts.Count - 1; index >= 0; index--)
                {
                    posts[index].ListPost();
                }
            } else
            {
                Console.WriteLine("No messages!");
            }
        }
    }
}
