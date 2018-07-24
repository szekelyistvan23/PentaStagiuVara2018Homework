using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CommonBoard.Models
{
    public class Post
    {   
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime TimeOfPosting { get; set; }
        public string Message { get; set; }
        public MessageType PostType { get; set; }
        public bool isSticky { get; set; }
        public int Priority { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
    public enum MessageType
    {
        Text,
        Photos
    }
}