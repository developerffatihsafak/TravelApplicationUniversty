using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentUSer { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentHead { get; set; }
        public string CommentContent { get; set; }
        public bool CommentState { get; set; }

        public virtual int DestinationId { get; set; }
        public Destination Destination { get; set; }
    }
}
