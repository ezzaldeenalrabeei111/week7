using System;

namespace BlogEngineDataLayer.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        
        // Foreign Key
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
