using System;
using System.Collections.Generic;

namespace BlogEngineDataLayer.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishedDate { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<PostTag> PostTags { get; set; }
    }
}
