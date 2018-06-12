using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBoardLibrary
{   
    public class Board
    {
        int length;
        Post[] posts;
        public event EventHandler MessageAdded;

        public Board(int length)
        {
            this.length = length;
            posts = new Post[length];
        }

        public Post this[int index]
        {
            get { return posts[index]; }
            set { posts[index] = value; }

        }


        public void AddMessage(string message, Account user, int index)
        { if (index < length - 1)
            {
                posts[index] = (new Post(index, DateTime.Now, message, user));
                OnMessageAdded(EventArgs.Empty);
            }
        }

        public void OnMessageAdded(EventArgs e)
        {
            if (MessageAdded != null)
            {
                MessageAdded(this, e);
            }
        }

        public bool DeleteMessage(int index)
        {
            Post[] temp = new Post[length];
            int count = 0;

            if (index <= posts.Length)
            {
                for (int i = 0; i < posts.Length; i++)
                {
                    if (i != index)
                    {
                        temp[count] = posts[i];
                        count++;
                    }
                }
                posts = temp;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ListMessages()
        {
            if (posts.Length > 0)
            {
                for (int index = posts.Length - 1; index >= 0; index--)
                {
                    if (posts[index] != null)
                    {
                        posts[index].ListPost();
                    }
                }
            } else if (posts[0] == null)
            {
                Console.WriteLine("No messages!");
            }
        }
    }
}

